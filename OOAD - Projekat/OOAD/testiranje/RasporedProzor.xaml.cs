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
                terminitxt[i].Text = rk.dajDrugog(O,i);
                terminigroup[i].Visibility = Visibility.Visible;
                terminitxt[i].Visibility = Visibility.Visible;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IzmjenaTermina ik = new IzmjenaTermina();
            ik.ShowDialog();
           
        }

        

        
    }
}
