using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class pregledKodDoktora : Termin
    {
        private Doktor doktor;

        //konstruktor
        public pregledKodDoktora(Doktor d, DateTime div, Korisnik pac)
            : base(div, pac)
        {
            doktor = d;
        }
        
        //get-set
        public Doktor Doktor
        {
            get { return doktor; }
            set { doktor = value; }
        }
        

    }
}
