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

            if (textbox_imeRadnika.Text.Count() == 0 || textbox_prezimeRadnika.Text.Count() == 0 || textbox_usernameRadnika.Text.Count() == 0 || textbox_passwordRadnika.Text.Count() == 0 || textbox_prezimeRadnika.Text.Any(x => Char.IsDigit(x)) || textbox_imeRadnika.Text.Any(x => Char.IsDigit(x)))
            {
                if (textbox_imeRadnika.Text.Any(x => Char.IsDigit(x))) { errorProvider1.SetError(textbox_imeRadnika, "Ne možete unositi brojeve"); return; }
                else errorProvider1.Clear();

                if (textbox_prezimeRadnika.Text.Any(x => Char.IsDigit(x))) { errorProvider1.SetError(textbox_prezimeRadnika, "Ne možete unositi brojeve"); return; }
                else errorProvider1.Clear();

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
           
            /* 
            else if (combobox_opisPoslaRadnika.SelectedIndex == -1)
            {
                errorProvider1.SetError(combobox_opisPoslaRadnika, "Molimo Vas izaberite opciju"); return;
            }
            else
            {
                errorProvider1.Clear();
            }
            */


            // raspored button, da kreira prazan raspored za svakog zaposlenog, i obavjesti da je uspješno kreirano ??

        }

        
    }
}
