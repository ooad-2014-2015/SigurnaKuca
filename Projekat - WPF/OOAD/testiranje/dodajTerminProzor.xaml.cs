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
using System.Windows.Shapes;

namespace SafeHouse
{
    /// <summary>
    /// Interaction logic for dodajTerminProzor.xaml
    /// </summary>
    public partial class dodajTerminProzor : Window
    {
        List<int> dostupni;
        String vrijeme;
        String dan;
        mydbEntities DB = new mydbEntities();
        int id_korisnika;
        int id_radnika;
        public dodajTerminProzor(int id_zahtjeva)
        {
            InitializeComponent();
            // zahtjev za med pomoc = 1;
            // zahtjev za psih pomoc = 2;
            // zahtjev za ek pomoc = 3;
            // zahtjev za prav pomoc = 4;
            
            
            RasporedKontroler rk = new RasporedKontroler();

            AdminFormaKontroler.dajIDRadnika(id_zahtjeva);            
            id_korisnika = AdminFormaKontroler.dajIDKorisnika(id_zahtjeva);         
            dostupni = rk.dajDostupneTermine(id_korisnika, id_radnika);           

            
            foreach (int i in dostupni)
            {
                dodajTerminListBox.Items.Add(RasporedKontroler.dajVrijeme(i) + ":00, " + RasporedKontroler.dajDan(i));
            }
            
        }

        private void dodajTerminListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indeks = dodajTerminListBox.SelectedIndex;
            int zakodiraniTermin = dostupni[indeks];
            dan = RasporedKontroler.dajDan(zakodiraniTermin);
            vrijeme = RasporedKontroler.dajVrijeme(zakodiraniTermin);
            

        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {

            RasporedKontroler.dodajTermin(dan, vrijeme, id_korisnika, id_radnika);

            MessageBox.Show("Uspjesno ste dodali novi termin za datog korisnika");
            this.Close();

        }
    }
}
