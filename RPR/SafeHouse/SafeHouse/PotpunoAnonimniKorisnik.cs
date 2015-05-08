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

        //konstruktor
        public potpunoAnonimanKorisnik(String i, String p, DateTime dat_rodjenja, string us, string pass, Lokacija lok, DateTime dat_prijema)
            : base(i, p, dat_rodjenja, us, pass, lok, dat_prijema)
        {
            zahtjeviZaEkPomoc = new List<zahtjevZaEkonomskuPomoc>();
            zahtjeviZaPrPomoc = new List<zahtjevZaPravnuPomoc>();
        }


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
