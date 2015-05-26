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

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           this.Content =new GamePage();
        }

        private void button_changeLevel_Click(object sender, RoutedEventArgs e)
        {
            grid_changeLevel.Visibility = Visibility.Visible;
            grid_start.Visibility = Visibility.Collapsed;
        }

        private void button_backLevel_Click(object sender, RoutedEventArgs e)
        {
            grid_start.Visibility = Visibility.Visible;
            grid_changeLevel.Visibility = Visibility.Collapsed;
        }

        private void image_1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
        }

        private void image_1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(image_1.Opacity!=50) grid_selectedLevel.Visibility = Visibility.Collapsed;
        }

        private void image_2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
        }

        private void image_2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (image_2.Opacity != 50) grid_selectedLevel.Visibility = Visibility.Collapsed;
        }

        private void image_3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
        }

        private void image_3_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (image_3.Opacity != 50) grid_selectedLevel.Visibility = Visibility.Collapsed;
        }

        private void image_4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
        }

        private void image_4_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (image_4.Opacity != 50) grid_selectedLevel.Visibility = Visibility.Collapsed;
        }

        private void image_5_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
        }

        private void image_5_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (image_5.Opacity != 50) grid_selectedLevel.Visibility = Visibility.Collapsed;
        }

        private void image_1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
            image_1.Opacity = 50;
        }

        private void image_2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
            image_2.Opacity = 50;
        }

        private void image_3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
            image_3.Opacity = 50;
        }

        private void image_4_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
            image_4.Opacity = 50;
        }

        private void image_5_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            grid_selectedLevel.Visibility = Visibility.Visible;
            image_5.Opacity = 50;
        }

      

    
    }
}
