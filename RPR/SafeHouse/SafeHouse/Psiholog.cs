using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
   
    public class Psiholog : Osoba
    {
        private List<Korisnik> pacijenti;

        //konstruktor
        public Psiholog(String i, String p, DateTime dr, string u, string pw)
            : base(i, p, dr, u , pw)
        {
            pacijenti = new List<Korisnik>();
        }
        
        //get-set
        public List<Korisnik> Pacijenti
        {
            get { return pacijenti; }
            set { pacijenti = value; }
        }
      
        //metode
        public void dodajPacijenta(Korisnik k)
        {
            pacijenti.Add(k);
        }
    }
}
