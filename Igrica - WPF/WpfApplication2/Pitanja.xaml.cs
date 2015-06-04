using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication2
{
    /// <summary>
    /// Ne radi prebacivanje sa prozora nivoa na mainWindow i ne znamo da li radi upis u bazu najboljih rezultata
    /// </summary>
    public partial class Pitanja : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        DispatcherTimer dt1 = new DispatcherTimer();

        int n;
        const string nivo1 = "00:03:00"; 
        const string nivo2 = "00:02:40";
        const string nivo3 = "00:02:10";
        const string nivo4 = "00:02:00";
        const string nivo5 = "00:01:40";
        const string pauza = "00:00:10";
        string sekunde = "";
        int vrijeme;
        const int br_pitanja = 10;
        int trenutnoPitanje = 0;
        string trenutnoVrijeme = string.Empty;
        string trenutnoVrijeme2 = string.Empty;

        String izvodjac;
        List<TextBox> txtlist;
        List<Line> linije = new List<Line>();
        Stopwatch stoperica1 = new Stopwatch();
        Stopwatch stoperica2 = new Stopwatch();

        public Pitanja(int nivo)
        {
            InitializeComponent();

            n = nivo;

            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            
            dt1.Tick += new EventHandler(dt1_Tick);
            dt1.Interval = new TimeSpan(0, 0, 0, 0, 1);  

            if (nivo == 1) sekunde = nivo1;
            else if (nivo == 2) sekunde = nivo2;
            else if (nivo == 3) sekunde = nivo3;
            else if (nivo == 4) sekunde = nivo4;
            else sekunde = nivo5;

            txtlist= new List<TextBox>();
            txtlist.Add(txt1);
            txtlist.Add(txt2);
            txtlist.Add(txt3);
            txtlist.Add(txt4);
            txtlist.Add(txt5);
            txtlist.Add(txt6);
            txtlist.Add(txt7);
            txtlist.Add(txt8);
            txtlist.Add(txt9);
            txtlist.Add(txt10);
            txtlist.Add(txt11);
            txtlist.Add(txt12);
            txtlist.Add(txt13);
            txtlist.Add(txt14);
            txtlist.Add(txt15);
            txtlist.Add(txt16);
            txtlist.Add(txt17);
            txtlist.Add(txt18);
            txtlist.Add(txt19);
            txtlist.Add(txt20);
            for (int i = 0; i < 20; i++)
            {
                Line myLine = new Line();
                myLine.Stroke = System.Windows.Media.Brushes.Black;
                myLine.X1 = 10+22*i; //na 1 pocinje
                myLine.X2 = (10 + 22 * i) + 17;
                myLine.Y1 = 20;
                myLine.Y2 = 20;
                myLine.HorizontalAlignment = HorizontalAlignment.Left;
                myLine.VerticalAlignment = VerticalAlignment.Center;
                myLine.StrokeThickness = 2;
                myLine.Visibility = Visibility.Hidden;
                gridzaslova1.Children.Add(myLine);
                linije.Add(myLine);
                txtlist[i].Visibility = Visibility.Hidden;
                
            }

            string trenutno = trenutnoPitanje.ToString();
            labelPitanje.Content = trenutnoPitanje + "/" + br_pitanja.ToString();
            izlistajIzvodjaca();

            stoperica1.Start();
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (stoperica1.IsRunning)
            {
                TimeSpan ts = stoperica1.Elapsed;
                trenutnoVrijeme = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds);
                labelaStoperica.Text = trenutnoVrijeme;
                if (trenutnoVrijeme == sekunde)
                {
                    MessageBox.Show("Žao nam je Vaše vrijeme je isteklo.", "Igra je gotova");
                    this.Close();

                }
            }
        }

        // za pauzirano vrijeme
        void dt1_Tick(object sender, EventArgs e)
        {
            if (stoperica2.IsRunning)
            {
                TimeSpan ts = stoperica2.Elapsed;
                trenutnoVrijeme2 = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds); 
                if (trenutnoVrijeme2 == pauza)
                {
                    stoperica2.Stop();
                    stoperica1.Start();
                    dt1.Stop();
                }
            }
        }

        private int RandomNumber(int min, int max)
        {
            Random r = new Random();
            int rInt = r.Next(min, max);
            return rInt;
        }


        private void izlistajIzvodjaca()
        {
            igricaEntities db = new igricaEntities();
            int broj = RandomNumber(1, 6);
            izvodjac = (from s in db.stringovi where s.indeks == broj select s.Ime).Single();
            for (int i = 0; i < izvodjac.Length; i++)
            {
                if (izvodjac[i] != ' ')
                {
                    linije[i].Visibility = Visibility.Visible;
                    txtlist[i].Visibility = Visibility.Visible;
                }
                else txtlist[i].Text = " ";
                int sl1, sl2, sl3;

                while (true)
                {
                    sl1 = RandomNumber(0, izvodjac.Length);
                    sl2 = RandomNumber(0, izvodjac.Length);
                    sl3 = RandomNumber(0, izvodjac.Length);
                    if (sl1 != sl2 && sl1 != sl3 && sl3 != sl2) break;
                    if (izvodjac[sl1] != ' ' && izvodjac[sl2] != ' ' && izvodjac[sl3] != ' ') break;
                    else continue;
                }
                txtlist[0].Text = izvodjac[0].ToString();
                txtlist[sl1].Text = izvodjac[sl1].ToString();
                txtlist[sl2].Text = izvodjac[sl2].ToString();
                txtlist[sl3].Text = izvodjac[sl3].ToString();
            }
        }

        private void buttonPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            String unesenaRijec = "";
            for (int i = 0; i < izvodjac.Length; i++)
            {
                unesenaRijec += txtlist[i].Text;
            }

            if (unesenaRijec == izvodjac)
            {
                trenutnoPitanje++;
                labelPotvrda.Content = "Čestitamo, pogodili ste!";
                labelPotvrda.Foreground = new SolidColorBrush(Colors.Green);
                labelPitanje.Content = trenutnoPitanje.ToString() + "/" + br_pitanja.ToString();
                resetujPolja();
                if (trenutnoPitanje <= br_pitanja) izlistajIzvodjaca();
                if (trenutnoPitanje > br_pitanja)
                {
                    provjeriVrijeme();
                }
            }
            else 
            {
                labelPotvrda.Content = "Pogriješili ste, žao nam je. Pokušajte ponovo!";
                labelPotvrda.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void resetujPolja()
        {
            for (int i = 0; i < 20; i++)
            {
                linije[i].Visibility = Visibility.Hidden;
                txtlist[i].Visibility = Visibility.Hidden;
                txtlist[i].Text = "";
            }
        }

        private void provjeriVrijeme()
        {
            igricaEntities db = new igricaEntities();
            var rezultati = (from rez in db.highscore where rez.Nivo == n select rez).ToList();
            var sortirani = rezultati.OrderBy(o => o.Vrijeme).ToList();
            for (int i = 0; i < 1; i++)
            {
                string[] s = trenutnoVrijeme.Split(':');
                vrijeme = Convert.ToInt32(s[1]) * 60 + Convert.ToInt32(s[2]);
                if (vrijeme < sortirani[i].Vrijeme)
                {
                    MessageBox.Show("Vaše vrijeme je isteklo.", "Igra je gotova", MessageBoxButton.OK);
                    unesiHigh uH = new unesiHigh(n, vrijeme);
                    this.Close();
                    uH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vaše vrijeme je isteklo", "Igra je gotova", MessageBoxButton.OK);
                    this.Close();
                }
            }
        }
  
        private void buttonDajSlova_Click(object sender, RoutedEventArgs e)
        {
            int sl1, sl2, sl3;
            while (true)
            {
                sl1 = RandomNumber(0, izvodjac.Length);
                sl2 = RandomNumber(0, izvodjac.Length);
                sl3 = RandomNumber(0, izvodjac.Length);
                if (sl1 != sl2 && sl1 != sl3 && sl3 != sl2) break;
                if (izvodjac[sl1] != ' ' && izvodjac[sl2] != ' ' && izvodjac[sl3] != ' ' && txtlist[sl1].Text=="" && txtlist[sl2].Text=="" && txtlist[sl3].Text == "") break;
                else continue;
            }
            txtlist[sl1].Text = izvodjac[sl1].ToString();
            txtlist[sl2].Text = izvodjac[sl2].ToString();
            txtlist[sl3].Text = izvodjac[sl3].ToString();

            buttonDajSlova.IsEnabled = false;
        }

        private void buttonPauziraj_Click(object sender, RoutedEventArgs e)
        {
            stoperica1.Stop();
            stoperica2.Start();
            dt1.Start();
            buttonPauziraj.IsEnabled = false;
        }

        private void buttonPromjeni_Click(object sender, RoutedEventArgs e)
        {
            resetujPolja();
            izlistajIzvodjaca();
            buttonPromjeni.IsEnabled = false;
        }


        private void myrect_GotFocus(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("sd");
            s.Begin();	// Start animation
        }
       
    }
}
