using System;
using System.Windows.Forms;
using METIER;

namespace WF
{
    public partial class F_Edit_Gerant : Form
    {
        private state state;
        private ListBox.ObjectCollection items;
        private int position;
        private state old;
        private LesGerants lg;
        public F_Edit_Gerant(state _state,state _stateInitial, ListBox.ObjectCollection _items, int _position)
        {
            InitializeComponent();
            btn_valider.Click += Btn_valider_Click;
            this.state = _state;
            this.items = _items;
            this.position = _position;
            this.old = _stateInitial;

            switch (state)
            {
                case state.modified:
                    tb_id.Visible = true;
                    l_id.Visible = true;
                    Gerant g = (Gerant)items[position];
                    this.tb_id.Text = g.Id.ToString();
                    this.tb_age.Text = g.Age.ToString();
                    this.tb_nom.Text = g.Nom.ToString();
                    this.tb_pwd.Text = g.Password.ToString();
                    this.tb_prenom.Text = g.Prenom.ToString();
                    this.tb_bud.Text = g.Budget.ToString();
                    this.Text = "Modification d'une Course.";
                    break;
            }
        }
        public F_Edit_Gerant(state _state, ListBox.ObjectCollection _items, LesGerants lg)
        {
            InitializeComponent();
            btn_valider.Click += Btn_valider_Click;
            this.state = _state;
            this.items = _items;
            this.lg = lg;

            switch (state)
            {
                case state.added:
                    this.Text = "Création d'un Gérant";
                    break;
            }
        }
        private void Btn_valider_Click(object sender, EventArgs e)
        {
            switch (this.state)
            {
                case state.modified:
                    Gerant g = (Gerant)items[this.position];
                    g.Age = (Convert.ToInt32(this.tb_age.Text));
                    g.Prenom = (this.tb_prenom.Text);
                    g.Nom = (this.tb_nom.Text);
                    g.Password = (this.tb_pwd.Text);
                    g.Budget = (Convert.ToInt32(this.tb_bud.Text));
                    if (this.old == 0)
                    {
                        g.State1 = (0);
                    }
                    else
                    {
                        g.State1 = (this.state);
                    }

                    items[this.position] = g;
                    break;
                case state.added:
                    Gerant ge = new Gerant(tb_nom.Text, tb_prenom.Text, Convert.ToInt32(tb_age.Text), tb_pwd.Text, this.state,Convert.ToInt32(tb_bud.Text), lg.LastID);
                    this.lg.Add(ge);
                    items.Add(ge);
                    break;
            }
            this.Close();
        }

    }
}
