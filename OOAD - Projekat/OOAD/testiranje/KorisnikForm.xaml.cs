using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SafeHouse
{
    public partial class KorisnikForm : Window
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
        /*
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = e.Url.ToString() + "loaded";
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "Učitavanje..";
        } 
        */
        

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                mydbEntities db = new mydbEntities();
                // pronalazak korisnika
                var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
                if (korisnik.Anonimnost == true) groupBox_zahtjeviZaAnonimnogKorisnika.Visibility= Visibility.Visible;
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            // webBrowser1.Navigate("http://www.google.com/");

            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (korisnik.Anonimnost == true) groupBox1.Visibility = Visibility.Visible;
            label1.Content = korisnik.Ime;
            label2.Content = korisnik.Prezime;
            label3.Content = korisnik.ID.ToString();

            var korisnikStatusDoktor = (from s in db.status_d where s.ID_K == korisnik.ID select s).Single();
            var korisnikStatusPsiholog = (from p in db.status_ps where p.ID_K == korisnik.ID select p).Single();

            richTextBox1.Document.Blocks.Clear();
            richTextBox1.Document.Blocks.Add(new Paragraph(new Run(korisnikStatusDoktor.Historija)));
            richTextBox2.Document.Blocks.Clear();
            richTextBox2.Document.Blocks.Add(new Paragraph(new Run(korisnikStatusPsiholog.Historija)));
        }

        private void radioButton_pravnaRjesenjaKorisnik_Checked(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (radioButton_pravnaRjesenjaKorisnik.IsChecked == true)
            {
                var korisnikStatusPravnik = (from p in db.status_pr where p.ID_K == korisnik.ID select p).Single();
                richTextBox3.Document.Blocks.Clear();
                richTextBox3.Document.Blocks.Add(new Paragraph(new Run(korisnikStatusPravnik.HistorijaRjesenja)));
            }
        }

        private void radioButton_ekonomskaRjesenjaKorisnik_Checked(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (radioButton_pravnaRjesenjaKorisnik.IsChecked == true)
            {
                var korisnikStatusEkonomist = (from p in db.status_e where p.ID_K == korisnik.ID select p).Single();

                richTextBox3.Document.Blocks.Clear();
                richTextBox3.Document.Blocks.Add(new Paragraph(new Run(korisnikStatusEkonomist.Historija)));
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // zahtjev za med pomoc = 1;
            // zahtjev za psih pomoc = 2;
            // zahtjev za ek pomoc = 3;
            // zahtjev za prav pomoc = 4;
            // dodatni zahtjev = 1;
            mydbEntities db = new mydbEntities();

            int standard = Convert.ToInt32(checkBox_standardniTermini.IsChecked);
            int dodatni = Convert.ToInt32(checkBox_dodatniTermini.IsChecked);

            int med = Convert.ToInt32(checkBox3.IsChecked);
            int psih = Convert.ToInt32(checkBox4.IsChecked);
            int ek = Convert.ToInt32(checkBox2.IsChecked);
            int prav = Convert.ToInt32(checkBox1.IsChecked);
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();

            if (med == 1)
            {
                if (standard == 1)
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

        void provjeraBazeSeen()
        {
            while (true)
            {
                mydbEntities db = new mydbEntities();

                var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
                try
                {
                    var zahtjevi = (from z in db.zahtjevi where (z.Seen == false && z.Korisnici_ID == korisnik.ID && z.Obradjen != null) select z).ToArray();

                    //dodati dalje sta ce se raditi sa tim izlistanim zahtjevima koje je admin odgovorio a korisnik nije vidio.

                }
                catch (ArgumentException )
                {

                }
                catch (EntityException )
                { }
            }
        }
        
    }
}
