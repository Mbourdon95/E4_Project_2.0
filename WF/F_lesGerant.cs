using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAO;
using METIER;

namespace WF
{
    public partial class F_lesGerant : Form
    {
        private LesGerants lg;
        private List<Lapins> lesLapins;
        public F_lesGerant()
        {
            InitializeComponent();
            this.lg = new LesGerants();
            btn_Connexion.Click += Btn_Connexion_Click;
            btn_modif.Click += Btn_modif_Click;
            btn_Add.Click += Btn_Add_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_save.Click += Btn_save_Click;
            btn_up.Click += Btn_up_Click;
            this.lesLapins = new List<Lapins>();
            this.lesLapins = new DaoLapin().GetAll();
            load(new DaoGerant().GetAll());
        }
        private void Btn_up_Click(object sender, EventArgs e)
        {
            int position = lb_lesGerants.SelectedIndex;
            Gerant gerant = (Gerant)lb_lesGerants.Items[position];
            F_Edit_Gerant fedit = new F_Edit_Gerant(state.modified,gerant.State1,lb_lesGerants.Items, position);
            fedit.Show();
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            List<Gerant> lesGerants = new List<Gerant>();
            foreach (object o in lb_lesGerants.Items)
            {
                lesGerants.Add((Gerant)o);
            }
            new DaoGerant().SaveChanges(lesGerants);
            this.load(lesGerants);
        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Gerant g = (Gerant)lb_lesGerants.Items[lb_lesGerants.SelectedIndex];
            g.State1=(state.deleted);
            lb_lesGerants.Items[lb_lesGerants.SelectedIndex] = g;

        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            F_Edit_Gerant fadd = new F_Edit_Gerant(state.added, lb_lesGerants.Items,lg);
            fadd.Show();
        }
        private void Btn_modif_Click(object sender, EventArgs e)
        {
            if (lb_lesGerants.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez Choisir un Gérant");
                return;
            }
            if (btn_modif.Text == "Modifier")
            {
                lb_lesGerants.Enabled = false;
                btn_modif.Text = "Fin";
                btn_save.Visible = false;
                btn_delete.Visible = true;
                btn_up.Visible = true;
                btn_Add.Visible = false;
            }
            else
            {
                lb_lesGerants.Enabled = true;
                btn_modif.Text = "Modifier";
                btn_save.Visible = true;
                btn_delete.Visible = false;
                btn_up.Visible = false;
                btn_Add.Visible = true;
            }
            
        }
        private void Btn_Connexion_Click(object sender, EventArgs e)
        {
            if (btn_modif.Text != "Modifier")
            {
                Btn_modif_Click(sender, e);
            }
            if (tb_Password.Text == "")
            {
                MessageBox.Show("OOPS ! Il n\'y a pas de Password", "Erreur");
                return;
            }          
            if (lb_lesGerants.SelectedIndex != -1)
            {
                int position = lb_lesGerants.SelectedIndex;
                Gerant g = (Gerant)lb_lesGerants.Items[position];
                if (g.State1 == state.added)
                {
                    Btn_save_Click(sender, e);
                }
                if (g.State1 == state.deleted)
                {
                    MessageBox.Show("Vous ne pouvez pas vous connectez à un compte delete.", "Erreur de Connexion");
                }
                if (tb_Password.Text == g.Password)
                {
                    FLesLapins fLesLaps = new FLesLapins(g,this.lesLapins);
                    fLesLaps.Show();
                }
                else
                {
                    MessageBox.Show("Vous vous êtes trompés de Password ou de Gérant", "Erreur de Connexion");
                }
            }
        }
        private void load(List<Gerant> lesGerants)
        {
            lb_lesGerants.Items.Clear();
            foreach (Gerant g in lesGerants)
            {
                this.lg.Add(g);
                lb_lesGerants.Items.Add(g);
            }
        }
    }
}
