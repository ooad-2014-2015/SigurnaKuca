using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class djelimicnoAnonimanKorisnik : Korisnik
    {
        DateTime datumOtpusta;

        //konstruktor
        public djelimicnoAnonimanKorisnik(String i, String p, DateTime datum_rodj, string us, string pass,  Lokacija lok, DateTime dat_prijema, DateTime dat_otpusta, int ID)
            : base(i, p, datum_rodj, us, pass, lok, dat_prijema, ID)
        {
            this.datumOtpusta = dat_otpusta;
        }

        public void OtpustiKorisnika(DateTime d_o)
        {
            
        }
    }
}
