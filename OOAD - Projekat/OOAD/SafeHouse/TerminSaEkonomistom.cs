using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{

    public class TerminSaEkonomistom : Termin
    {
        private Ekonomista ekonomista;

        //konstruktor
        public TerminSaEkonomistom(DateTime div, Korisnik pac, Ekonomista ek)
            : base(div, pac)
        {
            ekonomista = ek;
        }

        //get-set
        public Ekonomista Ekonomista
        {
            get { return ekonomista; }
            set { ekonomista = value; }
        }

    }
}
