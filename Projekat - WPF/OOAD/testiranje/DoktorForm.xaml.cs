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
    public partial class DoktorForm : Window
    {
        
        public DoktorForm()
        {
            InitializeComponent();
        }
         

        private void linkLabel1_LinkClicked(object sender, RoutedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }


     

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           

            string nalazi = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenata.SelectedItem.ToString());

            RadniciKontroler.AzurirajNalaze(pomocna, nalazi);
            richTextBox1.Document.Blocks.Clear();  // brisanje sadržaja richTextBoxa ??
            richTextBox3.Document.Blocks.Clear();
            richTextBox3.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));
            label_ispisDatumaSistematskog.Content = RadniciKontroler.dajDatumPromjene(pomocna);
        }

        

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {           

            label3.Content = GlobalneVarijable.trenutnaOsoba.Ime_osobe;
            label4.Content = GlobalneVarijable.trenutnaOsoba.Prezime_osobe;
            var pacijenti = RadniciKontroler.dajPacijente(GlobalneVarijable.trenutnaOsoba.ID1);
            foreach (var koris in pacijenti)
            {                
                listBox_listaPacijenata.Items.Add(koris);
            }
        }

        private void richTextBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            

            string licniUtisak = new TextRange(richTextBox2.Document.ContentStart, richTextBox2.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenata.SelectedItem.ToString());
            RadniciKontroler.AzurirajLicniUtisak(pomocna, licniUtisak);
            
        }

        private void listBox_listaPacijenata_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int pomocna = Convert.ToInt32(listBox_listaPacijenata.SelectedItem.ToString());
                       

            richTextBox1.Document.Blocks.Clear();

            // valjda radi ovakav upis u textbox ??
            richTextBox3.Document.Blocks.Clear();
            richTextBox3.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajHistoriju(pomocna))));
            richTextBox2.Document.Blocks.Clear();
            richTextBox2.Document.Blocks.Add(new Paragraph(new Run(RadniciKontroler.dajLicniUtisak(pomocna))));

            label_ispisDatumaSistematskog.Content = RadniciKontroler.dajDatumPromjene(pomocna);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RasporedProzor rp = new RasporedProzor(GlobalneVarijable.trenutnaOsoba);
            rp.ShowDialog();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var st = new StartForm();
            st.Show();
            this.Close();
        }
    }
}
