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
using Microsoft.Expression.Encoder.Devices;
using WebcamControl;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace SafeHouse
{
    /// <summary>
    /// Interaction logic for WebKamera.xaml
    /// </summary>
    public partial class WebKamera : Window
    {
        public WebKamera()
        {
            InitializeComponent();

            Binding binding_1 = new Binding("SelectedValue");
            binding_1.Source = VideoDevicesComboBox;
            WebcamCtrl.SetBinding(Webcam.VideoDeviceProperty, binding_1);

            Binding binding_2 = new Binding("SelectedValue");
            binding_2.Source = AudioDevicesComboBox;
            WebcamCtrl.SetBinding(Webcam.AudioDeviceProperty, binding_2);

            // Kreiranje direktorija za spašavanje video snimke
            string videoPut = @"C:\VideoClips";

            if (!Directory.Exists(videoPut))
            {
                Directory.CreateDirectory(videoPut);
            }

            // Kreiranje direktorija za spašavanje slika
            string slikaPut = @"C:\WebcamSnapshots";

            if (!Directory.Exists(slikaPut))
            {
                Directory.CreateDirectory(slikaPut);
            }


            WebcamCtrl.VideoDirectory = videoPut;
            WebcamCtrl.ImageDirectory = slikaPut;
            WebcamCtrl.FrameRate = 30;
            WebcamCtrl.FrameSize = new System.Drawing.Size(640, 480);

            // Ponalazak dostupnih audio i video uređaja
            var vidDevices = EncoderDevices.FindDevices(EncoderDeviceType.Video);
            var audDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            VideoDevicesComboBox.ItemsSource = vidDevices;
            AudioDevicesComboBox.ItemsSource = audDevices;
            VideoDevicesComboBox.SelectedIndex = 0;
            AudioDevicesComboBox.SelectedIndex = 0;
        }

        private void ZapocniPrikaz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Display webcam video
                WebcamCtrl.StartCapture(); // ne valja ovo jer nije radilo izvorno a ni ovo ne možeee jer baca izuzetak i zato ne spašava
            }
            catch (Microsoft.Expression.Encoder.SystemErrorException ex)
            {
                MessageBox.Show("Device is in use by another application");
            }

        }

        private void ZaustaviPrikaz_Click(object sender, RoutedEventArgs e)
        {
            // Stop the display of webcam video.
            WebcamCtrl.StopCapture();  // ni ovo istooo
        }

        // brisat valjda
        private void ZapocniSnimanje_Click(object sender, RoutedEventArgs e)
        {
            // Start recording of webcam video to harddisk.
            WebcamCtrl.StartRecording();
        }

        // brisat valjda
        private void ZaustaviSnimanje_Click(object sender, RoutedEventArgs e)
        {
            // Stop recording of webcam video to harddisk.
            WebcamCtrl.StopRecording();
        }

        // brisat valjda
        private void Uslikaj_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam video.
            WebcamCtrl.TakeSnapshot();
        }
    }
}
