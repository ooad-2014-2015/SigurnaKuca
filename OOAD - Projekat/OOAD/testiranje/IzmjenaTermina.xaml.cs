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
    /// Interaction logic for IzmjenaTermina.xaml
    /// </summary>
    public partial class IzmjenaTermina : Window
    {
        rasporedi odabraniTermin ;
        RasporedKontroler rk;
        List<int> dostupni;
        List<String> zaListBox;
        String Vrijeme;
        String Dan;
        mydbEntities DB = new mydbEntities();
        public IzmjenaTermina()
        {
            InitializeComponent();
            
            RasporedKontroler rk = new RasporedKontroler(GlobalneVarijable.trenutnaOsoba);
            foreach (rasporedi rs in rk.ZauzetiTermini)
            {
                TerminiListBox.Items.Add(rs);
            }

        }

        private void TerminiListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            odabraniTermin = (rasporedi)TerminiListBox.SelectedItem;
            rk = new RasporedKontroler();
            dostupni = rk.dajDostupneTermine(odabraniTermin.ID_K, odabraniTermin.ID_R);
            zaListBox = new List<String>();
            foreach (int i in dostupni)
            {
                int pomocna = i;
                String Vrijeme;
                String Dan;
                if (pomocna % 10 == 0) Vrijeme = "09";
                else if (pomocna % 10 == 1) Vrijeme = "11";
                else if (pomocna % 10 == 2) Vrijeme = "13";
                else if (pomocna % 10 == 3) Vrijeme = "15";
                else Vrijeme = "17";
                if (pomocna / 10 == 0) Dan = "Ponedjeljak";
                else if (pomocna / 10 == 1) Dan = "Utorak";
                else if (pomocna / 10 == 2) Dan = "Srijeda";
                else if (pomocna / 10 == 3) Dan = "Cetvrtak";
                else Dan = "Petak";
                DostupniListBox.Items.Add(Vrijeme + ":00, " + Dan);
            }
            DostupniListBox.Visibility = Visibility.Visible;
        }

        private void DostupniListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int indeks = DostupniListBox.SelectedIndex;
            int zakodiraniTermin = dostupni[indeks];
            
            int pomocna = zakodiraniTermin;
            if (pomocna % 10 == 0) Vrijeme = "09";
            else if (pomocna % 10 == 1) Vrijeme = "11";
            else if (pomocna % 10 == 2) Vrijeme = "13";
            else if (pomocna % 10 == 3) Vrijeme = "15";
            else Vrijeme = "17";
            if (pomocna / 10 == 0) Dan = "Ponedjeljak";
            else if (pomocna / 10 == 1) Dan = "Utorak";
            else if (pomocna / 10 == 2) Dan = "Srijeda";
            else if (pomocna / 10 == 3) Dan = "Cetvrtak";
            else Dan = "Petak";
            
        }

        private void potvrdiButton_Click(object sender, RoutedEventArgs e)
        {
            var termin = (from rs in DB.rasporedi where rs.ID_K == odabraniTermin.ID_K && rs.ID_R == odabraniTermin.ID_R select rs).First();
            termin.Vrijeme = Vrijeme;
            termin.Dan = Dan;
            DB.SaveChanges();
            DB.zahtjevi.Add(new zahtjevi() { Korisnici_ID = odabraniTermin.ID_K, OpisZahtjeva = "Promjena termina u rasporedu", SifraZahtjeva = 5 });
            DB.SaveChanges();
            MessageBox.Show("Uspjesno ste obavili izmjenu rasporeda!");
        }
    }
}
