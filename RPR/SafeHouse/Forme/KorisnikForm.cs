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
using SafeHouse;

namespace SafeHouse
{
    public partial class KorisnikForm : Form
    {
        public KorisnikForm()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = e.Url.ToString() + "loaded";
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "Učitavanje..";
        }

        private void Korisnik_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com/");
        }
    }
}
