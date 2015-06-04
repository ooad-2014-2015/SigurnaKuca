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
using System.Windows.Navigation;

namespace SafeHouse
{
    public partial class KorisnikForm : Window
    {
        Thread t;
        string priv = "";
        public KorisnikForm()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(this.provjeraBazeSeen));
            t.Start();
            while (!t.IsAlive) ;

            webBrowser1.Navigate("http://www.google.com");

        }

        ~KorisnikForm()
        {
            t.Abort();
        }

        
         
        private void webBrowser1_DocumentCompleted(object sender, NavigationEventArgs e)
        {
            this.Content ="Loaded.";
        }

        private void webBrowser1_Navigating(object sender, NavigationEventArgs e)
        {
            this.Content = "Loading..";
        }

       

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                
                if (KorisniciKontroler.jeLiAnoniman(GlobalneVarijable.TrenutniKorisnik) == true) groupBox_zahtjeviZaAnonimnogKorisnika.Visibility= Visibility.Visible;
            }
        }

      
        private void button_web_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                Uri n = new Uri("http://"+priv); //.Trim(), UriKind.RelativeOrAbsolute
                webBrowser1.Refresh();
                this.webBrowser1.Navigate(n);
                this.webBrowser1.Source=n;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.webBrowser1.Navigate("http://www.google.com/");

            //webBrowser1.Source = new Uri("http://www.google.com"); 

            
            if (KorisniciKontroler.jeLiAnoniman(GlobalneVarijable.TrenutniKorisnik) == true) groupBox1.Visibility = Visibility.Visible;
            label1.Content = GlobalneVarijable.trenutnaOsoba.Ime_osobe;
            label2.Content = GlobalneVarijable.trenutnaOsoba.Prezime_osobe;
            label3.Content = GlobalneVarijable.trenutnaOsoba.ToString();

           

            richTextBox1.Document.Blocks.Clear();
            richTextBox1.Document.Blocks.Add(new Paragraph(new Run(KorisniciKontroler.dajHistoriju(0))));//doktor
            richTextBox2.Document.Blocks.Clear();
            richTextBox2.Document.Blocks.Add(new Paragraph(new Run(KorisniciKontroler.dajHistoriju(1))));//psiholog
        }

        private void radioButton_pravnaRjesenjaKorisnik_Checked(object sender, RoutedEventArgs e)
        {
            
            if (radioButton_pravnaRjesenjaKorisnik.IsChecked == true)
            {
               
                richTextBox3.Document.Blocks.Clear();
                richTextBox3.Document.Blocks.Add(new Paragraph(new Run(KorisniciKontroler.dajHistoriju(3))));
            }
        }

        private void radioButton_ekonomskaRjesenjaKorisnik_Checked(object sender, RoutedEventArgs e)
        {
           
            if (radioButton_pravnaRjesenjaKorisnik.IsChecked == true)
            {
               

                richTextBox3.Document.Blocks.Clear();
                richTextBox3.Document.Blocks.Add(new Paragraph(new Run(KorisniciKontroler.dajHistoriju(2))));
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // zahtjev za med pomoc = 1;
            // zahtjev za psih pomoc = 2;
            // zahtjev za ek pomoc = 3;
            // zahtjev za prav pomoc = 4;
            // dodatni zahtjev = 1; 
            // zahtjev za izmjenu rasporeda =5;
           


           // int standard = Convert.ToInt32(checkBox_standardniTermini.IsChecked);
            int dodatni = Convert.ToInt32(checkBox_dodatniTermini.IsChecked);

            int med = Convert.ToInt32(checkBox3.IsChecked);
            int psih = Convert.ToInt32(checkBox4.IsChecked);
            int ek = Convert.ToInt32(checkBox2.IsChecked);
            int prav = Convert.ToInt32(checkBox1.IsChecked);

          
            KorisniciKontroler.dodajZahtjev(med, psih, ek, prav,  dodatni);
            


        }
        List<zahtjevi> zahtjevi1;
        public void provjeraBazeSeen()
        {
            while (true)
            {
                

                try
                {
                    zahtjevi1 = KorisniciKontroler.NemaSeen();
                    tabPage2.Dispatcher.Invoke(new Action(delegate() { tabPage2.Header = "Zahtjevi" + ("(" + zahtjevi1.Count + ")"); }));
                 
                }
                catch (ArgumentException )
                { }
                catch (EntityException )
                { }
                catch (TaskCanceledException )
                { }
                
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


                string opis = KorisniciKontroler.dajOpisZahtjeva(z.ID);
                string akcija;
                if (KorisniciKontroler.jeLiObradjen(z.ID) == true) akcija = " je odobren! \n";
                else akcija = " je odbijen! \n";
                ricTekst += ("Vaš " + opis + akcija);

                KorisniciKontroler.postaviSeen(z.ID);
            }
            Korisnik_Obavijesti.Document.Blocks.Add(new Paragraph(new Run(ricTekst)));
            db.SaveChanges();
        }

        private void buttonRaspored_Click(object sender, RoutedEventArgs e)
        {
            RasporedProzor rp = new RasporedProzor(GlobalneVarijable.trenutnaOsoba);
            rp.ShowDialog();
        }

        private void buttonKamera_Click(object sender, RoutedEventArgs e)
        {
            WebKamera rp = new WebKamera();
            rp.ShowDialog();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

  
    }
}
