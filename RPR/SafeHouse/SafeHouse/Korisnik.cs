using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class Korisnik : Osoba
    {
        private DateTime DatumOtpusta;
        private DateTime DatumPrijema;
        private Lokacija LokKorisnika;
        private List<zahtjevZaIzmjenu> zahtjeviZaIzmjenu;
        private List<zahtjevZaMedPomoc> zahtjeviMedPomoc;
        private List<Termin> termini;
        private Karton karton;

        //konstruktor
        public Korisnik(String i, String p, DateTime dp, string user, string pass,  Lokacija lok, DateTime dr)
            : base(i, p, dr, user, pass)
        {
            DatumPrijema = dp;
            LokKorisnika = lok;
            karton = new Karton();
            zahtjeviMedPomoc = new List<zahtjevZaMedPomoc>();
            zahtjeviZaIzmjenu = new List<zahtjevZaIzmjenu>();
        }
        
        
        //get-set
        public DateTime DatumOtpusta1
        {
            get { return DatumOtpusta; }
            set { DatumOtpusta = value; }
        }
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
        public void OtpustiKorisnika(DateTime d_o)
        {
            DatumOtpusta = d_o;
        }


    }
}