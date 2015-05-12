using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
   
    public class Ekonomista : Osoba
    {
        private List<zahtjevZaEkonomskuPomoc> zahtjeviZaEkPomoc;
        //get-set
        public List<zahtjevZaEkonomskuPomoc> ZahtjeviZaEkPomoc
        {
            get { return zahtjeviZaEkPomoc; }
            set { zahtjeviZaEkPomoc = value; }
        }
        //konstruktor
        public Ekonomista(String i, String p, DateTime dr, string u, string pw)
            : base(i, p, dr, u, pw)
        {
            zahtjeviZaEkPomoc = new List<zahtjevZaEkonomskuPomoc>();
        }
        //metode
        public void dodajZahtjevEkPomoc(zahtjevZaEkonomskuPomoc zzek)
        {
            zahtjeviZaEkPomoc.Add(zzek);
        }
    }
}
