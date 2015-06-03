using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    //┻━┻︵ \(°□°)/ ︵ ┻━┻
    class RadniciKontroler
    {
        public static void AzurirajNalaze(int kID, string nalazi)
        {
            if (GlobalneVarijable.trenutnaOsoba is Doktor)
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == kID select kor).Single();
                var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.Nalazi = nalazi;
                korisnikStatus.Historija += (System.DateTime.Now + "\n" + nalazi + "\n");
                korisnikStatus.DatumPromjene = DateTime.Now;
                db.SaveChanges();
            }
            else
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == kID select kor).Single();
                var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.Dijagnoza = nalazi;
                korisnikStatus.Historija += (System.DateTime.Now + "\n" + nalazi + "\n");
               // korisnikStatus.DatumPromjene = DateTime.Now;
                db.SaveChanges();
            }

            
        }
        public static string dajHistoriju(int kor_id)
        {
            mydbEntities db = new mydbEntities();
            
            if(GlobalneVarijable.trenutnaOsoba is Doktor)
            {
                var korisnikStatus = (from stat in db.status_d where stat.ID_K == kor_id select stat).Single();
                return korisnikStatus.Historija;
            }
            else if (GlobalneVarijable.trenutnaOsoba is Ekonomista)
            {
                var korisnikStatus = (from stat in db.status_e where stat.ID_K == kor_id select stat).Single();
                return korisnikStatus.Historija;
            }
            else if (GlobalneVarijable.trenutnaOsoba is Pravnik)
            {
                var korisnikStatus = (from stat in db.status_pr where stat.ID_K == kor_id select stat).Single();
                return korisnikStatus.HistorijaRjesenja;
            }
            else
            {
                var korisnikStatus = (from stat in db.status_ps where stat.ID_K == kor_id select stat).Single();
                return korisnikStatus.Historija;
            }
        }
        public static string dajDatumPromjene(int kor_id)
        {
            
            mydbEntities db = new mydbEntities();
            var korisnikStatus = (from stat in db.status_d where stat.ID_K == kor_id select stat).Single();
            return korisnikStatus.DatumPromjene.ToString();
        }
        public static List<int> dajPacijente(int rID)
        {
            mydbEntities db = new mydbEntities();
            List<int> kartoni = new List<int>();
            List<int> pacijenti = new List<int>();
            if (GlobalneVarijable.trenutnaOsoba is Doktor)
            {
                kartoni = (from kar in db.kartoni where kar.ID_D == rID select kar.ID).ToList();

            }
            else if (GlobalneVarijable.trenutnaOsoba is Ekonomista)
            {
                kartoni = (from kar in db.kartoni where kar.ID_E== rID select kar.ID).ToList();
            }
            else if (GlobalneVarijable.trenutnaOsoba is Pravnik)
            {
                kartoni = (from kar in db.kartoni where kar.ID_Pr == rID select kar.ID).ToList();
            }
            else if (GlobalneVarijable.trenutnaOsoba is Psiholog)
            {
                kartoni = (from kar in db.kartoni where kar.ID_Ps == rID select kar.ID).ToList();
            }
            foreach (var k in kartoni)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                pacijenti.Add(koris.ID);
            }
            return pacijenti;
        }
        public static void AzurirajLicniUtisak(int idk, string licniU)
        { // i ovo
            

            if (GlobalneVarijable.trenutnaOsoba is Doktor)
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
                var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.LicniUtisak = licniU;
                korisnikStatus.DatumPromjene = DateTime.Today.Date;
                db.SaveChanges();
            }
            else if (GlobalneVarijable.trenutnaOsoba is Ekonomista)
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
                var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.LicniUtisak = licniU;
               // korisnikStatus.DatumPromjene = DateTime.Today.Date;
                db.SaveChanges();
            }
            else if (GlobalneVarijable.trenutnaOsoba is Pravnik)
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
                var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.LicniUtisak = licniU;
             //   korisnikStatus.DatumPromjene = DateTime.Today.Date;
                db.SaveChanges();
            }
            else
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
                var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.LicniUtisak = licniU;
               // korisnikStatus.DatumPromjene = DateTime.Today.Date;
                db.SaveChanges();
            }
            
        }
        public static string dajLicniUtisak(int idk)
        {
            mydbEntities db = new mydbEntities();

            if (GlobalneVarijable.trenutnaOsoba is Doktor)
            {
                var korisnikStatus = (from stat in db.status_d where stat.ID_K == idk select stat).Single();
                return korisnikStatus.LicniUtisak;
            }
            else if (GlobalneVarijable.trenutnaOsoba is Ekonomista)
            {
                var korisnikStatus = (from stat in db.status_e where stat.ID_K == idk select stat).Single();
                return korisnikStatus.LicniUtisak;
            }
            else if (GlobalneVarijable.trenutnaOsoba is Pravnik)
            {
                var korisnikStatus = (from stat in db.status_pr where stat.ID_K == idk select stat).Single();
                return korisnikStatus.LicniUtisak;
            }
            else
            {
                var korisnikStatus = (from stat in db.status_ps where stat.ID_K == idk select stat).Single();
                return korisnikStatus.LicniUtisak;
            }
        }
        public static void dodajPrijedlogRjesenja(int idk, string prijedlog)
        {
            if (GlobalneVarijable.trenutnaOsoba is Ekonomista)
            {
                mydbEntities db = new mydbEntities(); 
                var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
                var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.PrijedlogRjesenja = prijedlog;
                korisnikStatus.Historija += (DateTime.Now + "\n" + prijedlog + "\n");

                db.SaveChanges();
            }
            else
            {
                mydbEntities db = new mydbEntities();
                var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
                var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
                korisnikStatus.PrijedlogRjesenja = prijedlog;
                korisnikStatus.HistorijaRjesenja += (DateTime.Now + "\n" + prijedlog + "\n");
                db.SaveChanges();
            }
        }
        public static string dajOpisProblema(int idk)
        {
            mydbEntities db = new mydbEntities();
            var korisnik = (from kor in db.korisnici where kor.ID == idk select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            return korisnikStatus.OpisProblema;
        }
        public static string dajNalaze(int idk)
        {
            mydbEntities db = new mydbEntities();
            var korisnikStatus = (from stat in db.status_d where stat.ID_K == idk select stat).Single();
            return korisnikStatus.Nalazi;
        }
    
    }
}
