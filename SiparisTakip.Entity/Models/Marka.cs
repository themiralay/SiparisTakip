namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marka")]
    public partial class Marka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marka()
        {
            Model = new HashSet<Model>();
        }

        public int MarkaID { get; set; }

        [StringLength(50)]
        public string MarkaAdi { get; set; }

        public bool? Aktif { get; set; }

        public DateTime? KayitZamani { get; set; }

        public int? KullaniciID { get; set; }

        public long? N11Kodu { get; set; }

        public int? KategoriID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model> Model { get; set; }
    }
}
