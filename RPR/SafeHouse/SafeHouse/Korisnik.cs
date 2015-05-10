using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class Korisnik : Osoba
    {
        private DateTime DatumPrijema;
        private Lokacija LokKorisnika;
        private List<zahtjevZaIzmjenu> zahtjeviZaIzmjenu;
        private List<zahtjevZaMedPomoc> zahtjeviMedPomoc;

        private List<Termin> termini;
        private Karton karton;


        public Korisnik() { }
        //konstruktor
        public Korisnik(String i, String p, DateTime dat_rodj, string user, string pass,  Lokacija lok, DateTime dat_prijema)
            : base(i, p, dat_rodj, user, pass)
        {
            DatumPrijema = dat_rodj;
            LokKorisnika = lok;
            karton = new Karton();

            zahtjeviMedPomoc = new List<zahtjevZaMedPomoc>();
            zahtjeviZaIzmjenu = new List<zahtjevZaIzmjenu>();
        }
        
        
        //get-set
        
        public DateTime DatumPrijema1
        {
            get { return DatumPrijema; }
            set { DatumPrijema = value; }
        }
        public Lokacija LokKorisnika1
        {
            get { return LokKorisnika; }
            set { LokKorisnika = value; }
        }
        public Karton Karton
        {
            get { return karton; }
            set { karton = value; }
        }
        public List<zahtjevZaIzmjenu> ZahtjeviZaIzmjenu
        {
            get { return zahtjeviZaIzmjenu; }
            set { zahtjeviZaIzmjenu = value; }
        }
        public List<zahtjevZaMedPomoc> ZahtjeviMedPomoc
        {
            get { return zahtjeviMedPomoc; }
            set { zahtjeviMedPomoc = value; }
        }
        public List<Termin> Termini
        {
            get { return termini; }
            set { termini = value; }
        }
        
        //metode
        public void IzmijeniLokaciju(Lokacija novaLokacija)
        {
            LokKorisnika = novaLokacija;
        }
       


    }
}