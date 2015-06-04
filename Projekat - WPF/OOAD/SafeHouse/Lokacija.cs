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
        
        //konstruktor
        public Lokacija(String a)
        {
            adresa = a;
        }

        //get-set
        public String Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
       
    }    
    
}
