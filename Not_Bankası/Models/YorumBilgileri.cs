//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Not_Bankası.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class YorumBilgileri
    {
        public int Yorum_Id { get; set; }
        public string Yorum { get; set; }
        public int Not_Id { get; set; }
        public Nullable<int> Uye_Id { get; set; }
    
        public virtual NotBilgileri NotBilgileri { get; set; }
        public virtual UyeBilgileri UyeBilgileri { get; set; }
    }
}
