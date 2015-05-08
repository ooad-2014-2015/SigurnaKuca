using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class sigurnaKuca
    {
        private List<Psiholog> psiholozi;
        private List<Doktor> doktori;
        private List<Ekonomista> ekonomisti;
        private List<Pravnik> pravnici;
        private List<Korisnik> korisnici;


        //konstruktor
        public sigurnaKuca()
        {
            psiholozi = new List<Psiholog>();
            doktori = new List<Doktor>();
            ekonomisti = new List<Ekonomista>();
            pravnici = new List<Pravnik>();
            korisnici = new List<Korisnik>();
        }


        //get-set
        public List<Psiholog> Psiholozi
        {
            get { return psiholozi; }
            set { psiholozi = value; }
        }
        public List<Doktor> Doktori
        {
            get { return doktori; }
            set { doktori = value; }
        }
        public List<Ekonomista> Ekonomisti
        {
            get { return ekonomisti; }
            set { ekonomisti = value; }
        }
        public List<Korisnik> Korisnici
        {
            get { return korisnici; }
            set { korisnici = value; }
        }
        public List<Pravnik> Pravnici
        {
            get { return pravnici; }
            set { pravnici = value; }
        }



        //metode
        public void dodajPsihologa(Psiholog ps)
        {
            psiholozi.Add(ps);
        }
        public void dodajDoktora(Doktor d)
        {
            doktori.Add(d);
        }
        public void dodajEkonomistu(Ekonomista e)
        {
            ekonomisti.Add(e);
        }
        public void dodajPravnika(Pravnik pr)
        {
            pravnici.Add(pr);
        }
        public void dodajKorisnika(Korisnik k)
        {
            korisnici.Add(k);
        }
    }
}
