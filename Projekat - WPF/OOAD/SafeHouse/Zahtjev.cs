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
        private String opisZahtjeva;
        public bool  Obradjen {get; set; }
        public bool Seen { get; set; }
        private bool dodatni;
        public int sifraZahtjeva { get; set; }

        //konstruktor
        public Zahtjev(int i, String oz, bool dodat)
        {
            ID=i;

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
