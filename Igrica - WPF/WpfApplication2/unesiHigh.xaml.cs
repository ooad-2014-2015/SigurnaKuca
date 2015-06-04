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
    /// Interaction logic for unesiHigh.xaml
    /// </summary>
    public partial class unesiHigh : Window
    {
        int n;
        int v;
        public unesiHigh(int nivo, int vrijeme)
        {
            InitializeComponent();
            n = nivo;
            v = vrijeme;
        }

        private void myrect_GotFocus(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("sd");
            s.Begin();
        }

        private void buttonZavrsi_Click(object sender, RoutedEventArgs e)
        {
            string ime = textBoxIme.Text;

            igricaEntities db = new igricaEntities();
            db.highscore.Add(new highscore() { Ime = ime, Nivo = n, Vrijeme = v });
            db.SaveChanges();
        }
    }
}
