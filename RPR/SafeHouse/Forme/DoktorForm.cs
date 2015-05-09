using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forme;

namespace SafeHouse
{
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartForm sf = new StartForm();
            this.Hide();
            sf.ShowDialog();
        }
        
        private void DoktorForm_Load(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            // pronalazak doktora
            var doktor = (from d in db.radnici where d.Username == GlobalneVarijable.TrenutniDoktor select d).Single();

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_D == doktor.ID select kar.ID).ToArray();


            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaPacijenata.Text += (koris.Ime + " " + koris.Prezime + "\n");
            }
        }

       

       
    }
}
