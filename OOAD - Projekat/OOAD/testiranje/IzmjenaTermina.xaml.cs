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
         //   zaListBox = new List<String>(); 
            foreach (int i in dostupni)
            {
                int pomocna = i;              
                DostupniListBox.Items.Add(RasporedKontroler.dajVrijeme(pomocna) + ":00, " + RasporedKontroler.dajDan(pomocna));
            }
            DostupniListBox.Visibility = Visibility.Visible;
        }

        private void DostupniListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int indeks = DostupniListBox.SelectedIndex;
            int zakodiraniTermin = dostupni[indeks];
            Vrijeme = RasporedKontroler.dajVrijeme(zakodiraniTermin);
            Dan = RasporedKontroler.dajDan(zakodiraniTermin);            
            
        }

        private void potvrdiButton_Click(object sender, RoutedEventArgs e)
        {
            RasporedKontroler.IzmijeniTermin(Dan, Vrijeme, odabraniTermin.ID_K, odabraniTermin.ID_R);

            
            MessageBox.Show("Uspjesno ste obavili izmjenu rasporeda!");
        }
    }
}
