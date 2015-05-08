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
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            mydbEntities db = new mydbEntities();
            var dok = (from r in db.radnici where (r.Username == GlobalneVarijable.TrenutniDoktor) select r).Single();

            textBoxImeDok.Text = dok.Ime;
            textBoxPrezimeDok.Text = dok.Prezime;
            
        }
    }
}
