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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for ispisHigh.xaml
    /// </summary>
    public partial class ispisHigh : Window
    {
        public ispisHigh()
        {
            InitializeComponent();
        }

        private void myrect_GotFocus(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("sd");
            s.Begin();
        }

        private void buttonzatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // prepraviti ovo ne radi ovo orderby i da se ispis fino piše u formatu 00:00:00
            int nivo = comboxNivo.SelectedIndex+1;
            igricaEntities db = new igricaEntities();
            var rezultati = (from rez in db.highscore  where rez.Nivo == nivo select rez).ToList();
            var sortirani = rezultati.OrderBy(o => o.Vrijeme).ToList();

            t1.Text = "Ime: " + sortirani[0].Ime + "   Vrijeme: " + vratiVrijeme(sortirani[0].Vrijeme.Value);
            t2.Text = "Ime: " + sortirani[1].Ime + "   Vrijeme: " + vratiVrijeme(sortirani[1].Vrijeme.Value);
            t3.Text = "Ime: " + sortirani[2].Ime + "   Vrijeme: " + vratiVrijeme(sortirani[2].Vrijeme.Value);
            t4.Text = "Ime: " + sortirani[3].Ime + "   Vrijeme: " + vratiVrijeme(sortirani[3].Vrijeme.Value);
            t5.Text = "Ime: " + sortirani[4].Ime + "   Vrijeme: " + vratiVrijeme(sortirani[4].Vrijeme.Value);
        }

        private string vratiVrijeme(int vrijeme)
        {
            if (vrijeme >= 60)
            {
                int minute = vrijeme / 60;
                int sekunde = vrijeme % 60;

                return String.Format("{0:00}:{1:00}:{2:00}", 0, minute, sekunde);
            }
            else
            {
                return String.Format("{0:00}:{1:00}:{2:00}", 0, 0, vrijeme);
            }
        }
    }
}
