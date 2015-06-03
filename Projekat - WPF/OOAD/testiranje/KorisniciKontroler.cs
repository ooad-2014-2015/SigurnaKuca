using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    class KorisniciKontroler
    {
        public static string dajHistoriju(int opis)//d,p,e,pr
        {
            mydbEntities db = new mydbEntities();

            if (opis==0)
            {
                var korisnikStatus = (from stat in db.status_d where stat.ID_K == GlobalneVarijable.trenutnaOsoba.ID1 select stat).Single();
                return korisnikStatus.Historija;
            }
            else if (opis==2)
            {
                var korisnikStatus = (from stat in db.status_e where stat.ID_K == GlobalneVarijable.trenutnaOsoba.ID1 select stat).Single();
                return korisnikStatus.Historija;
            }
            else if (opis==3)
            {
                var korisnikStatus = (from stat in db.status_pr where stat.ID_K == GlobalneVarijable.trenutnaOsoba.ID1 select stat).Single();
                return korisnikStatus.HistorijaRjesenja;
            }
            else
            {
                var korisnikStatus = (from stat in db.status_ps where stat.ID_K == GlobalneVarijable.trenutnaOsoba.ID1 select stat).Single();
                return korisnikStatus.Historija;
            }
        }
        public static bool jeLiAnoniman(string user)
        {
            mydbEntities db = new mydbEntities();
            bool a = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k.Anonimnost).Single();
            return a;
        }
        public static void dodajZahtjev(int med, int psih, int ek, int prav, int dodatni)
        {
            mydbEntities db = new mydbEntities();
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (med == 1)
            {


                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 1, OpisZahtjeva = "Zahtjev za dodatnu medicinsku pomoć" });
                else db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 1, OpisZahtjeva = "Zahtjev za medicinsku pomoć" });
            }
            if (psih == 1)
            {
                
                    
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 2, OpisZahtjeva = "Zahtjev za dodatnu psihološku pomoć" });
                else
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 2, OpisZahtjeva = "Zahtjev za psihološku pomoć" });
            }
            if (ek == 1)
            {
                
                    
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 3, OpisZahtjeva = "Zahtjev za dodatnu ekonomsku pomoć" });
                else
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 3, OpisZahtjeva = "Zahtjev za ekonomsku pomoć" });

            }
            if (prav == 1)
            {
                
                    
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 4, OpisZahtjeva = "Zahtjev za dodatnu pravnu pomoć" });
                else
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 4, OpisZahtjeva = "Zahtjev za pravnu pomoć" });
            }
            db.SaveChanges();
        }
        public static List<zahtjevi> NemaSeen()
        {
            mydbEntities db = new mydbEntities();
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            return (from z in db.zahtjevi where (z.Seen == false && z.Korisnici_ID == korisnik.ID && z.Obradjen != null) select z).ToList();
        }
        public static string dajOpisZahtjeva(int idz)
        {
            mydbEntities db = new mydbEntities();
            return (from za in db.zahtjevi where za.ID == idz select za.OpisZahtjeva).Single();
        }
        public static bool jeLiObradjen(int idz)
        {
            mydbEntities db = new mydbEntities();
            var obradjen = (from za in db.zahtjevi where za.ID == idz select za.Obradjen).Single();
            return (bool)obradjen;
        }
        public static void postaviSeen(int idz)
        {
            mydbEntities db = new mydbEntities();
            var zah = (from z in db.zahtjevi where z.ID == idz select z).Single();
            zah.Seen = true;
        }
    }
}
