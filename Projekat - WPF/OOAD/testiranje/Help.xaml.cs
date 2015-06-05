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
   
    public partial class Help : Window
    {
        
        public Help()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
            
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            string veb=("C:\\Users\\SenkaIb\\Desktop\\SigurnaKuca\\Projekat - WPF\\OOAD\\HelpSafeHouse\\HelpSafeHouse.htm");
            web_help.Source=new Uri(veb);
            web_help.Navigate(veb);
        
        }
       
        
       
       
       
    }
}
