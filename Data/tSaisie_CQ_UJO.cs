//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tSaisie_CQ_UJO
    {
        public int id_saisie_ujo { get; set; }
        public int num_saisie_CQ_ujo { get; set; }
        public string nom_CQ_ujo { get; set; }
        public decimal pds_CQ_ujo { get; set; }
    
        public virtual SaisieChuteCoupeuse SaisieChuteCoupeuse { get; set; }
    }
}