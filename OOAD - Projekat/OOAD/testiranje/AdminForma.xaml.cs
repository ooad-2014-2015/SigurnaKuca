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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SafeHouse;
using System.Threading;
using System.Data;
using System.Collections;
using System.Globalization;

namespace SafeHouse
{

    public partial class AdminForma : Window
    {
        Thread t;
        sigurnaKuca sk = new sigurnaKuca();

        public AdminForma()
        {
            InitializeComponent();
            
            
            t = new Thread(new ThreadStart(this.provjeraBazeZahtjev));
            t.Start();
            while (!t.IsAlive) ;
        }

        ~AdminForma()
        {
            t.Abort();
        }

        private void combobox_opisPoslaRadnika_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            if (combobox_opisPoslaRadnika.SelectedIndex != -1) groupBox_dodjelaPristupa.Visibility = Visibility.Visible;
        }

        //da vrati na staru boju !!!!
        private void textbox_imeRadnika_TextChanged(object sender, RoutedEventArgs e)
        {
            var color = (Color)ColorConverter.ConvertFromString("#FFDCDADA");
            var brush = new SolidColorBrush(color);
            if (textbox_imeRadnika.Background == Brushes.IndianRed) textbox_imeRadnika.Background = brush;
        }

        private void registracija_radnika_Click(object sender, RoutedEventArgs e)
        {
            
            // validacija pri regisraciji
            if (textbox_imeRadnika.Text.Any(x => Char.IsDigit(x)))
            {
                MessageBox.Show("Ne možete unositi brojeve! ", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
               return;
            }

            if (textbox_prezimeRadnika.Text.Any(x => Char.IsDigit(x)))
            {
                MessageBox.Show("Ne možete unositi brojeve! ", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            

            if (textbox_imeRadnika.Text.Count() == 0 || textbox_prezimeRadnika.Text.Count() == 0 || textbox_usernameRadnika.Text.Count() == 0 || textbox_passwordRadnika.Text.Count() == 0 )
            {
                if (textbox_imeRadnika.Text.Count() == 0)
                {
                    MessageBox.Show("Molimo vas unesite podatak!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    textbox_imeRadnika.Background = Brushes.IndianRed; return;
                }
                

                if (textbox_prezimeRadnika.Text.Count() == 0)
                {
                    MessageBox.Show("Molimo vas unesite podatak!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    textbox_prezimeRadnika.Background = Brushes.IndianRed; return;
                }


                if (textbox_usernameRadnika.Text.Count() == 0)
                {
                    MessageBox.Show("Molimo vas unesite podatak!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    textbox_usernameRadnika.Background = Brushes.IndianRed; return;
                }


                if (textbox_passwordRadnika.Text.Count() == 0)
                {
                    MessageBox.Show("Molimo vas unesite podatak!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    textbox_passwordRadnika.Background = Brushes.IndianRed; return;
                }


            }
            else
            {
                
                // unos radnika u bazu
                
                AdminFormaKontroler.RegistrujRadnika(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, textbox_usernameRadnika.Text,textbox_passwordRadnika.Text, combobox_opisPoslaRadnika.SelectedIndex,  dateTimePicker1.SelectedDate??DateTime.Now );

                // dodavanje u liste odgovarajućih zaposlenih sa osnovnim podacima

                if (combobox_opisPoslaRadnika.SelectedIndex == 0)
                {
                    Doktor d = new Doktor(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.SelectedDate.Value, 
                        textbox_usernameRadnika.Text, textbox_passwordRadnika.Text, AdminFormaKontroler.dajIDRadnika(textbox_usernameRadnika.Text));
                    sk.dodajDoktora(d);
                    MessageBox.Show("Uspješno ste registrovali novog doktora!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                }

                if (combobox_opisPoslaRadnika.SelectedIndex == 1)
                {
                    Psiholog p = new Psiholog(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.SelectedDate.Value, 
                        textbox_usernameRadnika.Text, textbox_passwordRadnika.Text, AdminFormaKontroler.dajIDRadnika(textbox_usernameRadnika.Text));
                    sk.dodajPsihologa(p);
                    MessageBox.Show("Uspješno ste registrovali novog psihologa!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                }

                if (combobox_opisPoslaRadnika.SelectedIndex == 2)
                {
                    Ekonomista ek = new Ekonomista(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.SelectedDate.Value,
                        textbox_usernameRadnika.Text, textbox_passwordRadnika.Text,AdminFormaKontroler.dajIDRadnika(textbox_usernameRadnika.Text));
                    sk.dodajEkonomistu(ek);
                    MessageBox.Show("Uspješno ste registrovali novog ekonomistu!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                }

                if (combobox_opisPoslaRadnika.SelectedIndex == 3)
                {
                    Pravnik p = new Pravnik(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.SelectedDate.Value, 
                        textbox_usernameRadnika.Text, textbox_passwordRadnika.Text, AdminFormaKontroler.dajIDRadnika(textbox_usernameRadnika.Text));
                    sk.dodajPravnika(p);
                    MessageBox.Show("Uspješno ste registrovali novog pravnika!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                }

                
                // fali raspored button, da kreira prazan raspored za svakog zaposlenog, i obavjesti da je uspješno kreirano ??
               /* db.lokacije.Add(new lokacije() { Adresa = "Brcanska 13" });
                db.lokacije.Add(new lokacije() { Adresa = "Muftije Dzabijca 12" });
                db.lokacije.Add(new lokacije() { Adresa = "Ferde Haupmana 6" });
                db.lokacije.Add(new lokacije() { Adresa = "Titova 133" });
                db.lokacije.Add(new lokacije() { Adresa = "Ferhadija 18" });
                db.lokacije.Add(new lokacije() { Adresa = "Vrbovska 183" });
                db.lokacije.Add(new lokacije() { Adresa = "Dzemala Bijedica 18" });
                db.lokacije.Add(new lokacije() { Adresa = "Bulevar Mese Selimovica 188" }); 
                db.SaveChanges(); */ 

            }
        }

        // validacija username-a, mora počinjati sa prvim slovom opisa posla!
        private void textbox_usernameRadnika_Validated(object sender, RoutedEventArgs e)
        {
            string priv = Convert.ToString(textbox_usernameRadnika.Text);
           

            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 0 && priv[0] != 'd')
            {
                MessageBox.Show("Uneseni username nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_usernameRadnika.Background = Brushes.IndianRed; return;
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 1 && priv[0] != 'p' && priv[1] != 's')
            {
                MessageBox.Show("Uneseni username nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_usernameRadnika.Background = Brushes.IndianRed; return;
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 2 && priv[0] != 'e')
            {
                MessageBox.Show("Uneseni username nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_usernameRadnika.Background = Brushes.IndianRed; return;
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 3 && priv[0] != 'p' && priv[1] != 'r')
            {
                MessageBox.Show("Uneseni username nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_usernameRadnika.Background = Brushes.IndianRed; return;
            }

        }

        // validacija šifre, mora počinjati sa prvim slovom opisa posla!
        private void textbox_passwordRadnika_TextChanged(object sender, RoutedEventArgs e)
        {
            string priv = Convert.ToString(textbox_passwordRadnika.Text);
           

            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 0 && priv[0] != 'd')
            {
                MessageBox.Show("Uneseni password nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_passwordRadnika.Background = Brushes.IndianRed; return;
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 1 && priv[0] != 'p' && priv[1] != 's')
            {
                MessageBox.Show("Uneseni password nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_passwordRadnika.Background = Brushes.IndianRed; return;
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 2 && priv[0] != 'e')
            {
                MessageBox.Show("Uneseni password nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_passwordRadnika.Background = Brushes.IndianRed; return;
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 3 && priv[0] != 'p' && priv[1] != 'r')
            {
                MessageBox.Show("Uneseni password nije validan! Pokušajte ponovo!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_passwordRadnika.Background = Brushes.IndianRed; return;
            }

        }

        private void button_registrujKorisnika_Click(object sender, RoutedEventArgs e)
        {

            if (radioButton_potpunoAnoniman.IsChecked == true && (comboBox_personalniDoktorAnonimniKorisnik.SelectedIndex == -1 || comboBox_personalniEkonomistaAnonimniKorisnik.SelectedIndex == -1 || comboBox_personalniPravnikAnonimniKorisnik.SelectedIndex == -1 || comboBox_personalniPsihologAnonimniKorisnik.SelectedIndex == -1))
            {
                if (comboBox_personalniDoktorAnonimniKorisnik.SelectedIndex == -1)
                {
                    MessageBox.Show("Molimo vas izaberite jednu od ponuđenih opcija!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    comboBox_personalniDoktorAnonimniKorisnik.Background = Brushes.IndianRed; return;
                }


                if (comboBox_personalniEkonomistaAnonimniKorisnik.SelectedIndex == -1)
                {
                    MessageBox.Show("Molimo vas izaberite jednu od ponuđenih opcija!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    comboBox_personalniEkonomistaAnonimniKorisnik.Background = Brushes.IndianRed; return;
                }


                if (comboBox_personalniPravnikAnonimniKorisnik.SelectedIndex == -1)
                {
                    MessageBox.Show("Molimo vas izaberite jednu od ponuđenih opcija!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    comboBox_personalniPravnikAnonimniKorisnik.Background = Brushes.IndianRed; return;
                }


                if (comboBox_personalniPsihologAnonimniKorisnik.SelectedIndex == -1)
                {
                    MessageBox.Show("Molimo vas izaberite jednu od ponuđenih opcija!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    comboBox_personalniPsihologAnonimniKorisnik.Background = Brushes.IndianRed; return;
                }

            }
            else if (radioButton_djelomicnoAnoniman.IsChecked == true && (comboBox_personalniDoktor.SelectedIndex == -1 || comboBox_personalniPsiholog.SelectedIndex == -1))
            {
                if (comboBox_personalniDoktor.SelectedIndex == -1)
                {
                    MessageBox.Show("Molimo vas izaberite jednu od ponuđenih opcija!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    comboBox_personalniDoktor.Background = Brushes.IndianRed; return;
                }


                if (comboBox_personalniPsiholog.SelectedIndex == -1)
                {
                    MessageBox.Show("Molimo vas izaberite jednu od ponuđenih opcija!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    comboBox_personalniPsiholog.Background = Brushes.IndianRed; return;
                }


            }
            else
            {

                //Lokacija lok = new Lokacija(comboBox_lokacijaKorisnika.Text);

                //djelimicnoAnonimanKorisnik k = new djelimicnoAnonimanKorisnik(textBox_imeKorisnika.Text, textBox_prezimeKorisnika.Text, dateTimePicker_datRodjenjaKorisnika.SelectedDate.Value.Date, textBox_usernameKorisnika.Text, textBox_passwordKorisnika.Text, lok, dateTimePicker_datumPrijemaKorisnika.SelectedDate.Value.Date, dateTimePicker_datumOtpustaKorisnika.SelectedDate.Value.Date);






                // dodavanje u comboBox u formi unesene osobe
                string osobe = "";
                foreach (string s in comboBox_dodaneOsobe.Items)
                    osobe += (s + " ");

                bool anoniman = false;
                if (radioButton_potpunoAnoniman.IsChecked == true) anoniman = true;

                var adres = comboBox_lokacijaKorisnika.Text;



                // dodavanje korisnika

                AdminFormaKontroler.RegistrujKorisnika(textBox_imeKorisnika.Text, textBox_prezimeKorisnika.Text, textBox_usernameKorisnika.Text, textBox_passwordKorisnika.Text, adres,
                    dateTimePicker_datRodjenjaKorisnika.SelectedDate.Value, anoniman, osobe, dateTimePicker_datumPrijemaKorisnika.SelectedDate.Value);


                if (radioButton_djelomicnoAnoniman.IsChecked == true)
                // dodavanje kartona i statusa za djelomicno anonimnog
                {

                    // PROMJENITI OVDJE DA PRETRAZUJE PO USERU TJ PO SELEKTOVANOM IMENU
                    var iipDok = comboBox_personalniDoktor.Text;
                    var iipPsih = comboBox_personalniPsiholog.Text;

                    string[] iDok = iipDok.Split(' ');
                    string[] iPsih = iipPsih.Split(' ');

                    // krajnje ime i prezime selektovanog doktora i psihologa
                    string dokI = iDok[0], dokP = iDok[1];
                    string psiI = iPsih[0], psiP = iPsih[1];



                    AdminFormaKontroler.dodajOstaloDA(dokI, dokP, psiI, psiP, textBox_usernameKorisnika.Text);//kreira karton, status, raspored                   


                    MessageBox.Show("Uspješno ste registrovali novog korisnika!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                // dodavanje kartona i statusa za anonimnog korisnika
                if (radioButton_potpunoAnoniman.IsChecked == true)
                {

                    var iipDok = comboBox_personalniDoktorAnonimniKorisnik.Text;
                    var iipPsih = comboBox_personalniPsihologAnonimniKorisnik.Text;
                    var iipEk = comboBox_personalniEkonomistaAnonimniKorisnik.Text;
                    var iipPr = comboBox_personalniPravnikAnonimniKorisnik.Text;

                    string[] iDok = iipDok.Split(' ');
                    string[] iPsih = iipPsih.Split(' ');
                    string[] iEk = iipEk.Split(' ');
                    string[] iPr = iipPr.Split(' ');

                    string dokI = iDok[0], dokP = iDok[1];
                    string psiI = iPsih[0], psiP = iPsih[1];
                    string ekI = iEk[0], ekP = iEk[1];
                    string prI = iPr[0], prP = iPr[1];

                    AdminFormaKontroler.dodajOstaloPA(dokI, dokP, psiI, psiP, ekI, ekP, prI, prP, textBox_usernameKorisnika.Text);



                    MessageBox.Show("Uspješno ste registrovali novog korisnika!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                comboBox_lokacijaKorisnika.Items.Clear();
                var lokacije = AdminFormaKontroler.DajSlobodneLokacije();
                foreach (var a in lokacije)
                    comboBox_lokacijaKorisnika.Items.Add(a.Adresa);

            }
        }
            
        



        private void button_addOsobe_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_dodajOsobu.Text != "") comboBox_dodaneOsobe.Items.Add(textBox_dodajOsobu.Text);
            textBox_dodajOsobu.Text = "";

        }

       
        private void radioButton_djelomicnoAnoniman_Checked(object sender, RoutedEventArgs e)
        {
            string user = textBox_usernameKorisnika.Text;

            string ime = textBox_imeKorisnika.Text;
            string prez = textBox_prezimeKorisnika.Text;

            if (user.Length==0) { errorProvider2.Content = "Unesite username!"; return; }
            else if (ime.Length == 0) { errorProvider2.Content = "Unesite ime korisnika!"; return; }
            else if (prez.Length == 0) { errorProvider2.Content = "Unesite prezime korisnika!"; return; }
            else if (comboBox_lokacijaKorisnika.SelectedIndex == -1) { errorProvider2.Content = "Molimo Vas izaberite neku od lokacija"; return; }
                
            else if (user[0] != ime[0] || user[1] != prez[0])
            {
                if (user[0] != ime[0]) { errorProvider2.Content = "Prvo slovo username-a mora biti isto kao prvo slovo imena"; return; }
                

                if (user[1] != ime[1]) { errorProvider2.Content = "Drugo slovo username-a mora biti isto kao prvo slovo prezimena"; return; }
                
            }
          
            else errorProvider2.Content = "";

            groupBox_anonimniKorisnik.Visibility = Visibility.Hidden;
            groupBox_djelomicnoAnonimniKorisnik.Visibility = Visibility.Visible;


            // u pozadini
            comboBox_personalniDoktor.Items.Clear();
            comboBox_personalniPsiholog.Items.Clear();
            var doktori = AdminFormaKontroler.DajRadnike(0);

            foreach (var a in doktori)
                comboBox_personalniDoktor.Items.Add(a.Ime + " " + a.Prezime);

            var psih = AdminFormaKontroler.DajRadnike(1); 
            foreach (var p in psih)
                comboBox_personalniPsiholog.Items.Add(p.Ime + " " + p.Prezime);

            
        }

        private void radioButton_potpunoAnoniman_Checked(object sender, RoutedEventArgs e)
        {
            string user = textBox_usernameKorisnika.Text;

            string ime = textBox_imeKorisnika.Text;
            string prez = textBox_prezimeKorisnika.Text;

            if (user.Length == 0) { errorProvider2.Content = "Unesite username!"; return; }
            if (ime.Length == 0) { errorProvider2.Content = "Unesite ime korisnika!"; return; }
            if (prez.Length == 0) { errorProvider2.Content = "Unesite prezime korisnika!"; return; }
            if (comboBox_lokacijaKorisnika.SelectedIndex == -1) { errorProvider2.Content = "Molimo Vas izaberite neku od lokacija"; return; }

            if (user[0] != ime[0] || user[1] != prez[0])
            {
                if (user[0] != ime[0]) { errorProvider2.Content = "Prvo slovo username-a mora biti isto kao prvo slovo imena"; return; }
               

                if (user[1] != ime[1]) { errorProvider2.Content = "Drugo slovo username-a mora biti isto kao prvo slovo prezimena"; return; }
                
            }
            
            else errorProvider2.Content = "";

            groupBox_djelomicnoAnonimniKorisnik.Visibility = Visibility.Hidden;
            groupBox_anonimniKorisnik.Visibility = Visibility.Visible;

            // u pozadini
            comboBox_personalniDoktorAnonimniKorisnik.Items.Clear();
            comboBox_personalniEkonomistaAnonimniKorisnik.Items.Clear();
            comboBox_personalniPravnikAnonimniKorisnik.Items.Clear();
            comboBox_personalniPsihologAnonimniKorisnik.Items.Clear();

            

            var doktori = AdminFormaKontroler.DajRadnike(0);
            foreach (var a in doktori)
                comboBox_personalniDoktorAnonimniKorisnik.Items.Add(a.Ime + " " + a.Prezime);

            var psih = AdminFormaKontroler.DajRadnike(1); 
            foreach (var p in psih)
                comboBox_personalniPsihologAnonimniKorisnik.Items.Add(p.Ime + " " + p.Prezime);

            var ek = AdminFormaKontroler.DajRadnike(2);
            foreach (var a in ek)
                comboBox_personalniEkonomistaAnonimniKorisnik.Items.Add(a.Ime + " " + a.Prezime);

            var pr = AdminFormaKontroler.DajRadnike(3);
            foreach (var a in pr)
                comboBox_personalniPravnikAnonimniKorisnik.Items.Add(a.Ime + " " + a.Prezime);

            
        }


       /*  LOG OUT LINK LABEL
        
         private void linkLabel1_LinkClicked(object sender, RoutedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        } */ 


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            comboBox_lokacijaKorisnika.Items.Clear();
            
            try
            {
                var lokacije = AdminFormaKontroler.DajSlobodneLokacije();
                foreach (var a in lokacije)
                    comboBox_lokacijaKorisnika.Items.Add(a.Adresa);
            }
            catch (InvalidOperationException)
            { 
            
            }
           
        }

        List<zahtjevi> zahtjevi1;
        public void provjeraBazeZahtjev()
        {
            while (true)
            {
                mydbEntities db = new mydbEntities();//THREAD - NECU DIRATI!!!
                try
                {
                    zahtjevi1 = (from z in db.zahtjevi where (z.Obradjen == null) select z).ToList();
                    tabPage3.Dispatcher.Invoke(new Action(delegate() { tabPage3.Header = "Upravljanje zahtjevima" + ("(" + zahtjevi1.Count + ")"); }));
                }
                catch (ArgumentException)
                { }
                catch (EntityException)
                { }
                catch (InvalidOperationException) { }

                catch (TaskCanceledException) 
                { }
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            //ovo je samo za testiranje threada, pa necu praviti metodu u klasi!
            mydbEntities db = new mydbEntities();
            var korisnik = (from k in db.korisnici where k.ID == 24 select k).Single();
            db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, SifraZahtjeva = 1, DodatniZahtjev = false, OpisZahtjeva = "Zahtjev za medicinsku pomoć" });
            db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, SifraZahtjeva = 2, DodatniZahtjev = false, OpisZahtjeva = "Zahtjev za psiholosku pomoć" });
            db.zahtjevi.Add(new zahtjevi() { Korisnici_ID = korisnik.ID, SifraZahtjeva = 3, DodatniZahtjev = true, OpisZahtjeva = "Zahtjev za dodatnu ekonomsku pomoć" });
            db.SaveChanges();
        }

        private void tabPage3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            listView1.Items.Clear();
            foreach (var z in zahtjevi1)
                listView1.Items.Add(z);   
        }

        private void PrihvatiOvoo(object sender, RoutedEventArgs e)
        {
            
            
            var cb = sender as Button;
            var item = cb.DataContext;
            listView1.SelectedItem = item;
            zahtjevi z = (zahtjevi)listView1.SelectedItems[0];

            AdminFormaKontroler.prihvatiZahtjev(item, z);
            
            if (z.DodatniZahtjev==true)
            {
                dodajTerminProzor dtp = new dodajTerminProzor(z.ID);
                dtp.ShowDialog();
            }
            listView1.Items.Remove(listView1.SelectedItem);

            
            /*   */
            
            
        }

        private void OdbijOvo(object sender, RoutedEventArgs e)
        {
            
            var cb = sender as Button;
            var item = cb.DataContext;
            listView1.SelectedItem = item;
            zahtjevi z = (zahtjevi)listView1.SelectedItems[0];
            AdminFormaKontroler.odbijZahtjev(item, z);
            
            listView1.Items.Remove(listView1.SelectedItem);
         
            
        }

    }


}