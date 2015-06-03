using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class zahtjevZaEkonomskuPomoc : zahtjevZaPomoc
    {
        //konstruktor
        public zahtjevZaEkonomskuPomoc(int i, String oz, bool dodat)
            : base(i, oz, dodat)
        {

        }
    }
}
