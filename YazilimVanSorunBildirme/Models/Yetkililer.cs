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
    
    public partial class Yetkililer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yetkililer()
        {
            this.Basvuru = new HashSet<Basvuru>();
            this.Birim_Yetkili = new HashSet<Birim_Yetkili>();
            this.Kurum_Yetkili = new HashSet<Kurum_Yetkili>();
        }
    
        public int yetkili_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string unvan { get; set; }
        public string e_posta { get; set; }
        public string telefon { get; set; }
        public string sifre { get; set; }
        public Nullable<bool> is_admin { get; set; }
        public bool is_active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basvuru> Basvuru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Birim_Yetkili> Birim_Yetkili { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kurum_Yetkili> Kurum_Yetkili { get; set; }
    }
}
