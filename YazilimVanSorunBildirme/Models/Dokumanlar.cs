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
    
    public partial class Dokumanlar
    {
        public int id { get; set; }
        public string dosya_adi { get; set; }
        public string dosya_tipi { get; set; }
        public Nullable<int> dosya_boyutu { get; set; }
        public Nullable<int> basvuru_id { get; set; }
        public bool is_active { get; set; }
    
        public virtual Basvuru Basvuru { get; set; }
    }
}