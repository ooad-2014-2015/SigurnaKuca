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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SafeHouse;

namespace SafeHouse
{
    public partial class PsihologForm : Window
    {
        public PsihologForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, RoutedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }


        private void button_azurirajPodatkePsiholog_Click(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string nalazi = new TextRange(richTextBox_novaDijagnozaPsiholog.Document.ContentStart, richTextBox_novaDijagnozaPsiholog.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPsiholog.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.Dijagnoza = nalazi;
            korisnikStatus.Historija += (nalazi + "\n");

            db.SaveChanges();

            richTextBox_novaDijagnozaPsiholog.Document.Blocks.Clear();
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Clear();
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.Historija)));

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var psih = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniPsiholog select d).Single();

            label_imePsiholog.Content = psih.Ime;
            label_prezimePsiholog.Content = psih.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_Ps == psih.ID select kar.ID).ToArray();

            // dodavanje u listBox
            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaPacijenataPsiholog.Items.Add(koris.ID);
            }
        }

        private void richTextBox_licneBiljeskePsiholog_LostFocus(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string licniUtisak = new TextRange(richTextBox_licneBiljeskePsiholog.Document.ContentStart, richTextBox_licneBiljeskePsiholog.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPsiholog.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.LicniUtisak = licniUtisak;
            db.SaveChanges();
        }

        private void listBox_listaPacijenataPsiholog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPsiholog.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
            var korisnikStatusDoktor = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox_napredakTerapijePsiholog.Document.Blocks.Clear();
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.Historija)));
            richTextBox_licneBiljeskePsiholog.Document.Blocks.Clear();
            richTextBox_licneBiljeskePsiholog.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.LicniUtisak)));
            richTextBox_nalaziSistematskogPsiholog.Document.Blocks.Clear();
            richTextBox_nalaziSistematskogPsiholog.Document.Blocks.Add(new Paragraph(new Run(korisnikStatusDoktor.Nalazi)));
        }


    }
}
