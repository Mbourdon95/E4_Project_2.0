using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METIER
{
    public class lesLapins
    {
        private List<Lapins> lesLaps;
        private int lastID;

        public lesLapins()
        {
            this.lesLaps = new List<Lapins>();
            this.lastID = 1;
        }

        public int LastID { get => lastID; set => lastID = value; }

        public void Add(Lapins unLapin)
        {
            lesLaps.Add(unLapin);
            this.lastID = unLapin.GetId()+1;
        }
    }
}
