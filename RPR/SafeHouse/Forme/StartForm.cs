using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeHouse;


namespace SafeHouse
{
    public partial class StartForm : Form
    {
        
        public StartForm()
        {
            InitializeComponent();
        }

        private void prijava_button_Click(object sender, EventArgs e)
        {

            string user = username_textbox.Text;
            string pass = password_textbox.Text;

            
            // ZA ADMINA
            if ((user==Convert.ToString("admin") && pass!=Convert.ToString("admin")) || (pass==Convert.ToString("admin") && user!=Convert.ToString("admin")))
            {
                if (user == Convert.ToString("admin") && pass != Convert.ToString("admin")) { errorProvider1.SetError(password_textbox, "Šifra nije validna. Pokušajte ponovo!"); return; }
                if (pass == Convert.ToString("admin") && user != Convert.ToString("admin")) { errorProvider1.SetError(username_textbox, "Username nije validan. Pokušajte ponovo!"); return; }
                
            }
            else if(user== Convert.ToString("admin") && pass == Convert.ToString("admin"))
            {
                errorProvider1.Clear();
                AdminForma f = new AdminForma();
                this.Hide();
                f.ShowDialog();
            }

            // ZA DOKTORA
            else if (user[0] == 'd')
            {
                    string dok="";
                    mydbEntities db = new mydbEntities();

                    try
                    {
                        dok = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Password).Single();

                        if (dok == pass)
                        {
                            GlobalneVarijable.TrenutniDoktor = user;
                            DoktorForm doc = new DoktorForm();
                            doc.ShowDialog();
                            this.Close();
                        }
                        else { errorProvider1.SetError(password_textbox, "Pogrešan password, pokušajte ponovo!"); return; }
                    }
                    catch (InvalidOperationException)
                    {
                        errorProvider1.SetError(prijava_button, "Ne postoji korisnik! Pokušajte ponovo.");
                    }
                    
            }
                //ZA EKONOMISTU
            else if (user[0] == 'e')
            {
                mydbEntities db = new mydbEntities();
               try
               { 
                    string dok = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniEkonomista = user;
                        EkonomistaForm ek = new EkonomistaForm();
                        ek.ShowDialog();
                        this.Close();
                    
                    }
                    else { errorProvider1.SetError(password_textbox, "Pogrešan password, pokušajte ponovo!"); return; }
               }
               catch (InvalidOperationException)
               {
                  errorProvider1.SetError(prijava_button, "Ne postoji korisnik! Pokušajte ponovo.");
               }
               
            }
             // ZA PSIHOLOGA
            else if (user[0] == 'p' && user[1] == 's')
            {
                try
                {
                    mydbEntities db = new mydbEntities();
                    string dok = (from r in db.radnici where (r.Opis == 1 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniPsiholog = user;
                        PsihologForm psi = new PsihologForm();
                        psi.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.SetError(password_textbox, "Pogrešan password, pokušajte ponovo!"); return; }
                }
               catch (InvalidOperationException)
               {
                  errorProvider1.SetError(prijava_button, "Ne postoji korisnik! Pokušajte ponovo.");
               }
                
            }
                    // ZA PRAVNIKA
            else if (user[0] == 'p' && user[1] == 'r')
            {
                try
                {
                    mydbEntities db = new mydbEntities();
                    string dok = (from r in db.radnici where (r.Opis == 3 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniPravnik = user;
                        PravnikForm pr = new PravnikForm();
                        pr.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.SetError(password_textbox, "Pogrešan password, pokušajte ponovo!"); return; }
                }
                catch (InvalidOperationException)
                {
                    errorProvider1.SetError(prijava_button, "Ne postoji korisnik! Pokušajte ponovo.");
                }
                
            }
            else if((user[0]!='p' && user[1]!='r') || (user[0]!='p' && user[1]!='s') || user[0]!='d' || user[0]!='e')
            {

                mydbEntities db = new mydbEntities();
                try
                {
                    string kor = (from k in db.korisnici where (k.Username == user) select k.Password).Single();
                    if (kor == pass)
                    {
                        GlobalneVarijable.TrenutniKorisnik = user;
                        KorisnikForm kf = new KorisnikForm();
                        kf.ShowDialog();
                        this.Close();
                    }
                    else { errorProvider1.SetError(password_textbox, "Pogrešan password, pokušajte ponovo!");   }
                }
                catch (InvalidOperationException)
                {
                  errorProvider1.SetError(prijava_button, "Ne postoji korisnik sa unesenim podacima! Pokušajte ponovo.");
                }
                
            }

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(username_textbox) == "") errorProvider1.Clear();
            
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(password_textbox) == "") errorProvider1.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KorisnikForm k = new KorisnikForm();
            k.ShowDialog();
            
        }

        
    }
}
