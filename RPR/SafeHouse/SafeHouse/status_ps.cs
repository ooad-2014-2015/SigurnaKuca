//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SafeHouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class status_ps
    {
        public int ID { get; set; }
        public int ID_K { get; set; }
        public int ID_R { get; set; }
    
        public virtual korisnici korisnici { get; set; }
        public virtual radnici radnici { get; set; }
    }
}