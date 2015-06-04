using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeHouse
{
    public partial class PravnikForm : Form
    {
        public PravnikForm()
        {
            InitializeComponent();
        }

        private void PravnikForm_Load(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var prav = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniPravnik select d).Single();

            label1.Text = prav.Ime;
            label2.Text = prav.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_Pr == prav.ID select kar.ID).ToArray();

            // dodavanje u listBox
            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaKorisnikaPravnik.Items.Add(koris.ID);
            }
        }

        private void listBox_listaKorisnikaPravnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            int pomocna = Convert.ToInt32(listBox_listaKorisnikaPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox_opisProblemaPravnik.Text = korisnikStatus.OpisProblema;
            richTextBox_licneBiljeskePravnik.Text = korisnikStatus.LicniUtisak;
            richTextBox_historijaRjesenjaPravnik.Text = korisnikStatus.HistorijaRjesenja;
        }

        private void button_azurirajRjesenjePravnik_Click(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string nalazi = richTextBox_prijedlogRjesenja.Text;

            int pomocna = Convert.ToInt32(listBox_listaKorisnikaPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.PrijedlogRjesenja = nalazi;
            korisnikStatus.HistorijaRjesenja += (nalazi+"\n");

            db.SaveChanges();
            richTextBox_prijedlogRjesenja.Text = "";
            richTextBox_historijaRjesenjaPravnik.Text = korisnikStatus.HistorijaRjesenja;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }

        // promjeniti ovu metodu za klik kad se dodaaa :D
        private void richTextBox_opisProblemaPravnik_Validated(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string opisProblema = richTextBox_opisProblemaPravnik.Text;

            int pomocna = Convert.ToInt32(listBox_listaKorisnikaPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.OpisProblema = opisProblema;
            db.SaveChanges();
        }

        private void richTextBox_licneBiljeskePravnik_Validated(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string licniUtisak = richTextBox_licneBiljeskePravnik.Text;

            int pomocna = Convert.ToInt32(listBox_listaKorisnikaPravnik.SelectedItem.ToString());

            var korisnik = (from kor in db.korisnici where kor.ID == pomocna select kor).Single();
            var korisnikStatus = (from stat in db.status_pr where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.LicniUtisak = licniUtisak;
            db.SaveChanges();
        }
    }
}
