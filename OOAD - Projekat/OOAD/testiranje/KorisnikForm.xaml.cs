using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        
        public KorisnikForm()
        {
            InitializeComponent();
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

      

        private void radioButton_pravnaRjesenjaKorisnik_CheckedChanged(object sender, RoutedEventArgs e)
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

        private void radioButton_ekonomskaRjesenjaKorisnik_CheckedChanged(object sender, RoutedEventArgs e)
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
        /*
        private void tabControl1_Selected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak korisnika
            var korisnik = (from k in db.korisnici where k.Username == GlobalneVarijable.TrenutniKorisnik select k).Single();
            if (korisnik.Anonimnost == true) groupBox_zahtjeviZaAnonimnogKorisnika.Visible = true;
        }*/

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




    }
}
