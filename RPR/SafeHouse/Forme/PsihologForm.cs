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
    public partial class PsihologForm : Form
    {
        public PsihologForm()
        {
            InitializeComponent();
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

        private void PsihologForm_Load(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var psih = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniPsiholog select d).Single();

            label_imePsiholog.Text = psih.Ime;
            label_prezimePsiholog.Text = psih.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_D == psih.ID select kar.ID).ToArray();

            // dodavanje u listBox
            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaPacijenataPsiholog.Items.Add(koris.Ime + " " + koris.Prezime + "\n");
            }
        }

        private void listBox_listaPacijenataPsiholog_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string pomocna = listBox_listaPacijenataPsiholog.SelectedItem.ToString();
            string[] ime = pomocna.Split(' ');

            var korisnik = (from kor in db.korisnici where kor.Prezime == ime[2] select kor).Single();
            var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
            var korisnikStatusDoktor = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox_napredakTerapijePsiholog.Text = korisnikStatus.Historija;
            richTextBox_licneBiljeskePsiholog.Text = korisnikStatus.LicniUtisak;
            richTextBox_nalaziSistematskogPsiholog.Text = korisnikStatusDoktor.Historija;
        }

        private void button_azurirajPodatkePsiholog_Click(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string nalazi = richTextBox_novaDijagnozaPsiholog.Text;

            string pomocna = listBox_listaPacijenataPsiholog.SelectedItem.ToString();
            string[] ime = pomocna.Split(' ');

            var korisnik = (from kor in db.korisnici where kor.Prezime == ime[2] select kor).Single();
            var korisnikStatus = (from stat in db.status_ps where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.Dijagnoza = nalazi;
            korisnikStatus.Historija += nalazi;

            db.SaveChanges();
            richTextBox_novaDijagnozaPsiholog.Text = "";
        }


    }
}
