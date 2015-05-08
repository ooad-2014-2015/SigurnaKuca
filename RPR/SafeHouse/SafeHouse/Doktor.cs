using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
  
    public class Doktor : Osoba
    {
        private List<Korisnik> pacijenti;
        private List<pregledKodDoktora> preglediDoktor;
        private List<zahtjevZaMedPomoc> zahtjeviZaMedPomoc;

        //konstruktor
        public Doktor(String i, String p, DateTime dr, string u, string pw)
            : base(i, p, dr, u, pw)
        {
            pacijenti = new List<Korisnik>();
            preglediDoktor = new List<pregledKodDoktora>();
            zahtjeviZaMedPomoc = new List<zahtjevZaMedPomoc>();
        }


        //get-set
        public List<Korisnik> Pacijenti
        {
            get { return pacijenti; }
            set { pacijenti = value; }
        }
        public List<zahtjevZaMedPomoc> ZahtjeviZaMedPomoc
        {
            get { return zahtjeviZaMedPomoc; }
            set { zahtjeviZaMedPomoc = value; }
        }
        public List<pregledKodDoktora> PreglediDoktor
        {
            get { return preglediDoktor; }
            set { preglediDoktor = value; }
        }



        //metode
        public void dodajPacijenta(Korisnik p)
        {
            pacijenti.Add(p);
        }
        public void dodajPregled(pregledKodDoktora pkd)
        {
            PreglediDoktor.Add(pkd);
        }
        public void dodajzahtjevZaMedPomoc(zahtjevZaMedPomoc zzmp)
        {
            zahtjeviZaMedPomoc.Add(zzmp);
        }
    }
}
