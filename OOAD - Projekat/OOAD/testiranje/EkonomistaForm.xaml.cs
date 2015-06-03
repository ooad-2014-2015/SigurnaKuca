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

        private void button_azurirajPrijedlogeEkonomist_Click(object sender, RoutedEventArgs e)
        {
            


            string prijedlog = new TextRange(richTextBox_prijedlogRjesenjaEkonomist.Document.ContentStart, richTextBox_prijedlogRjesenjaEkonomist.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_ListaKorisnikaEkonomist.SelectedItem.ToString());

            RadniciKontroler.dodajPrijedlogRjesenja(pomocna, prijedlog);
            richTextBox_prijedlogRjesenjaEkonomist.Document.Blocks.Clear(); // brise sadrzaj ??
            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Clear();
            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));
        }

        private void linkLabel1_LinkClicked(object sender, RoutedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            

            label_imeEkonomiste.Content = GlobalneVarijable.trenutnaOsoba.Ime_osobe;
            label_prezimeEkonomiste.Content = GlobalneVarijable.trenutnaOsoba.Prezime_osobe; 
            //nadje sve pacijente
            var pacijenti = RadniciKontroler.dajPacijente(GlobalneVarijable.trenutnaOsoba.ID1);
            
            
            foreach (var k in pacijenti)
            {                
                listBox_ListaKorisnikaEkonomist.Items.Add(k);
            }
        }

        private void listBox_ListaKorisnikaEkonomist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            int pomocna = Convert.ToInt32(listBox_ListaKorisnikaEkonomist.SelectedItem.ToString());


            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Clear();
            richTextBox_historijaRješenjaEkonomist.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));

            richTextBox_licneBiljeskeEkonomist.Document.Blocks.Clear();
            richTextBox_licneBiljeskeEkonomist.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajLicniUtisak(pomocna))));
        }

        private void richTextBox_licneBiljeskeEkonomist_LostFocus(object sender, RoutedEventArgs e)
        {
            
            string licniUtisak = new TextRange(richTextBox_licneBiljeskeEkonomist.Document.ContentStart, richTextBox_licneBiljeskeEkonomist.Document.ContentEnd).Text;
            int pomocna = Convert.ToInt32(listBox_ListaKorisnikaEkonomist.SelectedItem.ToString());
            RadniciKontroler.AzurirajLicniUtisak(pomocna, licniUtisak);
            
        }

        private void button_pregledRasporedaEkonomist_Click(object sender, RoutedEventArgs e)
        {
            RasporedProzor rp = new RasporedProzor(GlobalneVarijable.trenutnaOsoba);
            rp.ShowDialog();
        }


    }
}
