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
            mydbEntities db = new mydbEntities();

            string nalazi = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenata.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.Nalazi = nalazi;
            korisnikStatus.Historija += (System.DateTime.Now + "\n" + nalazi + "\n");
            korisnikStatus.DatumPromjene = DateTime.Now;

            db.SaveChanges();
            richTextBox1.Document.Blocks.Clear();  // brisanje sadržaja richTextBoxa ??
            richTextBox3.Document.Blocks.Clear();
            richTextBox3.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.Historija)));
            label_ispisDatumaSistematskog.Content = korisnikStatus.DatumPromjene.ToString();
        }

        

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var doktor = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniDoktor select d).Single();

            label3.Content = doktor.Ime;
            label4.Content = doktor.Prezime;

            var karton = (from kar in db.kartoni where kar.ID_D == doktor.ID select kar.ID).ToArray();


            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaPacijenata.Items.Add(koris.ID);
            }
        }

        private void richTextBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string licniUtisak = new TextRange(richTextBox2.Document.ContentStart, richTextBox2.Document.ContentEnd).Text;

            int pomocna = Convert.ToInt32(listBox_listaPacijenata.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.LicniUtisak = licniUtisak;
            korisnikStatus.DatumPromjene = DateTime.Today.Date;
            db.SaveChanges();
        }

        private void listBox_listaPacijenata_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mydbEntities db = new mydbEntities();

            int pomocna = Convert.ToInt32(listBox_listaPacijenata.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();

            var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox1.Document.Blocks.Clear();

            // valjda radi ovakav upis u textbox ??
            richTextBox3.Document.Blocks.Clear();
            richTextBox3.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.Historija)));
            richTextBox2.Document.Blocks.Clear();
            richTextBox2.Document.Blocks.Add(new Paragraph(new Run(korisnikStatus.LicniUtisak)));

            label_ispisDatumaSistematskog.Content = korisnikStatus.DatumPromjene.ToString();
        }



    }
}
