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
    public partial class EkonomistaForm : Form
    {
        public EkonomistaForm()
        {
            InitializeComponent();
        }

        private void EkonomistaForm_Load(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var ekonom = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniEkonomista select d).Single();

            label_imeEkonomiste.Text = ekonom.Ime;
            label_prezimeEkonomiste.Text = ekonom.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_D == ekonom.ID select kar.ID).ToArray();


            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_ListaKorisnikaEkonomist.Items.Add(koris.Ime + " " + koris.Prezime + "\n");
            }
        }

        private void listBox_ListaKorisnikaEkonomist_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string pomocna = listBox_ListaKorisnikaEkonomist.SelectedItem.ToString();
            string[] ime = pomocna.Split(' ');

            var korisnik = (from kor in db.korisnici where kor.Prezime == ime[2] select kor).Single();
            var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox_historijaRješenjaEkonomist.Text = korisnikStatus.Historija;
            richTextBox_licneBiljeskeEkonomist.Text = korisnikStatus.LicniUtisak;
        }

        private void button_azurirajPrijedlogeEkonomist_Click(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string prijedlog = richTextBox_prijedlogRjesenjaEkonomist.Text;

            string pomocna = listBox_ListaKorisnikaEkonomist.SelectedItem.ToString();
            string[] ime = pomocna.Split(' ');

            var korisnik = (from kor in db.korisnici where kor.Prezime == ime[2] select kor).Single();
            var korisnikStatus = (from stat in db.status_e where stat.ID_K == korisnik.ID select stat).Single();
            
            korisnikStatus.PrijedlogRjesenja = prijedlog;
            korisnikStatus.Historija += prijedlog;

            db.SaveChanges();
            richTextBox_prijedlogRjesenjaEkonomist.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

       
    }
}
