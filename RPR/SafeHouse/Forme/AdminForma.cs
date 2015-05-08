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
    public partial class AdminForma : Form
    {
        sigurnaKuca sk = new sigurnaKuca();

        public AdminForma()
        {
            InitializeComponent();
        }

        private void combobox_opisPoslaRadnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_opisPoslaRadnika.SelectedIndex != -1) groupBox_dodjelaPristupa.Visible = true;
        }

        private void registracija_radnika_Click(object sender, EventArgs e)
        {
            // validacija pri regisraciji
            if (textbox_imeRadnika.Text.Any(x => Char.IsDigit(x))) { errorProvider1.SetError(textbox_imeRadnika, "Ne možete unositi brojeve"); return; }
            else errorProvider1.Clear();

            if (textbox_prezimeRadnika.Text.Any(x => Char.IsDigit(x))) { errorProvider1.SetError(textbox_prezimeRadnika, "Ne možete unositi brojeve"); return; }
            else errorProvider1.Clear();

            if (textbox_imeRadnika.Text.Count() == 0 || textbox_prezimeRadnika.Text.Count() == 0 || textbox_usernameRadnika.Text.Count() == 0 || textbox_passwordRadnika.Text.Count() == 0 || textbox_prezimeRadnika.Text.Any(x => Char.IsDigit(x)) || textbox_imeRadnika.Text.Any(x => Char.IsDigit(x)))
            {
                if (textbox_imeRadnika.Text.Count() == 0) { errorProvider1.SetError(textbox_imeRadnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (textbox_prezimeRadnika.Text.Count() == 0) { errorProvider1.SetError(textbox_prezimeRadnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (textbox_usernameRadnika.Text.Count() == 0) { errorProvider1.SetError(textbox_usernameRadnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (textbox_passwordRadnika.Text.Count() == 0) { errorProvider1.SetError(textbox_passwordRadnika, "Molimo Vas unesite podatak"); return; }


                // ????? if(combobox_opisPoslaRadnika.Text==String.Empty) { errorProvider1.SetError(combobox_opisPoslaRadnika, "Molimo Vas izaberite opciju"); return; }
            }
            else { errorProvider1.Clear(); }


            // unos radnika u bazu
            mydbEntities db = new mydbEntities();
            db.radnici.Add(new radnici() { Ime = textbox_imeRadnika.Text, Prezime = textbox_prezimeRadnika.Text, Username = textbox_usernameRadnika.Text, Password = textbox_passwordRadnika.Text, Opis = combobox_opisPoslaRadnika.SelectedIndex });
            db.SaveChanges();

            // dodavanje u liste odgovarajućih zaposlenih sa osnovnim podacima

            if (combobox_opisPoslaRadnika.SelectedIndex == 0)
            {
                Doktor d = new Doktor(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.Value,textbox_usernameRadnika.Text, textbox_passwordRadnika.Text);
                sk.dodajDoktora(d);

                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Done", "Uspješno ste registrovali novog doktora.", ToolTipIcon.Info);
            }

            if (combobox_opisPoslaRadnika.SelectedIndex == 1)
            {
                Psiholog p = new Psiholog(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.Value, textbox_usernameRadnika.Text, textbox_passwordRadnika.Text);
                sk.dodajPsihologa(p);

                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Done", "Uspješno ste registrovali novog psihologa.", ToolTipIcon.Info);
            }

            if (combobox_opisPoslaRadnika.SelectedIndex == 2)
            {
                Ekonomista ek = new Ekonomista(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.Value, textbox_usernameRadnika.Text, textbox_passwordRadnika.Text);
                sk.dodajEkonomistu(ek);

                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Done", "Uspješno ste registrovali novog ekonomistu.", ToolTipIcon.Info);
            }

            if (combobox_opisPoslaRadnika.SelectedIndex == 3)
            {
                Pravnik p = new Pravnik(textbox_imeRadnika.Text, textbox_prezimeRadnika.Text, dateTimePicker1.Value, textbox_usernameRadnika.Text, textbox_passwordRadnika.Text);
                sk.dodajPravnika(p);

                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Done", "Uspješno ste registrovali novog pravnika.", ToolTipIcon.Info);
            }
           
          
            // fali raspored button, da kreira prazan raspored za svakog zaposlenog, i obavjesti da je uspješno kreirano ??

        }

        // validacija username-a, mora počinjati sa prvim slovom opisa posla!
        private void textbox_usernameRadnika_TextChanged(object sender, EventArgs e)
        {
            string priv = Convert.ToString(textbox_usernameRadnika.Text);
            if (priv == "") errorProvider1.Clear();

            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 0 && priv[0] != 'D' && priv[0] != 'd')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 1 && priv[0] != 'P' && priv[0] != 'p')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 2 && priv[0] != 'E' && priv[0] != 'e')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 3 && priv[0] != 'P' && priv[0] != 'p')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
        }

        // validacija šifre, mora počinjati sa prvim slovom opisa posla!
        private void textbox_passwordRadnika_TextChanged(object sender, EventArgs e)
        {
            string priv = Convert.ToString(textbox_usernameRadnika.Text);
            if (priv == "") errorProvider1.Clear();

            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 0 && priv[0] != 'D' && priv[0] != 'd')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 1 && priv[0] != 'P' && priv[0] != 'p')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 2 && priv[0] != 'E' && priv[0] != 'e')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 3 && priv[0] != 'P' && priv[0] != 'p')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
        }

        private void button_registrujKorisnika_Click(object sender, EventArgs e)
        {

            Lokacija lok = new Lokacija(comboBox_lokacijaKorisnika.Text);
            djelimicnoAnonimanKorisnik k = new djelimicnoAnonimanKorisnik(textBox_imeKorisnika.Text, textBox_prezimeKorisnika.Text, dateTimePicker_datRodjenjaKorisnika.Value, textBox_usernameKorisnika.Text, textBox_passwordKorisnika.Text, lok, dateTimePicker_datumPrijemaKorisnika.Value, dateTimePicker_datumOtpustaKorisnika.Value);


            // ZA BAZU Podataka
            // KAD se doda atribut u lokaciju da li je zauzeta da se to promjeni
                /* mydbEntities db = new mydbEntities();
                var lokacija = (from l in db.lokacije where l.ID==comboBox_lokacijaKorisnika.SelectedIndex select l).Single();
                lokacija.Cekiran = true;  
                 */

            string osobe="";
            foreach (string s in comboBox_dodaneOsobe.Items)
                osobe += s;

            mydbEntities db = new mydbEntities();
            db.korisnici.Add(new korisnici() { Ime = textBox_imeKorisnika.Text, Prezime = textBox_prezimeKorisnika.Text, Username = textBox_usernameKorisnika.Text, Password = textBox_passwordKorisnika.Text, Lokacija_ID=comboBox_lokacijaKorisnika.SelectedIndex});  // promjeniti ovo LOKACIJA_ID kad se ubaci da li je slobodna 
            db.SaveChanges();



        }

        
        private void radioButton_djelomičnoAnoniman_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_imeKorisnika.Text.Count() == 0 || textBox_prezimeKorisnika.Text.Count() == 0 || textBox_usernameKorisnika.Text.Count() == 0 || textBox_passwordKorisnika.Text.Count() == 0)
            {
                radioButton_djelomičnoAnoniman.Checked = false;


                if (textBox_imeKorisnika.Text.Count() == 0) { errorProvider1.SetError(textBox_imeKorisnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (textBox_prezimeKorisnika.Text.Count() == 0) { errorProvider1.SetError(textBox_prezimeKorisnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (textBox_usernameKorisnika.Text.Count() == 0) { errorProvider1.SetError(textBox_usernameKorisnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (textBox_passwordKorisnika.Text.Count() == 0) { errorProvider1.SetError(textBox_passwordKorisnika, "Molimo Vas unesite podatak"); return; }
                else errorProvider1.Clear();

                if (comboBox_lokacijaKorisnika.SelectedIndex == -1) { errorProvider1.SetError(comboBox_lokacijaKorisnika, "Molimo Vas unesite podatak"); return; }
                 else errorProvider1.Clear();

                groupBox2.Visible = true;


                // u pozadini
                mydbEntities db = new mydbEntities();
                var doktori = (from d in db.radnici where d.Opis == 0 select d).ToArray();

                foreach (var a in doktori)
                    comboBox_personalniDoktor.Items.Add(a.Ime + " " + a.Prezime);

                var psih = (from d in db.radnici where d.Opis == 1 select d).ToArray();
                foreach (var p in psih)
                    comboBox_personalniPsiholog.Items.Add(p.Ime + " " + p.Prezime);

                db.SaveChanges();

            }
            else errorProvider1.Clear();

            groupBox2.Visible = true;
        }

        private void button_addOsobe_Click(object sender, EventArgs e)
        {
            if (textBox_dodajOsobu.Text != "") comboBox_dodaneOsobe.Items.Add(textBox_dodajOsobu.Text);
            textBox_dodajOsobu.Text = "";

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            var lokacije = (from l in db.lokacije select l).ToArray();  //kasnije: dodati provjeru da li je zauzeta

            foreach (var a in lokacije)
                comboBox_lokacijaKorisnika.Items.Add(a.Adresa);
        }

        

       

       
    }
}
