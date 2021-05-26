using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DAO;
using METIER;

namespace WF
{
    public partial class F_Encheres : Form
    {
        private Gerant unGerant;
        private Lapins leLapin;
        private ListBox.ObjectCollection itemsLapinsEquipe;
        private ListBox.ObjectCollection itemLapinsLibres;
        private int position;
        private Label items_Count;
        private Label gerantBudget;
        public F_Encheres(Gerant _unGerant, ListBox.ObjectCollection _itemsLapinsEquipe, ListBox.ObjectCollection _itemLapinsLibres,int _pos, Label count, Label budget)
        {
            InitializeComponent();
            btn_refresh.Click += F_Encheres_Click;
            btn_valider.Click += Btn_valider_Click;
            tb_offre.TextChanged += Tb_offre_TextChanged;
            this.position = _pos;
            this.unGerant = _unGerant;
            this.itemLapinsLibres = _itemLapinsLibres;
            this.itemsLapinsEquipe = _itemsLapinsEquipe;
            this.leLapin = (Lapins)this.itemLapinsLibres[this.position];
            this.items_Count = count;
            this.gerantBudget = budget;
            this.l_vitesse.Text = this.leLapin.Vitesse.ToString();
            this.l_endurance.Text = this.leLapin.Endurance.ToString();
            this.l_chance.Text = this.leLapin.Chance.ToString();
            this.l_leLapin.Text = this.leLapin.ToString();
            this.l_offreA.Text = this.leLapin.OffreMinimal.ToString() + " $";
            this.l_valeurL.Text = this.leLapin.Valeur.ToString() + " $";
            this.l_prixMax.Text = (this.leLapin.Valeur * 1.10).ToString() + " $";
        }
        private void Tb_offre_TextChanged(object sender, EventArgs e)
        {
            if (tb_offre.Text == (this.leLapin.Valeur*1.10).ToString())
            {
                btn_valider.Text = "Acheter Immédiatement";
                return;
            }
            btn_valider.Text = "Envoyer Offre";
        }
        private void Btn_valider_Click(object sender, EventArgs e)
        {
            if (tb_offre.Text == "")
            {
                return;
            }
            validation();
            string offre = Regex.Replace(this.tb_offre.Text, "[^0-9.]", "");
            if (btn_valider.Text == "Acheter Immédiatement")
            {
                this.itemLapinsLibres.RemoveAt(this.position);
                this.itemsLapinsEquipe.Add(this.leLapin);
                if (this.leLapin.GetState() == state.unChanged || this.leLapin.GetState() == state.modified)
                {
                    this.leLapin.SetState(state.modified);
                }            
                this.leLapin.OffreMinimal = 0;
                this.leLapin.SetIdGerant(this.unGerant.Id);
                this.items_Count.Text = (5 - itemsLapinsEquipe.Count).ToString() + " / 5";
                this.unGerant.Budget -= Convert.ToInt32(offre);
                this.gerantBudget.Text = (this.unGerant.Budget - Convert.ToInt32(offre)).ToString() + " $";
                this.Close();
            }
            if ((Convert.ToInt32(offre) > this.leLapin.OffreMinimal && (Convert.ToInt32(offre) < this.leLapin.Valeur)))
            {
                this.leLapin.OffreMinimal = (Convert.ToInt32(offre)) ;
                this.l_offreA.Text = offre + " $";
            }
        }
        private void F_Encheres_Click(object sender, EventArgs e)
        {
            validation();
            this.l_offreA.Text = this.leLapin.OffreMinimal.ToString() + " $";
        }
        private void validation()
        {
            if (this.leLapin.OffreMinimal == 0)
            {
                MessageBox.Show("L'Enchère est terminée.");
                this.itemLapinsLibres.RemoveAt(this.position);
                this.Close();
            }
        }

    }
}
