namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sektor")]
    public partial class Sektor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sektor()
        {
            Isyeri = new HashSet<Isyeri>();
        }

        public int SektorID { get; set; }

        [StringLength(30)]
        public string SektorAdi { get; set; }

        public bool? Aktif { get; set; }

        public DateTime? KayitZamani { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Isyeri> Isyeri { get; set; }
    }
}
