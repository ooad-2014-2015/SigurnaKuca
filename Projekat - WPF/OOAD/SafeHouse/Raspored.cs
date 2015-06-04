using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
     public class Raspored
     {
        private List<Termin> termini;


        //konstruktor
        public Raspored()
        {
            termini = new List<Termin>();
        }
        
        
        //get-set
        public List<Termin> Termini
        {
            get { return termini; }
            set { termini = value; }
        }
        
        //metode
        public void dodajNoviTermin(Termin t)
        {
            termini.Add(t);
        }

        public void IzmijeniRaspored(Termin stariTermin, Termin noviTermin)
        {

        }

    }
}
