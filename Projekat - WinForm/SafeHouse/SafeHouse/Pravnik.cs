using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    
    public class Pravnik : Osoba
    {
        private List<potpunoAnonimanKorisnik> korisnici;

        //konstruktor
        public Pravnik(String i, String p, DateTime dr, string u, string pw)
            : base(i, p, dr, u, pw)
        {
            korisnici = new List<potpunoAnonimanKorisnik>();
        }

        //get-set
        public List<potpunoAnonimanKorisnik> Korisnici
        {
            get { return korisnici; }
            set { korisnici = value; }
        }

      
        //metode
        public void dodajKorisnika(potpunoAnonimanKorisnik pak)
        {
            korisnici.Add(pak);
        }
    }
}
