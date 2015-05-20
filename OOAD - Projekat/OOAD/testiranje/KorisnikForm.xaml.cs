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
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 1, OpisZahtjeva = "Zahtjev za medicinsku pomoć" });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 1, OpisZahtjeva = "Zahtjev za dodatnu medicinsku pomoć" });
            }
            if (psih == 1)
            {
                if (standard == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 2, OpisZahtjeva = "Zahtjev za psihološku pomoć" });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 2, OpisZahtjeva = "Zahtjev za dodatnu psihološku pomoć" });
            }
            if (ek == 1)
            {
                if (standard == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 3, OpisZahtjeva = "Zahtjev za ekonomsku pomoć" });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 3, OpisZahtjeva = "Zahtjev za dodatnu ekonomsku pomoć" });
            }
            if (prav == 1)
            {
                if (standard == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = false, SifraZahtjeva = 4, OpisZahtjeva = "Zahtjev za pravnu pomoć" });
                if (dodatni == 1)
                    db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, DodatniZahtjev = true, SifraZahtjeva = 4, OpisZahtjeva = "Zahtjev za dodatnu pravnu pomoć" });
            }
            db.SaveChanges();
        }
        List<zahtjevi> zahtjevi1;
        public void provjeraBazeSeen()
        {
            while (true)
            {
                mydbEntities db = new mydbEntities();

                var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
                try
                {
                    zahtjevi1 = (from z in db.zahtjevi where (z.Seen == false && z.Korisnici_ID == korisnik.ID && z.Obradjen != null) select z).ToList();
                    tabPage2.Dispatcher.Invoke(new Action(delegate() { tabPage2.Header = "Zahtjevi" + ("(" + zahtjevi1.Count + ")"); }));
                 
                }
                catch (ArgumentException )
                {

                }
                catch (EntityException )
                {
                
                }
                
            }
        }

        private void tabPage2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Korisnik_Obavijesti.Document.Blocks.Clear();
            mydbEntities db = new mydbEntities();
            if (zahtjevi1.Count == 0) 
            {
                Korisnik_Obavijesti.Document.Blocks.Clear();
                Korisnik_Obavijesti.Document.Blocks.Add(new Paragraph(new Run("Nemate zahtjeva na čekanju")));

            }
            string ricTekst="";
            foreach (var z in zahtjevi1)
            {
                var zah = (from za in db.zahtjevi where za.ID == z.ID select za).Single();
                string opis = zah.OpisZahtjeva;
                string akcija;
                if (zah.Obradjen == true) akcija = " je odobren! \n";
                else akcija = " je odbijen! \n";
                ricTekst += ("Vaš " + opis + akcija); 
                
                zah.Seen = true;
            }
            Korisnik_Obavijesti.Document.Blocks.Add(new Paragraph(new Run(ricTekst)));
            db.SaveChanges();
        }
        
    }
}
