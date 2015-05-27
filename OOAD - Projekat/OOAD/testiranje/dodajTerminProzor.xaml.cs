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
            zahtjevi z = (from zh in DB.zahtjevi where id_zahtjeva == zh.ID select zh).Single();
            id_korisnika = z.Korisnici_ID;
            
            if (z.SifraZahtjeva == 1) id_radnika = (from kr in DB.kartoni where kr.ID == id_korisnika select kr.ID_D).Single();
            else if (z.SifraZahtjeva == 2) id_radnika = (from kr in DB.kartoni where kr.ID == id_korisnika select kr.ID_Ps).Single();
            else if (z.SifraZahtjeva == 3) id_radnika = (from kr in DB.kartoni where kr.ID == id_korisnika select kr.ID_E.Value).Single();
            else id_radnika = (from kr in DB.kartoni where kr.ID == id_korisnika select kr.ID_Pr.Value).Single();

            dostupni = rk.dajDostupneTermine(id_korisnika, id_radnika);            
            
            foreach (int i in dostupni)
            {
                int pomocna = i;
               
                if (pomocna % 10 == 0) vrijeme = "09";
                else if (pomocna % 10 == 1) vrijeme = "11";
                else if (pomocna % 10 == 2) vrijeme = "13";
                else if (pomocna % 10 == 3) vrijeme = "15";
                else vrijeme = "17";
                if (pomocna / 10 == 0) dan = "Ponedjeljak";
                else if (pomocna / 10 == 1) dan = "Utorak";
                else if (pomocna / 10 == 2) dan = "Srijeda";
                else if (pomocna / 10 == 3) dan = "Cetvrtak";
                else dan = "Petak";
                dodajTerminListBox.Items.Add(vrijeme + ":00, " + dan);
            }
            
        }

        private void dodajTerminListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indeks = dodajTerminListBox.SelectedIndex;
            int zakodiraniTermin = dostupni[indeks];

            int pomocna = zakodiraniTermin;
            if (pomocna % 10 == 0) vrijeme = "09";
            else if (pomocna % 10 == 1) vrijeme = "11";
            else if (pomocna % 10 == 2) vrijeme = "13";
            else if (pomocna % 10 == 3) vrijeme = "15";
            else vrijeme = "17";
            if (pomocna / 10 == 0) dan = "Ponedjeljak";
            else if (pomocna / 10 == 1) dan = "Utorak";
            else if (pomocna / 10 == 2) dan = "Srijeda";
            else if (pomocna / 10 == 3) dan = "Cetvrtak";
            else dan = "Petak";

        }

        private void dodajButton_Click(object sender, RoutedEventArgs e)
        {
            DB.rasporedi.Add(new rasporedi() { Dan = dan, Vrijeme = vrijeme, ID_K = id_korisnika, ID_R = id_radnika });
            DB.SaveChanges();
        }
    }
}
