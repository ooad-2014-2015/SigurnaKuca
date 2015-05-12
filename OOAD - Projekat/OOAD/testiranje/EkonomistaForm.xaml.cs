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
    public partial class EkonomistaForm : Window
    {
        public EkonomistaForm()
        {
            InitializeComponent();
        }

     
        private void listBox_ListaKorisnikaEkonomist_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            int pomocna = Convert.ToInt32(listBox_ListaKorisnikaEkonomist.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Clear();
            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.Historija)));

            richTextBox_licneBiljeskeEkonomist.Document.Blocks.Clear();
            richTextBox_licneBiljeskeEkonomist.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.LicniUtisak)));
        }

        private void button_azurirajPrijedlogeEkonomist_Click(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();


            string prijedlog = new TextRange(richTextBox_prijedlogRjesenjaEkonomist.Document.ContentStart, richTextBox_prijedlogRjesenjaEkonomist.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_ListaKorisnikaEkonomist.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();

            korisnikStatus.PrijedlogRjesenja = prijedlog;
            korisnikStatus.Historija += (prijedlog + "\n");

            db.SaveChanges();
            richTextBox_prijedlogRjesenjaEkonomist.Document.Blocks.Clear(); // brise sadrzaj ??
            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Clear();
            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.Historija)));
        }

        private void linkLabel1_LinkClicked(object sender, RoutedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

        private void richTextBox_licneBiljeskeEkonomist_Validated(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string licniUtisak = new TextRange(richTextBox_licneBiljeskeEkonomist.Document.ContentStart, richTextBox_licneBiljeskeEkonomist.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_ListaKorisnikaEkonomist.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.LicniUtisak = licniUtisak;

            db.SaveChanges();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var ekonom = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniEkonomista select d).Single();


            label_imeEkonomiste.Content = ekonom.Ime;
            label_prezimeEkonomiste.Content = ekonom.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_E == ekonom.ID select kar.ID).ToArray();

            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_ListaKorisnikaEkonomist.Items.Add(koris.ID);
            }
        }


    }
}
