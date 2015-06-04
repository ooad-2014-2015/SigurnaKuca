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
            int nivo = comboxNivo.SelectedIndex;
            igricaEntities db = new igricaEntities();
            var rezultati = (from rez in db.highscore  where rez.Nivo == nivo orderby rez.Vrijeme descending select rez).ToList();

            t1.Text = "Ime: " + rezultati[0].Ime + "   Vrijeme: " + rezultati[0].Vrijeme.ToString();
            t2.Text = "Ime: " + rezultati[1].Ime + "   Vrijeme: " + rezultati[1].Vrijeme.ToString();
            t3.Text = "Ime: " + rezultati[2].Ime + "   Vrijeme: " + rezultati[2].Vrijeme.ToString();
            t4.Text = "Ime: " + rezultati[3].Ime + "   Vrijeme: " + rezultati[3].Vrijeme.ToString();
            t5.Text = "Ime: " + rezultati[4].Ime + "   Vrijeme: " + rezultati[4].Vrijeme.ToString();
        }
    }
}
