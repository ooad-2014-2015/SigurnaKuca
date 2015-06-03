using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
    public class Administrator : Osoba
    {
        string username_admin;
        string password_admin;

        public Administrator(string ime, string prezime, DateTime datumRodj, string username_a="admin", string password_a="adminadmin", int ID=0) : base(ime, prezime, datumRodj, username_a, password_a, ID)
        {
            this.username_admin = username_a;
            this.password_admin = password_a;
        }


    }
}
