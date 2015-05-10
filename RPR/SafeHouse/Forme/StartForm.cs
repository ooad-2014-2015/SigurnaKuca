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
            if (username_textbox.Text == Convert.ToString("admin") && password_textbox.Text == Convert.ToString("admin"))
            {
                
                AdminForma f = new AdminForma();
                this.Hide();
                f.ShowDialog();
            }

            // ZA DOKTORA
            else if (user[0] == 'D')
            {
                
                try
                {
                    mydbEntities db = new mydbEntities();
                    string dok = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Password).Single();
                    if (dok == pass)
                    {
                        GlobalneVarijable.TrenutniDoktor = user;
                        DoktorForm doc = new DoktorForm();
                        doc.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        errorProvider1.SetError(prijava_button, "Šifra nije validna. Pokušajte ponovo!");
                    }

                    DoktorForm doktor = new DoktorForm();
                    doktor.ShowDialog();
                    this.Hide();
                }
                catch(ArgumentException f)
                {
                   errorProvider1.SetError(prijava_button, "Username ne postoji. Pokušajte ponovo!");
                }
                    
            }
                //ZA EKONOMISTU
            else if (user[0] == 'e')
            {
                mydbEntities db = new mydbEntities();
                string dok = (from r in db.radnici where (r.Opis == 2 && r.Username == user) select r.Password).Single();
                if (dok == pass)
                {
                    GlobalneVarijable.TrenutniEkonomista = user;
                    EkonomistaForm ek = new EkonomistaForm();
                    ek.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    errorProvider1.SetError(prijava_button, "Korisnik ne postoji. Pokušajte ponovo!");
                }
            }
             // ZA PSIHOLOGA
            else if (user[0] == 'p' && user[1] == 's')
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
                else
                {
                    errorProvider1.SetError(prijava_button, "Korisnik ne postoji. Pokušajte ponovo!");
                }
            }
                    // ZA PRAVNIKA
            else if (user[0] == 'p' && user[1] == 'r')
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
                else
                {
                    errorProvider1.SetError(prijava_button, "Korisnik ne postoji. Pokušajte ponovo!");
                }
            }
            else if((user[0]!='p' && user[1]!='r') || (user[0]!='p' && user[1]!='s') || user[0]!='d' || user[0]!='e')
            {

                mydbEntities db = new mydbEntities();
                string kor = (from k in db.korisnici where (k.Username == user) select k.Password).Single();
                if (kor == pass)
                {
                    GlobalneVarijable.TrenutniKorisnik = user;
                    KorisnikForm kf = new KorisnikForm();
                    kf.ShowDialog();
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(username_textbox, "Unesite ispravan username ili password");
                    errorProvider1.SetError(password_textbox, "Unesite ispravan username ili password");
                }

                errorProvider1.SetError(prijava_button, "Korisnik ne postoji. Pokušajte ponovo!");

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
