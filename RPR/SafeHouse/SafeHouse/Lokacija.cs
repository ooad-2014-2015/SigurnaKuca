using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    
    public class Lokacija
    {
        private String adresa;
        private String grad;

        //konstruktor
        public Lokacija(String a, String g)
        {
            adresa = a;
            grad = g;
        }

        //get-set
        public String Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public String Grad
        {
            get { return grad; }
            set { grad = value; }
        }


       
    }    
    
}
