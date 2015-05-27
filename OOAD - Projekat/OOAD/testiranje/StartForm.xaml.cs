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


namespace SafeHouse
{
    public partial class StartForm : Window
    {



        private void username_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (username_textbox.Text != "") errorProvider1.ContentStringFormat = "";

        }

        private void password_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (password_textbox.Password != "") errorProvider1.Content = "";

        }

        private void prijava_button_Click(object sender, RoutedEventArgs e)
        {
            string user = username_textbox.Text;
            string pass = password_textbox.Password;

            if (user == "" && pass == "") { errorProvider1.Content = "Niste unijeli nikakve podatke."; return; }
            // ZA ADMINA
            if ((user == Convert.ToString("admin") && pass != Convert.ToString("admin")) || (pass == Convert.ToString("admin") && user != Convert.ToString("admin")))
            {
                if (user == Convert.ToString("admin") && pass != Convert.ToString("admin")) { errorProvider1.Content = "Šifra nije validna. Pokušajte ponovo!"; return; }
                if (pass == Convert.ToString("admin") && user != Convert.ToString("admin")) { errorProvider1.Content= "Username nije validan. Pokušajte ponovo!"; return; }

            }
            else if (user == Convert.ToString("admin") && pass == Convert.ToString("admin"))
            {
                errorProvider1.Content="";
                AdminForma f = new AdminForma();
                this.Close();
                f.ShowDialog();
            }

            // ZA DOKTORA
            else if (user[0] == 'd')
            {
                string dok = "";
                mydbEntities db = new mydbEntities();

                try
                {
                    dok = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Password).Single();

                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniDoktor = user;
                        String ime = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Ime).Single();
                        String prezime = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Prezime).Single();
                        var dr = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.DatumRodjenja).Single();
                        int id = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.ID).Single();
                        String u = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Username).Single();
                        String p = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Password).Single();
                        (GlobalneVarijable.trenutnaOsoba) = new Doktor(ime, prezime, dr.Value, u, p); 
                        DoktorForm doc = new DoktorForm();
                        doc.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.Content="Pogrešan password, pokušajte ponovo!"; return; }
                }
                catch (InvalidOperationException)
                {
                    errorProvider1.Content="Ne postoji doktor sa unesenim podacima! Pokušajte ponovo.";
                }

            }
            //ZA EKONOMISTU
            else if (user[0] == 'e')
            {
                string dok = "";
                mydbEntities db = new mydbEntities();
                try
                {
                    dok = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniEkonomista = user;
                        String ime = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Ime).Single();
                        String prezime = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Prezime).Single();
                        var dr = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.DatumRodjenja).Single();
                        int id = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.ID).Single();
                        String u = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Username).Single();
                        String p = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Password).Single();
                        (GlobalneVarijable.trenutnaOsoba) = new Ekonomista(ime, prezime, dr.Value, u, p);  
                        EkonomistaForm ek = new EkonomistaForm();
                        ek.ShowDialog();
                        this.Close();

                    }
                    else { errorProvider1.Content = "Pogrešan password, pokušajte ponovo!"; return; }
                }
                catch (InvalidOperationException)
                {
                    errorProvider1.Content="Ne postoji ekonomista sa unesenim podacima! Pokušajte ponovo.";
                }

            }
            // ZA PSIHOLOGA
            else if (user[0] == 'p' && user[1] == 's')
            {
                mydbEntities db = new mydbEntities();
                string dok = "";
                try
                {
                    dok = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniPsiholog = user;
                        String ime = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.Ime).Single();
                        String prezime = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.Prezime).Single();
                        var dr = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.DatumRodjenja).Single();
                        int id = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.ID).Single();
                        String u = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.Username).Single();
                        String p = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.Password).Single();
                        (GlobalneVarijable.trenutnaOsoba) = new Psiholog(ime, prezime, dr.Value, u, p); 
                        PsihologForm psi = new PsihologForm();
                        psi.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.Content = "Pogrešan password, pokušajte ponovo!"; return; }
                }
                catch (InvalidOperationException)
                {
                    errorProvider1.Content="Ne postoji psiholog sa unesenim podacima! Pokušajte ponovo.";
                }

            }
            // ZA PRAVNIKA
            else if (user[0] == 'p' && user[1] == 'r')
            {
                string dok = "";
                mydbEntities db = new mydbEntities();
                try
                {
                    dok = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniPravnik = user;
                        String ime = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.Ime).Single();
                        String prezime = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.Prezime).Single();
                        var dr = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.DatumRodjenja).Single();
                        int id = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.ID).Single();
                        String u = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.Username).Single();
                        String p = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.Password).Single();
                        (GlobalneVarijable.trenutnaOsoba) = new Pravnik(ime, prezime, dr.Value, u, p); 
                        PravnikForm pr = new PravnikForm();
                        pr.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.Content = "Pogrešan password, pokušajte ponovo!"; return; }
                }
                catch (InvalidOperationException)
                {
                    errorProvider1.Content="Ne postoji pravnik sa unesenim podacima! Pokušajte ponovo.";
                }

            }
            else if ((user[0] != 'p' && user[1] != 'r') || (user[0] != 'p' && user[1] != 's') || user[0] != 'd' || user[0] != 'e')
            {

                mydbEntities db = new mydbEntities();
                try
                {
                    string kor = (from k in db.korisnici where (k.Username == user) select k.Password).Single();
                    if (kor == pass)
                    {
                        GlobalneVarijable.TrenutniKorisnik = user;
                        GlobalneVarijable.trenutnaOsoba = new Korisnik();
                        (GlobalneVarijable.trenutnaOsoba as Korisnik).Ime_osobe = (from r in db.korisnici where  r.Username == user select r.Ime).Single();
                        (GlobalneVarijable.trenutnaOsoba as Korisnik).Prezime_osobe = (from r in db.korisnici where  r.Username == user select r.Prezime).Single();
                        (GlobalneVarijable.trenutnaOsoba as Korisnik).ID1 = (from r in db.korisnici where  r.Username == user select r.ID).Single(); 
                        KorisnikForm kf = new KorisnikForm();
                        kf.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.Content = "Pogrešan password, pokušajte ponovo!"; return; }
                }
                catch (InvalidOperationException)
                {
                    errorProvider1.Content="Ne postoji korisnik sa unesenim podacima! Pokušajte ponovo.";
                }

            }
        }




    }
}
