using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    class AdminFormaKontroler
    {
        static public void RegistrujRadnika(String ime, String prezime, String username, String password, int OpisPosla, DateTime datumrodj)
        {
            mydbEntities db = new mydbEntities();
            db.radnici.Add(new radnici() { Ime = ime, Prezime = prezime, Username = username, Password = password, Opis = OpisPosla, DatumRodjenja = datumrodj });
            db.SaveChanges();
        }
        static public void RegistrujKorisnika(String ime, String prezime, String username, String password, String adresa, DateTime datumrodj, 
            bool anonimnost, String dodatneosobe, DateTime datumPrijema)
        {
             mydbEntities db = new mydbEntities();
            var lokacija = (from l in db.lokacije where l.Adresa == adresa select l).Single();
            int LID = lokacija.ID;
            db.korisnici.Add(new korisnici() { Ime = ime, Prezime = prezime, Username = username, Password = password, Lokacija_ID = LID,
                DatumRodjenja = datumrodj, Anonimnost = anonimnost, DodatneOsobe = dodatneosobe, DatumPrijema=datumPrijema });
            lokacija.Zauzeta = true;
                db.SaveChanges();
            
        }
        static public void dodajOstaloDA(string dokI, string dokP, string psiI, string psiP, string usernameK)//DA-djelimicno anoniman
        {
            mydbEntities db = new mydbEntities();
            //pretraga korisnika u bazi
            var korisnik = (from kor in db.korisnici where kor.Username == usernameK select kor).Single();
            
            var dok = (from d in db.radnici where (d.Ime == dokI && d.Prezime == dokP) select d).Single();
            var psih = (from p in db.radnici where (p.Ime == psiI && p.Prezime == psiP) select p).Single();
            // kreiranje kartona za korisnika
            db.kartoni.Add(new kartoni() {ID = korisnik.ID, ID_D = dok.ID, ID_Ps = psih.ID });

           // kreiranje statusa
           db.status_d.Add(new status_d() { ID_K = korisnik.ID, ID_R = dok.ID });
           db.status_ps.Add(new status_ps() { ID_K = korisnik.ID, ID_R = psih.ID });
            db.SaveChanges();
           
           // kreiranje terina za raspored
           db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = dok.ID });
           db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = psih.ID });
            //db.Entry(db.rasporedi).Reload();
           db.SaveChanges();
           //automatsko popunjavanje NULL vrijednosti u rasporedu!!!!
           RasporedKontroler rk = new RasporedKontroler();
           rk.popuniRaspored();
           
        }
        static public void dodajOstaloPA(string dokI, string dokP, string psiI, string psiP, string ekI, string ekP, string prI, string prP, string usernameK)//PA-potpuno anoniman
        {
            mydbEntities db = new mydbEntities();
            var dok = (from d in db.radnici where (d.Ime == dokI && d.Prezime == dokP) select d).Single();
            var psih = (from p in db.radnici where (p.Ime == psiI && p.Prezime == psiP) select p).Single();
            var ek = (from eko in db.radnici where (eko.Ime == ekI && eko.Prezime == ekP) select eko).Single();
            var pr = (from pre in db.radnici where (pre.Ime == prI && pre.Prezime == prP) select pre).Single();
            
            //pretraga korisnika u bazi
            var korisnik = (from kor in db.korisnici where kor.Username == usernameK select kor).Single();
            // kreiranje kartona za korisnika
            db.kartoni.Add(new kartoni() { ID=korisnik.ID, ID_D = dok.ID, ID_E = ek.ID, ID_Pr = pr.ID, ID_Ps = psih.ID });

            // kreiranje statusa za korisnika
            db.status_d.Add(new status_d() { ID_K = korisnik.ID, ID_R = dok.ID });
            db.status_ps.Add(new status_ps() { ID_K = korisnik.ID, ID_R = psih.ID });
            db.status_e.Add(new status_e() { ID_K = korisnik.ID, ID_R = ek.ID });
            db.status_pr.Add(new status_pr() { ID_K = korisnik.ID, ID_R = pr.ID });
            db.SaveChanges();
            // kreiranje termina za raspored
            db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = dok.ID });
            db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = psih.ID });
            db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = ek.ID });
            db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = pr.ID });
            //automatsko popunjavanje NULL vrijednosti u rasporedu!!!!
            db.SaveChanges();
            RasporedKontroler rk = new RasporedKontroler();
            rk.popuniRaspored();
            
        }
        static public List<lokacije> DajSlobodneLokacije()
        {
            mydbEntities db = new mydbEntities();
            var lokacije = (from l in db.lokacije where l.Zauzeta == null select l).ToList();
            return lokacije;
        }

        static public List<radnici> DajRadnike(int opis)
        {
            mydbEntities db = new mydbEntities();
            var radnici = (from d in db.radnici where d.Opis == opis select d).ToList();
            return radnici;
        }
        static public void prihvatiZahtjev(object item, zahtjevi z )
        {
            mydbEntities db = new mydbEntities();
            var zah = (from zahtjev in db.zahtjevi where (z.ID == zahtjev.ID) select zahtjev).Single();
            
            zah.Obradjen = true;
            zah.Seen = false;
            db.SaveChanges();
        }
        static public void odbijZahtjev(object item, zahtjevi z)
        {
            mydbEntities db = new mydbEntities();
            var zah = (from zahtjev in db.zahtjevi where (z.ID == zahtjev.ID) select zahtjev).Single();

            zah.Obradjen = false;
            zah.Seen = false;
            db.SaveChanges();
        }
        static public int dajIDKorisnika(string username)
        {
            mydbEntities db = new mydbEntities();
            int id = (from k in db.korisnici where (k.Username == username) select k.ID).Single();
            return id;
        }
        static public int dajIDRadnika(string username)
        {
            mydbEntities db = new mydbEntities();
            int id = (from k in db.radnici where (k.Username == username) select k.ID).Single();
            return id;
        }
        static public int dajIDRadnika(int idZ)
        {
            mydbEntities DB = new mydbEntities();
            zahtjevi z = (from zh in DB.zahtjevi where idZ == zh.ID select zh).Single();
            if (z.SifraZahtjeva == 1) return (from kr in DB.kartoni where kr.ID == z.Korisnici_ID select kr.ID_D).Single();
            else if (z.SifraZahtjeva == 2) return (from kr in DB.kartoni where kr.ID == z.Korisnici_ID select kr.ID_Ps).Single();
            else if (z.SifraZahtjeva == 3) return (from kr in DB.kartoni where kr.ID == z.Korisnici_ID select kr.ID_E.Value).Single();
            else return (from kr in DB.kartoni where kr.ID == z.Korisnici_ID select kr.ID_Pr.Value).Single();
        }
        static public int dajIDKorisnika(int idZ)
        {
            mydbEntities db = new mydbEntities();
            zahtjevi z = (from zh in db.zahtjevi where idZ == zh.ID select zh).Single();
            return (from kr in db.kartoni where kr.ID == z.Korisnici_ID select kr.ID).Single();
        }

    }
}
