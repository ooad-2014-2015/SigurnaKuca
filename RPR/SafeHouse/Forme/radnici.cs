//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forme
{
    using System;
    using System.Collections.Generic;
    
    public partial class radnici
    {
        public radnici()
        {
            this.kartoni = new HashSet<kartoni>();
            this.kartoni1 = new HashSet<kartoni>();
            this.kartoni2 = new HashSet<kartoni>();
            this.kartoni3 = new HashSet<kartoni>();
            this.rasporedi = new HashSet<rasporedi>();
            this.status_d = new HashSet<status_d>();
            this.status_e = new HashSet<status_e>();
            this.status_pr = new HashSet<status_pr>();
            this.status_ps = new HashSet<status_ps>();
        }
    
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> Opis { get; set; }
    
        public virtual ICollection<kartoni> kartoni { get; set; }
        public virtual ICollection<kartoni> kartoni1 { get; set; }
        public virtual ICollection<kartoni> kartoni2 { get; set; }
        public virtual ICollection<kartoni> kartoni3 { get; set; }
        public virtual ICollection<rasporedi> rasporedi { get; set; }
        public virtual ICollection<status_d> status_d { get; set; }
        public virtual ICollection<status_e> status_e { get; set; }
        public virtual ICollection<status_pr> status_pr { get; set; }
        public virtual ICollection<status_ps> status_ps { get; set; }
    }
}
