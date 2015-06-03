using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class zahtjevZaIzmjenuLokacije : zahtjevZaIzmjenu
    {
        private Lokacija pocLokacija;
        
        //konstruktor
        public zahtjevZaIzmjenuLokacije(int i, String oz, bool dodat, Lokacija pl)
            : base(i, oz, dodat)
        {
            pocLokacija = pl;
        }
        
        //get-set
        public Lokacija PocLokacija
        {
            get { return pocLokacija; }
            set { pocLokacija = value; }
        }
        

    }
}
