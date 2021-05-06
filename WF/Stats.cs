using System;
using System.Windows.Forms;
using METIER;

namespace WF
{
    public partial class Stats : Form
    {
        private ListBox.ObjectCollection lesLaps;
        public Stats(ListBox.ObjectCollection laps)
        {
            this.lesLaps = laps;
            InitializeComponent();
            this.Text = "Détail d'un Lapin";
            cb_laps.SelectedIndexChanged += Cb_laps_SelectedIndexChanged;
            foreach (Lapins item in lesLaps)
            {
                cb_laps.Items.Add(item);
            }
            btn_quit.Click += Btn_quit_Click;
            
        }

        private void Btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cb_laps_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Lapins l = (Lapins)cb_laps.Items[cb_laps.SelectedIndex];
            this.tb_age.Text = l.GetAge().ToString();
            this.tb_id.Text = l.GetId().ToString();
            this.tb_sur.Text = l.GetSurnom().ToString();
            this.pb_chance.Value = l.Chance;
            this.pb_endurance.Value = l.Endurance;
            this.pb_vitesse.Value = l.Vitesse;
            this.l_valeur.Text = l.Valeur.ToString() + " $";
        }
    }
}
