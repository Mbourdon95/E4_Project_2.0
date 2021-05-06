using System;
using System.Windows.Forms;
using METIER;

namespace WF
{
    public partial class F_EDIT_Course : Form
    {
        private state state;
        private ComboBox.ObjectCollection items;
        private LesCourses lc;
        public F_EDIT_Course(state _state, ComboBox.ObjectCollection _items, LesCourses lc)
        {
            InitializeComponent();
            btn_valider.Click += Btn_valider_Click;
            this.state = _state;
            this.items = _items;
            this.lc = lc;

            switch (state)
            {
                case state.added:
                    this.Text = "Création d'une Course";
                    break;
            }
        }
        private void Btn_valider_Click(object sender, EventArgs e)
        {
            switch (this.state)
            {
                case state.added:
                    Course c = new Course(lc.LastID,Convert.ToInt32(tb_distance.Text), tb_nom.Text, Convert.ToInt32(tb_prix.Text), Convert.ToInt32(tb_te.Text), this.state);
                    this.lc.Add(c);
                    items.Add(c);
                    break;
            }
            this.Close();
        }
    }
}
