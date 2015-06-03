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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Pitanja.xaml
    /// </summary>
    public partial class Pitanja : Window
    {
        String izvodjac;
        List<TextBox> txtlist;
        int vrijeme_sekunde;
        int br_pitanja;
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public Pitanja(int nivo)
        {

            InitializeComponent();
            
            List<Line> linije = new List<Line>();
            txtlist= new List<TextBox>();
            txtlist.Add(txt1);
            txtlist.Add(txt2);
            txtlist.Add(txt3);
            txtlist.Add(txt4);
            txtlist.Add(txt5);
            txtlist.Add(txt6);
            txtlist.Add(txt7);
            txtlist.Add(txt8);
            txtlist.Add(txt9);
            txtlist.Add(txt10);
            txtlist.Add(txt11);
            txtlist.Add(txt12);
            txtlist.Add(txt13);
            txtlist.Add(txt14);
            txtlist.Add(txt15);
            txtlist.Add(txt16);
            txtlist.Add(txt17);
            txtlist.Add(txt18);
            txtlist.Add(txt19);
            txtlist.Add(txt20);
            for (int i = 0; i < 20; i++)
            {
                Line myLine = new Line();
                myLine.Stroke = System.Windows.Media.Brushes.Black;
                myLine.X1 = 10+22*i; //na 1 pocinje
                myLine.X2 = (10 + 22 * i) + 17;
                myLine.Y1 = 20;
                myLine.Y2 = 20;
                myLine.HorizontalAlignment = HorizontalAlignment.Left;
                myLine.VerticalAlignment = VerticalAlignment.Center;
                myLine.StrokeThickness = 2;
                myLine.Visibility = Visibility.Hidden;
                gridzaslova1.Children.Add(myLine);
                linije.Add(myLine);
                txtlist[i].Visibility = Visibility.Hidden;
                
            }

            

            igricaEntities1 db = new igricaEntities1();
            int broj = RandomNumber(1, 200);
            izvodjac = (from s in db.stringovi where s.indeks==1 select s.Ime).Single();
            for (int i = 0; i < izvodjac.Length ; i++)
            {
                if (izvodjac[i] != ' ')
                {
                    linije[i].Visibility = Visibility.Visible;

                }
                else txtlist[i].Text = " ";
                int sl1, sl2, sl3;
                txtlist[i].Visibility = Visibility.Visible;
                while (true)
                {
                    sl1 = RandomNumber(0, izvodjac.Length);
                    sl2 = RandomNumber(0, izvodjac.Length);
                    sl3 = RandomNumber(0, izvodjac.Length);
                    if (sl1 != sl2 && sl1 != sl3 && sl3 != sl2) break;
                    if (izvodjac[sl1] != ' ' && izvodjac[sl2] != ' ' && izvodjac[sl3] != ' ') break;
                    else continue;
                }
                txtlist[sl1].Text = izvodjac[sl1].ToString();
                txtlist[sl2].Text = izvodjac[sl2].ToString();
                txtlist[sl3].Text = izvodjac[sl3].ToString();

            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String unesenaRijec = "";
            for(int i=0; i<izvodjac.Length;i++)
            {
                unesenaRijec += txtlist[i].Text;
            }
            if (unesenaRijec == izvodjac) System.Windows.Forms.MessageBox.Show("aaaa");
        }
    }
}
