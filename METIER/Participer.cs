using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER
{
    public class Participer
    {
        private int idCourse;
        private int idLapin;
        private int gagnant;
        private state State;

        public Participer(int idCourse, int idLapin, int gagnant, state _state)
        {
            this.idCourse = idCourse;
            this.idLapin = idLapin;
            this.gagnant = gagnant;
            this.State = _state;
        }

        public int Gagnant { get => gagnant; set => gagnant = value; }
        public int IdLapin { get => idLapin; set => idLapin = value; }
        public int IdCourse { get => idCourse; set => idCourse = value; }
        public state State1 { get => State; set => State = value; }
        public void Remove()
        {
            this.State = state.deleted;
        }
    }
}
