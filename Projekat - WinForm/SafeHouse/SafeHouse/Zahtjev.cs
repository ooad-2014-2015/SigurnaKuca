using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    abstract public class Zahtjev
    {
        //atributi
        private String opisZahtjeva;
        private bool odobren;
        private String prijedlogRjesenja;
        private bool obradjen;

        //konstruktor
        public Zahtjev(String oz)
        {
            opisZahtjeva = oz;
            obradjen = false;
            prijedlogRjesenja = "";
            odobren = false;
        }


        //get-set
        public String OpisZahtjeva
        {
            get { return opisZahtjeva; }
            set { opisZahtjeva = value; }
        }
        public String PrijedlogRjesenja
        {
            get { return prijedlogRjesenja; }
            set { prijedlogRjesenja = value; }
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
        public void PredloziRjesenje(String rZahtjeva)
        {
            prijedlogRjesenja = rZahtjeva;
        }
    }
}
