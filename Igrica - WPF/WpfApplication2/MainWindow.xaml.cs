using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.Windows.Media.Animation;

namespace WpfApplication2
{

    public partial class MainWindow : Window
    {
        private void myrect_GotFocus(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("sd");
            s.Begin();	// Start animation
        }

        private void buttonNivo1_Click(object sender, RoutedEventArgs e)
        {
            Pitanja p = new Pitanja(1);
            this.Hide();
            p.Show();
            
           
        }

        

        private void buttonNivo2_Click(object sender, RoutedEventArgs e)
        {
            Pitanja p = new Pitanja(2);
            this.Hide();
            p.Show();
        }

        private void buttonNivo3_Click(object sender, RoutedEventArgs e)
        {
            Pitanja p = new Pitanja(3);
            this.Hide();
            p.Show();
        }

        private void buttonNivo4_Click(object sender, RoutedEventArgs e)
        {
            Pitanja p = new Pitanja(4);
            this.Hide();
            p.Show();
        }

        private void buttonNivo5_Click(object sender, RoutedEventArgs e)
        {
            Pitanja p = new Pitanja(5);
            this.Hide();
            p.Show();
        }

        private void buttonPrikaz_Click(object sender, RoutedEventArgs e)
        {
            ispisHigh i = new ispisHigh();
            this.Hide();
            i.Show();
        }


    }
}
