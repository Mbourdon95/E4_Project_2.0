using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAO;
using METIER;

namespace WF
{
    public partial class F_lesCourses : Form
    {
        private LesCourses lc;
        private List<Course> lesCourses;
        private List<Participer> lesP;
        private List<Participer> lesNouveauxParticipants;
        private Lapins leLap;
        private Gerant leG;

        public F_lesCourses(Lapins unLapin, Gerant g)
        {
            InitializeComponent();
            lc = new LesCourses();
            this.leG = g;
            this.leLap = unLapin;
            tb_leLapin.Text = this.leLap.ToString();
            this.lesP = new List<Participer>();
            this.lc = new LesCourses();
            this.lesNouveauxParticipants = new List<Participer>();
            btn_inscription.Click += Btn_inscription_Click;
            btn_desinscrire.Click += Btn_desinscrire_Click;
            btn_quit.Click += Btn_quit_Click;
            cb_lesCourses.SelectedIndexChanged += Cb_lesCourses_SelectedIndexChanged;
            btn_lancer.Visible = false;
            btn_create.Visible = false;
            btn_desinscrire.Visible = false;
            btn_inscription.Visible = false;
            btn_save.Click += Btn_save_Click;
            this.l_bud.Text = this.leG.Budget.ToString() + " $";
            this.load(new DaoCourse().GetAll(), new DaoParticiper().GetAll());
        }
        public F_lesCourses()
        {
            InitializeComponent();
            this.lc = new LesCourses();
            this.lesCourses = new List<Course>();
            this.lesNouveauxParticipants = new List<Participer>();
            this.lesP = new List<Participer>();
            btn_lancer.Click += Btn_lancer_Click;
            btn_quit.Click += Btn_quit_Click;
            btn_desinscrire.Visible = false;
            btn_inscription.Visible = false;
            cb_lesCourses.SelectedIndexChanged += Cb_lesCourses_SelectedIndexChanged;
            btn_create.Click += Btn_create_Click;
            btn_save.Click += Btn_save_Click;
            btn_inscription.Visible = false;
            this.l_lap.Visible = false;
            this.tb_leLapin.Visible = false;
            this.l_bud.Visible = false;
            this.l_budR.Visible = false;
            this.leLap = null;
            this.load(new DaoCourse().GetAll(), new DaoParticiper().GetAll());
        }
        private void Btn_desinscrire_Click(object sender, EventArgs e)
        {
            if (cb_lesCourses.SelectedIndex == -1)
            {
                return;
            }
            Course c = (Course)cb_lesCourses.Items[cb_lesCourses.SelectedIndex];
            List<Lapins> lLap = new List<Lapins>();
            if (c.Depart)
            {
                foreach (Participer item in this.lesNouveauxParticipants)
                {
                    l_tarif.Text = "1";
                    if (item.IdLapin == this.leLap.GetId())
                    {
                        item.State1 = state.deleted;
                    }
                }
                foreach (Participer item in this.lesP)
                {
                    if (item.IdLapin == this.leLap.GetId())
                    {
                        item.State1 = state.deleted;
                    }
                }
                lb_lapinsInscrits.Items.Clear();
                foreach (Lapins l in c.Participer())
                {
                    if (l.GetId() != this.leLap.GetId())
                    {
                        lLap.Add(l);
                        lb_lapinsInscrits.Items.Add(l);
                    }
                    
                }
                c.Participer().Clear();
                c.LosParticipantes1 = lLap;
                btn_inscription.Visible = true;
                btn_desinscrire.Visible = false;
                cb_lesCourses.SelectedIndex = -1;
            }
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            List<Course> lesCourses = new List<Course>();
            List<Participer> lesParticipants = new List<Participer>();
            foreach (object o in cb_lesCourses.Items)
            {
                lesCourses.Add((Course)o);
            }
            new DaoCourse().SaveChanges(lesCourses);
            this.lesCourses = lesCourses;
            foreach (Course c in this.lesCourses)
            {
                var a = this.lesP.Where(x => x.IdCourse == c.GetId()).ToList();
                foreach (Lapins l in c.Participer())
                {
                    
                    foreach (Participer p in a)
                    {
                        if (p.IdLapin == l.GetId())
                        {
                            if (c.LeGagnant == l)
                            {
                                p.State1 = state.modified;
                                lesParticipants.Add(p);
                            }
                            else
                            {
                                lesParticipants.Add(p);
                            }
                        }
                    }
                }
            }
            this.lesP = lesParticipants;
            this.lesP.AddRange(this.lesNouveauxParticipants);
            new DaoParticiper().SaveChanges(this.lesP);
            this.load(this.lesCourses, new DaoParticiper().GetAll());
        }
        private void Btn_create_Click(object sender, EventArgs e)
        {
            F_EDIT_Course fadd = new F_EDIT_Course(state.added,cb_lesCourses.Items, lc);
            fadd.Show();
        }
        private void Cb_lesCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_lesCourses.SelectedIndex == -1)
            {
                lb_lapinsInscrits.Items.Clear();
                return;
            }
            bool a = false;
            Course c = (Course)cb_lesCourses.Items[cb_lesCourses.SelectedIndex];
            this.l_tarif.Text = c.PrixEntree.ToString() + " $";
            lb_lapinsInscrits.Items.Clear();
            if (!c.Depart)
            {
                tb_gagnant.Text = " ";
                tb_gagnant.Text = c.LeGagnant.ToString();
            }
           
