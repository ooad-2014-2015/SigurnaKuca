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
    
    public partial class status_pr
    {
        public int ID { get; set; }
        public int ID_K { get; set; }
        public int ID_R { get; set; }
        public string OpisProblema { get; set; }
        public string PrijedlogRjesenja { get; set; }
        public string HistorijaRjesenja { get; set; }
        public string LicniUtisak { get; set; }
    
        public virtual korisnici korisnici { get; set; }
        public virtual radnici radnici { get; set; }
    }
}
