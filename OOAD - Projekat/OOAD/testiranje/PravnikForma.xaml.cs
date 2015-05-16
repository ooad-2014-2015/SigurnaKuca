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
    public partial class PravnikForm : Window
    {
        public PravnikForm()
        {
            InitializeComponent();
        }



        private void button_azurirajRjesenjePravnik_Click(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string nalazi = new TextRange(richTextBox_prijedlogRjesenja.Document.ContentStart, richTextBox_prijedlogRjesenja.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.PrijedlogRjesenja = nalazi;
            korisnikStatus.HistorijaRjesenja += (DateTime.Now + "\n" + nalazi + "\n");

            db.SaveChanges();

            richTextBox_prijedlogRjesenja.Document.Blocks.Clear();
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Clear();
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.HistorijaRjesenja)));
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var prav = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniPravnik select d).Single();

            label_imePravnik.Content = prav.Ime;
            label_prezimePravnik.Content = prav.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_Pr == prav.ID select kar.ID).ToArray();

            // dodavanje u listBox
            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaPacijenataPravnik.Items.Add(koris.ID);
            }
        }

        private void richTextBox_licneBiljeskePravnik_LostFocus(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();


            string licniUtisak = new TextRange(richTextBox_licneBiljeskePravnik.Document.ContentStart, richTextBox_licneBiljeskePravnik.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.LicniUtisak = licniUtisak;
            db.SaveChanges();
        }

        private void listBox_listaPacijenataPravnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox_opisProblemaPravnik.Document.Blocks.Clear();
            richTextBox_opisProblemaPravnik.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.OpisProblema)));
            richTextBox_licneBiljeskePravnik.Document.Blocks.Clear();
            richTextBox_licneBiljeskePravnik.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.LicniUtisak)));
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Clear();
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.HistorijaRjesenja)));
        }

        private void richTextBox_opisProblemaPravnik_LostFocus(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string opisProblema = new TextRange(richTextBox_opisProblemaPravnik.Document.ContentStart, richTextBox_opisProblemaPravnik.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.OpisProblema = opisProblema;
            db.SaveChanges();
        }
    }
}
