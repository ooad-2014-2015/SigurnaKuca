using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class Zahtjev
    {
        //atributi
        private int id;
        private string iip;

        public string IIP
        {
            get { return iip; }
            set { iip = value; }
        }
        
        private String opisZahtjeva;
        private bool odobren;
        private bool obradjen;
        private bool dodatni;

        //konstruktor
        public Zahtjev(int i, string ip, String oz, bool dodat)
        {
            ID=i;
            IIP = ip;
            opisZahtjeva = oz;
            Dodatni = dodat;
//            obradjen = false;
//            odobren = false;
        }


        //get-set
        public String OpisZahtjeva
        {
            get { return opisZahtjeva; }
            set { opisZahtjeva = value; }
        }
  
        public bool Odobren
        {
            get { return odobren; }
            set { odobren = value; }
        }
        //metode
        public void PostaviOpis(String oZahtjeva)
        {
            opisZahtjeva = oZahtjeva;
        }
       
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public bool Dodatni
        {
            get { return dodatni; }
            set { dodatni = value; }
        }
    }
}
