using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Controls;
using System.Reflection;

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
            string appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            string[] doFoldera = appDir.Split('\\');
            string nova = "";
            for (int i = 0; i < doFoldera.Count() - 3; i++) nova += (doFoldera[i]+"\\");
            
            nova += @"HelpSafeHouse\HelpSafeHouse.htm";
            web_help.Source = new Uri(nova);
            web_help.Navigate(nova);
        }
       
    }
}
