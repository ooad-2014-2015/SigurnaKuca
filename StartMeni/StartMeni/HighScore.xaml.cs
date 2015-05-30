using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



namespace StartMeni
{
    
    public sealed partial class HighScore : Page
    {
        public HighScore()
        {
            this.InitializeComponent();
        }

      
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button_backHighScore_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new MainPage();
        }
    }
}
