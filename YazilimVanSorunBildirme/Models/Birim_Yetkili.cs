//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazilimVanSorunBildirme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Birim_Yetkili
    {
        public int birim_yetkili_id { get; set; }
        public Nullable<int> birim_id { get; set; }
        public Nullable<int> yetkili_id { get; set; }
        public bool is_active { get; set; }
    
        public virtual Birim Birim { get; set; }
        public virtual Yetkililer Yetkililer { get; set; }
    }
}
