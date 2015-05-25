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
    /// Interaction logic for RasporedProzor.xaml
    /// </summary>
    public partial class RasporedProzor : Window
    {
        public RasporedProzor(Osoba O)
        {
            InitializeComponent();
            mydbEntities DB = new mydbEntities();
            RasporedKontroler rk = new RasporedKontroler(O);
            List<GroupBox> terminigroup = new List<GroupBox>();
            List<TextBlock> terminitxt = new List<TextBlock>();
            
            terminigroup.Add(t1);
            terminigroup.Add(t2);
            terminigroup.Add(t3);
            terminigroup.Add(t4);
            terminigroup.Add(t5);
            terminigroup.Add(t6);
            terminigroup.Add(t7);
            terminigroup.Add(t8);
            terminigroup.Add(t9);
            terminigroup.Add(t10);
            terminigroup.Add(t11);
            terminigroup.Add(t12);
            terminigroup.Add(t13);
            terminigroup.Add(t14);
            terminigroup.Add(t15);
            terminigroup.Add(t16);
            terminitxt.Add(txt1);
            terminitxt.Add(txt2);
            terminitxt.Add(txt3);
            terminitxt.Add(txt4);
            terminitxt.Add(txt5);
            terminitxt.Add(txt6);
            terminitxt.Add(txt7);
            terminitxt.Add(txt8);
            terminitxt.Add(txt9);
            terminitxt.Add(txt10);
            terminitxt.Add(txt11);
            terminitxt.Add(txt12);
            terminitxt.Add(txt13);
            terminitxt.Add(txt14);
            terminitxt.Add(txt15);
            terminitxt.Add(txt16);
            
            for (int i = 0; i < rk.ZauzetiTermini.Count; i++)
            {
                terminigroup[i].Header = rk.ZauzetiTermini[i].Dan + ", " + rk.ZauzetiTermini[i].Vrijeme;
                if (O is Korisnik)
                {
                    String ime, prezime;
                    int IDr = rk.ZauzetiTermini[i].ID_R;
                    ime = (from r in DB.radnici where r.ID == IDr select r.Ime).Single();
                    prezime = (from r in DB.radnici where r.ID == IDr select r.Prezime).Single();
                    terminitxt[i].Text = ime + " " + prezime;
                }
                else
                {
                    String ime, prezime;
                    int IDk = rk.ZauzetiTermini[i].ID_K;
                    ime = (from r in DB.korisnici where r.ID == IDk select r.Ime).Single();
                    prezime = (from r in DB.korisnici where r.ID == IDk select r.Prezime).Single();
                    terminitxt[i].Text = ime + " " + prezime;
                }
                terminigroup[i].Visibility = Visibility.Visible;
                terminitxt[i].Visibility = Visibility.Visible;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RasporedKontroler rk = new RasporedKontroler(GlobalneVarijable.trenutnaOsoba);
            List<RadioButton> terminirb = new List<RadioButton>();
            terminirb.Add(rb1);
            terminirb.Add(rb2);
            terminirb.Add(rb3);
            terminirb.Add(rb4);
            terminirb.Add(rb5);
            terminirb.Add(rb6);
            terminirb.Add(rb7);
            terminirb.Add(rb8);
            terminirb.Add(rb9);
            terminirb.Add(rb10);
            terminirb.Add(rb11);
            terminirb.Add(rb12);
            terminirb.Add(rb13);
            terminirb.Add(rb14);
            terminirb.Add(rb15);
            terminirb.Add(rb16);
            for (int i = 0; i < rk.ZauzetiTermini.Count; i++)
            {
                terminirb[i].Content = rk.ZauzetiTermini[i].Dan + ", " + rk.ZauzetiTermini[i].Vrijeme + ":00";
                terminirb[i].Visibility = Visibility.Visible;
            }

        }

        

        
    }
}
