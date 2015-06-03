using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{

    public class TerminSaPravnikom: Termin
    {
        private Pravnik pravnik;

        //konstruktor
        public TerminSaPravnikom(DateTime div, Korisnik pac, Pravnik pr)
            : base(div, pac)
        {
            pravnik = pr;
        }

        //get-set
        public Pravnik Pravnik
        {
            get { return pravnik; }
            set { pravnik = value; }
        }

    }
}