                foreach (Lapins l in c.Participer())
                {
                    lb_lapinsInscrits.Items.Add(l);
                    if (this.leLap is null)
                    {
                        btn_inscription.Visible = false;
                        btn_desinscrire.Visible = false;
                    }
                    else if (l.GetId() == this.leLap.GetId())
                    {
                            btn_inscription.Visible = false;
                            btn_desinscrire.Visible = true;
                            a = true;
                    }
                }
                if (!a && this.leLap != null)
                {
                    btn_inscription.Visible = true;
                    btn_desinscrire.Visible = false;
                }    
        }
        private void Btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_lancer_Click(object sender, EventArgs e)
        {
            // On vérifie si une Course a été choisi dans la ComboBox.
            if (cb_lesCourses.SelectedIndex == -1)
            {
                return;
            }
            Course uneCourse = (Course)cb_lesCourses.Items[cb_lesCourses.SelectedIndex];
            //On considère qu'une course peut être démarrer s'il y'a au minimum 2 participants.
            if (uneCourse.Count() >= 2)
            {
                //On vérifie s'il la course a déjà été lancé.
                if (uneCourse.Depart)
                {
                    uneCourse.Départ();
                    uneCourse.Gagnant();
                    tb_gagnant.Text = uneCourse.LeGagnant.ToString();
                }
                else
                {
                    MessageBox.Show("La Course a déjà été lancé et le vainqueur était " + uneCourse.LeGagnant.ToString());
                }
            }
            else
            {
                MessageBox.Show("Il doit y avoir au moins 2 participants pour lancer la course");
            }
            
        }
        private void Btn_inscription_Click(object sender, EventArgs e)
        {
            if (cb_lesCourses.SelectedIndex == -1)
            {
                return;
            }
            Course c = (Course)cb_lesCourses.Items[cb_lesCourses.SelectedIndex];
            if (c.Depart)
            {
                c.Add(this.leLap);
                lb_lapinsInscrits.Items.Add(this.leLap);
                this.lesNouveauxParticipants.Add(new Participer(c.GetId(), leLap.GetId(), 0, state.added));
                btn_inscription.Visible = false;
                btn_desinscrire.Visible = true;
            }
            
        }
        private void load(List<Course> lesCourses, List<Participer> lesP)
        {
            cb_lesCourses.Items.Clear();
            foreach (Course c in lesCourses)
            {
                this.lc.Add(c);
                cb_lesCourses.Items.Add(c);
                List<Lapins> lesLapinsDeLaCourse = new DaoLapin().GetAll(c.GetId());
                foreach (Lapins l in lesLapinsDeLaCourse)
                {
                    //On vérifie si la course a déjà été gagné par un lapin
                    //SI NON, cela signifie que la course n'a jamais été lancé
                    if (l.GagnantDuneCourse == 1)
                    {
                        c.LeGagnant = l;
                        c.Depart = false;
                    }
                    c.Add(l);
                }
                this.lesP = lesP;
            }
        }
    }
}
