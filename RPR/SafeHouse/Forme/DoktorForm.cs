﻿using System;
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

            label3.Text = doktor.Ime;
            label4.Text = doktor.Prezime;

            // pronalazak pacijenata za tog doktora
            var karton = (from kar in db.kartoni where kar.ID_D == doktor.ID select kar.ID).ToArray();


            foreach (var k in karton)
            {
                var koris = (from ko in db.korisnici where ko.ID == k select ko).Single();
                listBox_listaPacijenata.Items.Add(koris.Ime + " " + koris.Prezime);
            }
        }

        private void listBox_listaPacijenata_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string pomocna = listBox_listaPacijenata.SelectedItem.ToString();
            string[] ime = pomocna.Split(' ');
            string prezime = ime[1];

            var korisnik = (from kor in db.korisnici where kor.Prezime == prezime select kor).Single();
            var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();

            richTextBox3.Text = korisnikStatus.Historija;
            richTextBox2.Text = korisnikStatus.LicniUtisak;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();

            string nalazi = richTextBox1.Text;

            string pomocna = listBox_listaPacijenata.SelectedItem.ToString();
            string[] ime = pomocna.Split(' ');
            string prezime = ime[1];

            var korisnik = (from kor in db.korisnici where kor.Prezime == prezime select kor).Single();
            var korisnikStatus = (from stat in db.status_d where stat.ID_K == korisnik.ID select stat).Single();
            korisnikStatus.Nalazi = nalazi;
            korisnikStatus.Historija+=nalazi;
            
            db.SaveChanges();
            richTextBox1.Text = "";
        }

       

       
    }
}
