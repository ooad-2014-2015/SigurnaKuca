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
            db.radnici.Add(new radnici() { Ime = textbox_imeRadnika.Text, Prezime = textbox_prezimeRadnika.Text, Username = textbox_usernameRadnika.Text, Password = textbox_passwordRadnika.Text, Opis = combobox_opisPoslaRadnika.SelectedIndex, DatumRodjenja = dateTimePicker1.Value.Date });
            
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
            /*db.lokacije.Add(new lokacije() { Adresa = "Brcanska 13" });
            db.lokacije.Add(new lokacije() { Adresa = "Muftije Dzabijca 12" });
            db.lokacije.Add(new lokacije() { Adresa = "Ferde Haupmana 6" });
            db.lokacije.Add(new lokacije() { Adresa = "Titova 133" });
            db.lokacije.Add(new lokacije() { Adresa = "Ferhadija 18" });
            db.lokacije.Add(new lokacije() { Adresa = "Vrbovska 183" });
            db.lokacije.Add(new lokacije() { Adresa = "Dzemala Bijedica 18" });
            db.lokacije.Add(new lokacije() { Adresa = "Bulevar Mese Selimovica 188" });
            db.SaveChanges(); */


        }

        // validacija username-a, mora počinjati sa prvim slovom opisa posla!
        private void textbox_usernameRadnika_TextChanged(object sender, EventArgs e)
        {
            string priv = Convert.ToString(textbox_usernameRadnika.Text);
            if (priv == "") errorProvider1.Clear();

            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 0 && priv[0] != 'd')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 1 && priv[0] != 'p' && priv[1]!='s')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 2 && priv[0] != 'e')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 3 && priv[0] != 'p' && priv[1]!='r')
            {
                errorProvider1.SetError(textbox_usernameRadnika, "Ovaj username nije validan!");
            }
        }

        // validacija šifre, mora počinjati sa prvim slovom opisa posla!
        private void textbox_passwordRadnika_TextChanged(object sender, EventArgs e)
        {
            string priv = Convert.ToString(textbox_passwordRadnika.Text);
            if (priv == "") errorProvider1.Clear();

            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 0 && priv[0] != 'd')
            {
                errorProvider1.SetError(textbox_passwordRadnika, "Ovaj password nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 1 && priv[0] != 'p' && priv[1] != 's')
            {
                errorProvider1.SetError(textbox_passwordRadnika, "Ovaj password nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 2 && priv[0] != 'e')
            {
                errorProvider1.SetError(textbox_passwordRadnika, "Ovaj password nije validan!");
            }
            if (priv != "" && combobox_opisPoslaRadnika.SelectedIndex == 3 && priv[0] != 'p' && priv[1] != 'r')
            {
                errorProvider1.SetError(textbox_passwordRadnika, "Ovaj password nije validan!");
            }
        }

        private void button_registrujKorisnika_Click(object sender, EventArgs e)
        {
            if ( radioButton_potpunoAnoniman.Checked && (comboBox_personalniDoktorAnonimniKorisnik.SelectedIndex == -1 || comboBox_personalniEkonomistaAnonimniKorisnik.SelectedIndex == -1 || comboBox_personalniPravnikAnonimniKorisnik.SelectedIndex == -1 || comboBox_personalniPsihologAnonimniKorisnik.SelectedIndex == -1))
            {
                if (comboBox_personalniDoktorAnonimniKorisnik.SelectedIndex == -1) { errorProvider1.SetError(comboBox_personalniDoktorAnonimniKorisnik, "Molimo Vas izaberite podatak"); return; }
                else errorProvider1.Clear();

                if (comboBox_personalniEkonomistaAnonimniKorisnik.SelectedIndex == -1) { errorProvider1.SetError(comboBox_personalniEkonomistaAnonimniKorisnik, "Molimo Vas izaberite podatak"); return; }
                else errorProvider1.Clear();

                if (comboBox_personalniPravnikAnonimniKorisnik.SelectedIndex == -1) { errorProvider1.SetError(comboBox_personalniPravnikAnonimniKorisnik, "Molimo Vas izaberite podatak"); return; }
                else errorProvider1.Clear();

                if (comboBox_personalniPsihologAnonimniKorisnik.SelectedIndex == -1) { errorProvider1.SetError(comboBox_personalniPsihologAnonimniKorisnik, "Molimo Vas izaberite podatak"); return; }
                else errorProvider1.Clear();
            }
            else if (radioButton_djelomičnoAnoniman.Checked && (comboBox_personalniDoktor.SelectedIndex == -1 || comboBox_personalniPsiholog.SelectedIndex == -1))
            {
                if (comboBox_personalniDoktor.SelectedIndex == -1) { errorProvider1.SetError(comboBox_personalniDoktor, "Molimo Vas izaberite podatak"); return; }
                else errorProvider1.Clear();

                if (comboBox_personalniPsiholog.SelectedIndex == -1) { errorProvider1.SetError(comboBox_personalniPsiholog, "Molimo Vas izaberite podatak"); return; }
                else errorProvider1.Clear();

            }
            else
            {
                errorProvider1.Clear();

                Lokacija lok = new Lokacija(comboBox_lokacijaKorisnika.Text);
                djelimicnoAnonimanKorisnik k = new djelimicnoAnonimanKorisnik(textBox_imeKorisnika.Text, textBox_prezimeKorisnika.Text, dateTimePicker_datRodjenjaKorisnika.Value, textBox_usernameKorisnika.Text, textBox_passwordKorisnika.Text, lok, dateTimePicker_datumPrijemaKorisnika.Value, dateTimePicker_datumOtpustaKorisnika.Value);


                // ZA BAZU Podataka
         
                mydbEntities db = new mydbEntities();
                  
                // dodavanje u comboBox u formi unesene osobe
                string osobe = "";
                foreach (string s in comboBox_dodaneOsobe.Items)
                    osobe += (s + " ");

                bool anoniman = false;
                if (radioButton_potpunoAnoniman.Checked) anoniman = true;

                object adres = comboBox_lokacijaKorisnika.SelectedItem;
                string a = adres.ToString();
                var lokacija = (from l in db.lokacije where l.Adresa == a select l).Single();

                // dodavanje korisnika
                db.korisnici.Add(new korisnici() { Ime = textBox_imeKorisnika.Text, Prezime = textBox_prezimeKorisnika.Text, Username = textBox_usernameKorisnika.Text, Password = textBox_passwordKorisnika.Text, Lokacija_ID = lokacija.ID, DatumRodjenja = dateTimePicker_datRodjenjaKorisnika.Value.Date, Anonimnost=anoniman, DodatneOsobe=osobe });

                // promjena u odabranoj lokaciji da je zauzeta
                lokacija.Zauzeta = true;
                
                db.SaveChanges();

                // pretraga tog dodanog korisnika
                var korisnik = (from kor in db.korisnici where kor.Username == textBox_usernameKorisnika.Text select kor).Single();

                if (radioButton_djelomičnoAnoniman.Checked)
                // dodavanje kartona i statusa za djelomicno anonimnog
                {
                    // PROMJENITI OVDJE DA PRETRAZUJE PO USERU TJ PO SELEKTOVANOM IMENU
                    int indexDok = comboBox_personalniDoktor.SelectedIndex+1;
                    int indexPsih = comboBox_personalniPsiholog.SelectedIndex+1;

                    var dok = (from d in db.radnici where d.ID == indexDok  select d).Single();
                    var psih = (from p in db.radnici where p.ID == indexPsih select p).Single();

                    // kreiranje kartona za korisnika
                    db.kartoni.Add(new kartoni() { ID_D = dok.ID, ID_Ps = psih.ID});
                    
                    // kreiranje statusa
                    db.status_d.Add(new status_d() { ID_K = korisnik.ID, ID_R = dok.ID });
                    db.status_ps.Add(new status_ps() { ID_K = korisnik.ID, ID_R = psih.ID });

                    // kreiranje terina za raspored
                    db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = dok.ID });
                    db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = psih.ID });

                    db.SaveChanges();
                }
                // dodavanje kartona i statusa za anonimnog korisnika
                if (radioButton_potpunoAnoniman.Checked)
                {
                    // PROMJENITI OVDJE DA PRETRAZUJE PO USERU TJ PO SELEKTOVANOM IMENU
                    int indexDok = comboBox_personalniDoktorAnonimniKorisnik.SelectedIndex + 1;
                    int indexPsih = comboBox_personalniPsihologAnonimniKorisnik.SelectedIndex + 1;
                    int indexEk = comboBox_personalniEkonomistaAnonimniKorisnik.SelectedIndex + 1;
                    int indexPr = comboBox_personalniPravnikAnonimniKorisnik.SelectedIndex + 1;

                    var dok = (from d in db.radnici where d.ID == indexDok select d).Single();
                    var psih = (from p in db.radnici where p.ID == indexPsih select p).Single();
                    var ek = (from eko in db.radnici where eko.ID == indexEk select eko).Single();
                    var pr = (from pre in db.radnici where pre.ID == indexPr select pre).Single();

                    // kreiranje kartona za korisnika
                    db.kartoni.Add(new kartoni() { ID_D=dok.ID, ID_E=ek.ID, ID_Pr=pr.ID, ID_Ps = psih.ID });
                    
                    // kreiranje statusa za korisnika
                    db.status_d.Add(new status_d() { ID_K = korisnik.ID, ID_R = dok.ID });
                    db.status_ps.Add(new status_ps() { ID_K = korisnik.ID, ID_R = psih.ID });
                    db.status_e.Add(new status_e() { ID_K = korisnik.ID, ID_R = ek.ID });
                    db.status_pr.Add(new status_pr() { ID_K = korisnik.ID, ID_R = pr.ID });

                    // kreiranje termina za raspored
                    db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = dok.ID });
                    db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = psih.ID });
                    db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = ek.ID });
                    db.rasporedi.Add(new rasporedi() { ID_K = korisnik.ID, ID_R = pr.ID });
                    db.SaveChanges();
                }

                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Done", "Uspješno ste registrovali novog korisnika.", ToolTipIcon.Info);
            }
        }

        
        private void radioButton_djelomičnoAnoniman_CheckedChanged(object sender, EventArgs e)
        {
            string user=textBox_usernameKorisnika.Text;
            
            string ime=textBox_imeKorisnika.Text;
            string prez=textBox_prezimeKorisnika.Text;

            if (user[0] != ime[0] || user[1] != prez[0])
            {
                if(user[0]!=ime[0]) { errorProvider1.SetError(textBox_usernameKorisnika, "Prvo slovo username-a mora biti isto kao prvo slovo imena"); return; }
                else errorProvider1.Clear();

                if (user[1] != ime[1]) { errorProvider1.SetError(textBox_usernameKorisnika, "Drugo slovo username-a mora biti isto kao prvo slovo prezimena"); return; }
                else errorProvider1.Clear();
            }
            else if (textBox_imeKorisnika.Text.Count() == 0 || textBox_prezimeKorisnika.Text.Count() == 0 || textBox_usernameKorisnika.Text.Count() == 0 || textBox_passwordKorisnika.Text.Count() == 0)
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

            }
            else errorProvider1.Clear();

            groupBox_anonimniKorisnik.Visible = false;
            groupBox_djelomičnoAnonimniKorisnik.Visible = true;

            
            // u pozadini
            comboBox_personalniDoktor.Items.Clear();
            comboBox_personalniPsiholog.Items.Clear();
            mydbEntities db = new mydbEntities();
            var doktori = (from d in db.radnici where d.Opis == 0 select d).ToArray();

            foreach (var a in doktori)
                comboBox_personalniDoktor.Items.Add(a.Ime + " " + a.Prezime);

            var psih = (from d in db.radnici where d.Opis == 1 select d).ToArray();
            foreach (var p in psih)
                comboBox_personalniPsiholog.Items.Add(p.Ime + " " + p.Prezime);

            db.SaveChanges();

        }

        private void button_addOsobe_Click(object sender, EventArgs e)
        {
            if (textBox_dodajOsobu.Text != "") comboBox_dodaneOsobe.Items.Add(textBox_dodajOsobu.Text);
            textBox_dodajOsobu.Text = "";

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            mydbEntities db = new mydbEntities();
            
            var lokacije = (from l in db.lokacije where l.Zauzeta == null select l).ToArray();

            foreach (var a in lokacije)
                comboBox_lokacijaKorisnika.Items.Add(a.Adresa);

        }

        private void radioButton_potpunoAnoniman_CheckedChanged(object sender, EventArgs e)
        {
            string user = textBox_usernameKorisnika.Text;

            string ime = textBox_imeKorisnika.Text;
            string prez = textBox_prezimeKorisnika.Text;

            if (user[0] != ime[0] || user[1] != prez[0])
            {
                if (user[0] != ime[0]) { errorProvider1.SetError(textBox_usernameKorisnika, "Prvo slovo username-a mora biti isto kao prvo slovo imena"); return; }
                else errorProvider1.Clear();

                if (user[1] != ime[1]) { errorProvider1.SetError(textBox_usernameKorisnika, "Drugo slovo username-a mora biti isto kao prvo slovo prezimena"); return; }
                else errorProvider1.Clear();
            }
            else if (textBox_imeKorisnika.Text.Count() == 0 || textBox_prezimeKorisnika.Text.Count() == 0 || textBox_usernameKorisnika.Text.Count() == 0 || textBox_passwordKorisnika.Text.Count() == 0)
            {
                radioButton_potpunoAnoniman.Checked = false;

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
            }
            else errorProvider1.Clear();

            groupBox_djelomičnoAnonimniKorisnik.Visible = false;
            groupBox_anonimniKorisnik.Visible = true;

            // u pozadini
            comboBox_personalniDoktorAnonimniKorisnik.Items.Clear();
            comboBox_personalniEkonomistaAnonimniKorisnik.Items.Clear();
            comboBox_personalniPravnikAnonimniKorisnik.Items.Clear();
            comboBox_personalniPsihologAnonimniKorisnik.Items.Clear();
            mydbEntities db = new mydbEntities();
            
            var doktori = (from d in db.radnici where d.Opis == 0 select d).ToArray();
            foreach (var a in doktori)
                comboBox_personalniDoktorAnonimniKorisnik.Items.Add(a.Ime + " " + a.Prezime);

            var psih = (from d in db.radnici where d.Opis == 1 select d).ToArray();
            foreach (var p in psih)
                comboBox_personalniPsihologAnonimniKorisnik.Items.Add(p.Ime + " " + p.Prezime);

            var ek = (from eko in db.radnici where eko.Opis == 2 select eko).ToArray();
            foreach (var a in ek)
                comboBox_personalniEkonomistaAnonimniKorisnik.Items.Add(a.Ime + " " + a.Prezime);

            var pr = (from p in db.radnici where p.Opis == 3 select p).ToArray();
            foreach (var a in pr)
                comboBox_personalniPravnikAnonimniKorisnik.Items.Add(a.Ime + " " + a.Prezime);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

    }
}
