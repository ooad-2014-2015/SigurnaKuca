using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    //  ٩(̾●̮̮̃̾•̃̾)۶٩(̾●̮̮̃̾•̃̾)۶٩(̾●̮̮̃̾•̃̾)۶٩(̾●̮̮̃̾•̃̾)۶٩(̾●̮̮̃̾•̃̾)۶٩(̾●̮̮̃̾•̃̾)۶
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    public class Termin
    {
        private DateTime datumIVrijeme;
        private Korisnik pacijent;

        //konstruktor
        public Termin(DateTime div, Korisnik pac)
        {
            datumIVrijeme = div;
            pacijent = pac;
            //ili napraviti da konstruktor prima string, nadje korisnika u bazi i dodijeli ga atributu??
        }

        //get-set
        public DateTime DatumIVrijeme
        {
            get { return datumIVrijeme; }
            set { datumIVrijeme = value; }
        }
        public Korisnik Pacijent
        {
            get { return pacijent; }
            set { pacijent = value; }
        }
       

    }
}
