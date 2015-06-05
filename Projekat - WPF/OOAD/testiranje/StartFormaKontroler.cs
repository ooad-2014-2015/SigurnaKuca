using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    class StartFormaKontroler
    {
        public static void PostaviTrenutnuOsobuK(string user)
        {
            mydbEntities db = new mydbEntities();
            var osoba = (from r in db.korisnici where (r.Username == user) select r).Single();
            var lokacija = (from l in db.lokacije where (l.ID == osoba.Lokacija_ID) select l).Single();
            Lokacija lo = new Lokacija(lokacija.Adresa);
            GlobalneVarijable.TrenutniKorisnik = user;
            (GlobalneVarijable.trenutnaOsoba) = new Korisnik(osoba.Ime, osoba.Prezime, osoba.DatumRodjenja, user, osoba.Password, lo, osoba.DatumPrijema, osoba.ID);
                
        }
        public static void PostaviTrenutnuOsobuR(string user)
        {
            

            mydbEntities db = new mydbEntities();
            
            var osoba = (from r in db.radnici where (r.Username == user) select r).Single();
            if (osoba.Opis == 0)
            {
                GlobalneVarijable.TrenutniDoktor = user;
                (GlobalneVarijable.trenutnaOsoba) = new Doktor(osoba.Ime, osoba.Prezime, osoba.DatumRodjenja ?? DateTime.Now, osoba.Username, osoba.Password, osoba.ID);
                
            }
            else if (osoba.Opis == 1)
            {
                GlobalneVarijable.TrenutniPsiholog = user;
                (GlobalneVarijable.trenutnaOsoba) = new Psiholog(osoba.Ime, osoba.Prezime, osoba.DatumRodjenja ?? DateTime.Now, osoba.Username, osoba.Password, osoba.ID);
            }
            else if (osoba.Opis == 2)
            {
                GlobalneVarijable.TrenutniEkonomista = user;
                (GlobalneVarijable.trenutnaOsoba) = new Ekonomista(osoba.Ime, osoba.Prezime, osoba.DatumRodjenja ?? DateTime.Now, osoba.Username, osoba.Password, osoba.ID);
            }
            else
            {
                GlobalneVarijable.TrenutniPravnik = user;
                (GlobalneVarijable.trenutnaOsoba) = new Pravnik(osoba.Ime, osoba.Prezime, osoba.DatumRodjenja ?? DateTime.Now, osoba.Username, osoba.Password, osoba.ID);
            }
        }
        public static string dajPasswordR(string user)
        {
            mydbEntities db = new mydbEntities();
            return (from r in db.radnici where (r.Username == user) select r.Password).Single();
        }

        public static string dajPasswordK(string user)
        {
            mydbEntities db = new mydbEntities();
            return (from r in db.korisnici where r.Username == user select r.Password).Single();
        }
    }
}
