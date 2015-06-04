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
            

            string nalazi = new TextRange(richTextBox_prijedlogRjesenja.Document.ContentStart, richTextBox_prijedlogRjesenja.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());
            RadniciKontroler.dodajPrijedlogRjesenja(pomocna, nalazi);
            

            richTextBox_prijedlogRjesenja.Document.Blocks.Clear();
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Clear();
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            label_imePravnik.Content = GlobalneVarijable.trenutnaOsoba.Ime_osobe;
            label_prezimePravnik.Content = GlobalneVarijable.trenutnaOsoba.Prezime_osobe;
            var pacijenti = RadniciKontroler.dajPacijente(GlobalneVarijable.trenutnaOsoba.ID1);

            // dodavanje u listBox
            foreach (var k in pacijenti)
            {                
                listBox_listaPacijenataPravnik.Items.Add(k);
            }
        }

        private void richTextBox_licneBiljeskePravnik_LostFocus(object sender, RoutedEventArgs e)
        {
            string licniUtisak = new TextRange(richTextBox_licneBiljeskePravnik.Document.ContentStart, richTextBox_licneBiljeskePravnik.Document.ContentEnd).Text;
            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());
            RadniciKontroler.AzurirajLicniUtisak(pomocna, licniUtisak);
        }

        private void listBox_listaPacijenataPravnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());
            

            richTextBox_opisProblemaPravnik.Document.Blocks.Clear();
            richTextBox_opisProblemaPravnik.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajOpisProblema(pomocna))));
            richTextBox_licneBiljeskePravnik.Document.Blocks.Clear();
            richTextBox_licneBiljeskePravnik.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajLicniUtisak(pomocna))));
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Clear();
            richTextBox_historijaRjesenjaPravnik.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));
        }

        private void richTextBox_opisProblemaPravnik_LostFocus(object sender, RoutedEventArgs e)
        {
            //ovo uopste ne znam za sta sluzi..
           /* mydbEntities db = new mydbEntities();

            string opisProblema = new TextRange(richTextBox_opisProblemaPravnik.Document.ContentStart, richTextBox_opisProblemaPravnik.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.OpisProblema = opisProblema;
            db.SaveChanges();*/
        }

        private void button_pregledRasporedaPravnik_Click(object sender, RoutedEventArgs e)
        {
            RasporedProzor rp = new RasporedProzor(GlobalneVarijable.trenutnaOsoba);
            rp.ShowDialog();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
