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
            string user=username_textbox.Text;
            string pass=password_textbox.Text;

            if (username_textbox.Text == Convert.ToString("admin") && password_textbox.Text == Convert.ToString("adminadmin"))
            {
                AdminForma f = new AdminForma();
                f.ShowDialog();
            }

            if (user[0]=='d' && user[1]=='o')
            {
                // iz baze podataka naći koji je doktor sa istim userom i passwordom i otvoriti formu 
                DoktorForm doc = new DoktorForm();
                doc.ShowDialog();
            }

        }
    }
}
