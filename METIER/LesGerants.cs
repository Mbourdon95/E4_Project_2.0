using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER
{
    public class LesGerants
    {
        private List<Gerant> lesG;
        private int lastID;

        public LesGerants()
        {
            this.lesG = new List<Gerant>();
            this.lastID = 1;
        }

        public int LastID { get => lastID; set => lastID = value; }

        public void Add(Gerant unGerant)
        {
            lesG.Add(unGerant);
            this.lastID = unGerant.Id + 1;
        }
    }
}
