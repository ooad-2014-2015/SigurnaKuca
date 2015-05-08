using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class potpunoAnonimanKorisnik : Korisnik
    {
        private List<zahtjevZaEkonomskuPomoc> zahtjeviZaEkPomoc;
        private List<zahtjevZaPravnuPomoc> zahtjeviZaPrPomoc;
        //get-set
        public List<zahtjevZaEkonomskuPomoc> ZahtjeviZaEkPomoc
        {
            get { return zahtjeviZaEkPomoc; }
            set { zahtjeviZaEkPomoc = value; }
        }
        public List<zahtjevZaPravnuPomoc> ZahtjeviZaPrPomoc
        {
            get { return zahtjeviZaPrPomoc; }
            set { zahtjeviZaPrPomoc = value; }
        }
        //konstruktor
        public potpunoAnonimanKorisnik(String i, String p, DateTime dp, string us, string pass, Lokacija lok, DateTime dr)
            : base(i, p, dp, us, pass, lok, dr)
        {
            zahtjeviZaEkPomoc = new List<zahtjevZaEkonomskuPomoc>();
            zahtjeviZaPrPomoc = new List<zahtjevZaPravnuPomoc>();
        }
        //metode
        public void dodajZahtjevEkPomoc(zahtjevZaEkonomskuPomoc zzep)
        {
            ZahtjeviZaEkPomoc.Add(zzep);
        }
        public void dodajZahtjevPrPomoc(zahtjevZaPravnuPomoc zzpp)
        {
            ZahtjeviZaPrPomoc.Add(zzpp);
        }
    }
}
