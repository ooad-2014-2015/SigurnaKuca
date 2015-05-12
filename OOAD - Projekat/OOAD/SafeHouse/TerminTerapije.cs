using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
   
    public class terminTerapija : Termin
    {
        private Psiholog psiholog;

        //konstruktor
        public terminTerapija(DateTime div, Korisnik pac)
            : base(div, pac)
        {

        }
        
        //get-set
        public Psiholog Psiholog
        {
            get { return psiholog; }
            set { psiholog = value; }
        }
       
    }
}
