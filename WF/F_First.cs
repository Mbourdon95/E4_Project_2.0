using System;
using System.Windows.Forms;
using DAO;

namespace WF
{
    public partial class F_First : Form
    {
        public F_First()
        {
            InitializeComponent();
            this.btn_gCourse.Click += Btn_gCourse_Click;
            this.btn_gLapins.Click += Btn_gLapins_Click;
            DaoConnectionSingleton.SetStringConnection("root", "siojjr", "localhost", "dbutdl");
        }

        private void Btn_gLapins_Click(object sender, EventArgs e)
        {
            F_lesGerant fLesGerants = new F_lesGerant();
            fLesGerants.Show();
        }

        private void Btn_gCourse_Click(object sender, EventArgs e)
        {
            F_lesCourses fLesCourses = new F_lesCourses();
            fLesCourses.Show();
        }
    }
}
