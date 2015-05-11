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

namespace SafeHouse
{
    public partial class KorisnikForm : Form
    {
        public KorisnikForm()
        {
            InitializeComponent();
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

        

        
    }
}
