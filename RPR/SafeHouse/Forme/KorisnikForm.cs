using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeHouse;
using System.Threading;

namespace SafeHouse
{
    public partial class KorisnikForm : Form
    {
        Thread t;
        public KorisnikForm()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(this.provjeraBazeSeen));
            t.Start();
            while (!t.IsAlive) ;
        }

        ~KorisnikForm()
        {
            t.Abort();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = e.Url.ToString() + "loaded";
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "Učitavanje..";
        }

        private void Korisnik_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com/");

            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (korisnik.Anonimnost == true) groupBox1.Visible = true;
            label1.Text = korisnik.Ime;
            label2.Text = korisnik.Prezime;
            label3.Text = korisnik.ID.ToString();

            var korisnikStatusDoktor = (from s in db.status_d where s.ID_K == korisnik.ID select s).Single();
            var korisnikStatusPsiholog = (from p in db.status_ps where p.ID_K == korisnik.ID select p).Single();

            richTextBox1.Text = korisnikStatusDoktor.Historija;
            richTextBox2.Text = korisnikStatusPsiholog.Historija;

        }

        private void linkLabel_logOutKorisnik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

        private void radioButton_pravnaRjesenjaKorisnik_CheckedChanged(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (radioButton_pravnaRjesenjaKorisnik.Checked == true)
            {
                var korisnikStatusPravnik = (from p in db.status_pr where p.ID_K == korisnik.ID select p).Single();
                richTextBox3.Text = korisnikStatusPravnik.HistorijaRjesenja;
            }
        }

        private void radioButton_ekonomskaRjesenjaKorisnik_CheckedChanged(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (radioButton_pravnaRjesenjaKorisnik.Checked == true)
            {
                var korisnikStatusEkonomist = (from p in db.status_e where p.ID_K == korisnik.ID select p).Single();
                richTextBox3.Text = korisnikStatusEkonomist.Historija;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (korisnik.Anonimnost == true) groupBox_zahtjeviZaAnonimnogKorisnika.Visible = true;
        }

        void provjeraBazeSeen()
        {
            while (true)
            {
                mydbEntities db = new mydbEntities();

                var korisnik = (from k in db.korisnici where k.Username== GlobalneVarijable.TrenutniKorisnik select k).Single(); 
                try
                {
                    var zahtjevi = (from z in db.zahtjevi where (z.Seen == false && z.Korisnici_ID==korisnik.ID && z.Obradjen!=null) select z).ToArray();

                    //dodati dalje sta ce se raditi sa tim izlistanim zahtjevima koje je admin odgovorio a korisnik nije vidio.

                }
                catch (ArgumentException e) 
                { 
                
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // zahtjev za med pomoc = 1;
            // zahtjev za psih pomoc = 2;
            // zahtjev za ek pomoc = 3;
            // zahtjev za prav pomoc = 4;
            // dodatni zahtjev = 1;
            mydbEntities db = new mydbEntities();
            
            int standard = Convert.ToInt32(checkBox_standardniTermini.Checked);
            int dodatni = Convert.ToInt32(checkBox_dodatniTermini.Checked);
            
            int med = Convert.ToInt32(checkBox3.Checked);
            int psih = Convert.ToInt32(checkBox4.Checked);
            int ek = Convert.ToInt32(checkBox2.Checked);
            int prav = Convert.ToInt32(checkBox1.Checked);
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();

            if (med == 1)
            {
                if(standard==1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, OpisZahtjeva = 1 });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, OpisZahtjeva = 1 });
            }
            if (psih == 1)
            {
                if (standard == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, OpisZahtjeva = 2 });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, OpisZahtjeva = 2 });
            }
            if (ek == 1)
            {
                if (standard == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, OpisZahtjeva = 3 });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, OpisZahtjeva = 3 });
            }
            if (prav == 1)
            {
                if (standard == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, OpisZahtjeva = 4 });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, OpisZahtjeva = 4 });
            }
            db.SaveChanges();
            
        }

        
    }
}
