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
using Forme;

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
            if (username_textbox.Text == Convert.ToString("admin") && password_textbox.Text == Convert.ToString("adminadmin"))
            {
                AdminForma f = new AdminForma();
                f.ShowDialog();
                this.Close();
            }
            // ZA DOKTORA
            else if (user[0] == 'D' || user[0] == 'd')
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
                    errorProvider1.SetError(username_textbox, "Unesite ispravan username ili password");
                    errorProvider1.SetError(password_textbox, "Unesite ispravan username ili password");
                }
            }
                //ZA EKONOMISTU
            else if (user[0] == 'E' || user[0] == 'e')
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
                    errorProvider1.SetError(username_textbox, "Unesite ispravan username ili password");
                    errorProvider1.SetError(password_textbox, "Unesite ispravan username ili password");
                }
            }
             // ZA PSIHOLOGA
            else if ((user[0] == 'P' || user[0] == 'p') && (user[1] == 'S' || user[0] == 's'))
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
                    errorProvider1.SetError(username_textbox, "Unesite ispravan username ili password");
                    errorProvider1.SetError(password_textbox, "Unesite ispravan username ili password");
                }
            }
                    // ZA PRAVNIKA
            else if ((user[0] == 'P' || user[0] == 'p') && (user[1] == 'R' || user[0] == 'r'))
            {
                mydbEntities db = new mydbEntities();
                string dok = (from r in db.radnici where (r.Opis == 0 && r.Username == user) select r.Password).Single();
                if (dok == pass)
                {
                    GlobalneVarijable.TrenutniPravnik = user;
                    PravnikForm pr = new PravnikForm();
                    pr.ShowDialog();
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(username_textbox, "Unesite ispravan username ili password");
                    errorProvider1.SetError(password_textbox, "Unesite ispravan username ili password");
                }
            }
            else
            {
                errorProvider1.SetError(username_textbox, "Unesite ispravan username ili password");
                errorProvider1.SetError(password_textbox, "Unesite ispravan username ili password");
            }

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(username_textbox) != "") errorProvider1.Clear();
            
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(password_textbox) != "") errorProvider1.Clear();
        }

        
    }
}
