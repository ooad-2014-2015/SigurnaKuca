using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class djelimicnoAnonimanKorisnik : Korisnik
    {
        //konstruktor
        public djelimicnoAnonimanKorisnik(String i, String p, DateTime dp, string us, string pass,  Lokacija lok, DateTime dr)
            : base(i, p, dp, us, pass, lok, dr)
        {

        }
    }
}
