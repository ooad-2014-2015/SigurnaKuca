using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public abstract class Osoba
    {
        string ime_osobe;
        string prezime_osobe;
        DateTime datumRodjenja;
        string username;
        string password;

        public Osoba() { }

        public Osoba( string ime, string prezime, DateTime datumRodj, string user, string pass)
        {
            this.ime_osobe=ime;
            this.prezime_osobe=prezime;
            this.datumRodjenja=datumRodj;
            this.username = user;
            this.password = pass;
        }

        public string Ime_osobe
        {
            get { return ime_osobe; }
            set { ime_osobe = value; }
        }
        
        public string Prezime_osobe
        {
            get { return prezime_osobe; }
            set { prezime_osobe = value; }
        }
       
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }



    }
}
