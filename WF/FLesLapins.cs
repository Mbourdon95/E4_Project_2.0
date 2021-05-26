using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using METIER;
using DAO;
using System.Text.RegularExpressions;

namespace WF
{
    public partial class FLesLapins : Form
    {
        private int idGerant;
        private Gerant lEntraineur;
        private lesLapins lp;
        private List<Lapins> lapinASave;
        private List<Lapins> tousLesLapins;
        public FLesLapins(Gerant entraineur, List<Lapins> lesLapins)
        {
            this.idGerant = entraineur.Id;
            this.lEntraineur = entraineur;
            this.lp = new lesLapins();
            this.lapinASave = new List<Lapins>();
            this.tousLesLapins = new List<Lapins>();
            InitializeComponent();
            btn_gen.Click += Btn_gen_Click;
            btn_bannir.Click += Btn_bannir_Click;
            btn_add.Click += Btn_add_Click;
            btn_modif.Click += Btn_modif_Click;
            lb_mesLapins.SelectedIndexChanged += Lb_mesLapins_SelectedIndexChanged;
            btn_Details.Click += Btn_Details_Click;
            btn_stat.Click += Btn_stat_Click;
            btn_save.Click += Btn_save_Click;
            btn_Inscrire.Click += Btn_Inscrire_Click;
            this.FormClosed += FLesLapins_FormClosed;
            load(lesLapins);
            this.l_budget.Text = this.lEntraineur.Budget.ToString() + " $";
            this.l_place.Text = (5-lb_mesLapins.Items.Count).ToString() + " / 5";
        }

        private void FLesLapins_FormClosed(object sender, FormClosedEventArgs e)
        {
            return;
        }

        private void Btn_Inscrire_Click(object sender, EventArgs e)
        {
            if (lb_mesLapins.SelectedIndex == -1)
            {
                return;
            }
            F_lesCourses fLesCourses = new F_lesCourses((Lapins)lb_mesLapins.Items[lb_mesLapins.SelectedIndex],this.lEntraineur);
            fLesCourses.Show();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            string val = Regex.Replace(this.l_budget.Text, "[^-0-9.]", "");
            if (this.lEntraineur.Budget != Convert.ToInt32(val))
            {
                this.lEntraineur.State1 = state.modified;
            }
            this.lEntraineur.Budget = Convert.ToInt32(val);
            List<Lapins> laps = new List<Lapins>();
            foreach (object o in lb_LapinsLibres.Items)
            {
                laps.Add((Lapins)o);
            }
            foreach (object o in lb_mesLapins.Items)
            {
                laps.Add((Lapins)o);
            }
            new DaoLapin().SaveChanges(laps);
            new DaoGerant().SaveChanges(this.lEntraineur);
            this.lapinASave= laps;
            var distOrdered = this.lapinASave.OrderBy(n => n.GetId()).ToList();
            this.load((List<Lapins>)distOrdered);
        }

        private void Btn_stat_Click(object sender, EventArgs e)
        {
            Stats fLesLaps = new Stats(lb_LapinsLibres.Items);
            fLesLaps.Show();
        }

        private void Btn_Details_Click(object sender, EventArgs e)
        {
            Stats fLesLaps = new Stats(lb_mesLapins.Items);
            fLesLaps.Show();
        }

        private void Lb_mesLapins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_mesLapins.SelectedIndex == -1)
            {
                tb_sur.Text = " ";
                return;
            }
            Lapins unLapinAMoi = (Lapins)lb_mesLapins.Items[lb_mesLapins.SelectedIndex];
            tb_sur.Text = unLapinAMoi.GetSurnom();
        }

        private void Btn_modif_Click(object sender, EventArgs e)
        {
            Lapins leLapin = (Lapins)lb_mesLapins.Items[lb_mesLapins.SelectedIndex];
            leLapin.SetSurnom(tb_sur.Text);
            if (leLapin.GetState() == state.unChanged || leLapin.GetState() == state.modified)
            {
                leLapin.SetState(state.modified);
            }
            lb_mesLapins.Items.RemoveAt(lb_mesLapins.SelectedIndex);
            lb_mesLapins.Items.Add(leLapin);
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Lapins leLapin = (Lapins)this.lb_LapinsLibres.Items[lb_LapinsLibres.SelectedIndex];
            if (lb_mesLapins.Items.Count == 5)
            {
                return;
            }
            if (leLapin.OffreMinimal == 0)
            {
                MessageBox.Show("Ce Lapin a déjà été démarché.");
                lb_LapinsLibres.Items.RemoveAt(lb_LapinsLibres.SelectedIndex);
                return;
            }

            F_Encheres f_Encheres = new F_Encheres(this.lEntraineur, lb_mesLapins.Items, lb_LapinsLibres.Items,lb_LapinsLibres.SelectedIndex, l_place, l_budget);
            f_Encheres.Show();
        }

        private void Btn_bannir_Click(object sender, EventArgs e)
        {
            if (lb_mesLapins.SelectedIndex == -1)
            {
                return;
            }
            Lapins a = (Lapins)lb_mesLapins.Items[lb_mesLapins.SelectedIndex];
            a.SetState(state.modified);
            a.SetIdGerant(0);
            string val = Regex.Replace(this.l_budget.Text, "[^0-9.]", "");
            this.l_budget.Text = (Convert.ToInt32(val) + (a.Valeur/2)).ToString() + " $";
            lb_mesLapins.Items.RemoveAt(lb_mesLapins.SelectedIndex);
            lb_LapinsLibres.Items.Add(a);
            this.l_place.Text = (5 - lb_mesLapins.Items.Count).ToString() + " / 5";
        }

        private void Btn_gen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Lapins a = new Lapins(lp.LastID, "a",state.added, 0);
                this.lp.Add(a);
                lb_LapinsLibres.Items.Add(a);
                
            }
        }

        private void load(List<Lapins> lesLapin)
        {
            lb_LapinsLibres.Items.Clear();
            lb_mesLapins.Items.Clear();
            foreach (Lapins l in lesLapin)
            {
                this.lp.Add(l);
                this.tousLesLapins.Add(l);
                if (l.GetIdGerant() == this.idGerant)
                {
                    lb_mesLapins.Items.Add(l);
                }
                if (l.GetIdGerant() == 0)
                {
                    lb_LapinsLibres.Items.Add(l);
                }
                
                
            }
        }
    }

}
