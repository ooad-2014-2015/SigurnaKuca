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


        


        private void button_azurirajPodatkePsiholog_Click(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string nalazi = new TextRange(richTextBox_novaDijagnozaPsiholog.Document.ContentStart, richTextBox_novaDijagnozaPsiholog.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPsiholog.SelectedItem.ToString());
            RadniciKontroler.AzurirajNalaze(pomocna, nalazi);
            

            richTextBox_novaDijagnozaPsiholog.Document.Blocks.Clear();
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Clear();
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            label_imePsiholog.Content = GlobalneVarijable.trenutnaOsoba.Ime_osobe;
            label_prezimePsiholog.Content = GlobalneVarijable.trenutnaOsoba.Prezime_osobe;

            // pronalazak pacijenata za tog doktora
            List<int> pacijenti = RadniciKontroler.dajPacijente(GlobalneVarijable.trenutnaOsoba.ID1);

            // dodavanje u listBox
            foreach (var k in pacijenti)
            {
                
                listBox_listaPacijenataPsiholog.Items.Add(k);
            }
        }

        private void richTextBox_licneBiljeskePsiholog_LostFocus(object sender, RoutedEventArgs e)
        {
            

            string licniUtisak = new TextRange(richTextBox_licneBiljeskePsiholog.Document.ContentStart, richTextBox_licneBiljeskePsiholog.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPsiholog.SelectedItem.ToString());
            RadniciKontroler.AzurirajLicniUtisak(pomocna, licniUtisak);
            
        }

        private void listBox_listaPacijenataPsiholog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int pomocna = Convert.ToInt32(listBox_listaPacijenataPsiholog.SelectedItem.ToString());
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Clear();
            richTextBox_napredakTerapijePsiholog.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));
            richTextBox_licneBiljeskePsiholog.Document.Blocks.Clear();
            richTextBox_licneBiljeskePsiholog.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajLicniUtisak(pomocna))));
            richTextBox_nalaziSistematskogPsiholog.Document.Blocks.Clear();            
            richTextBox_nalaziSistematskogPsiholog.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajNalaze(pomocna))));
        }

        private void button_prikaziRasporedPsiholog_Click(object sender, RoutedEventArgs e)
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
