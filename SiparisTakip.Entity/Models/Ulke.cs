namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ulke")]
    public partial class Ulke
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ulke()
        {
            Il = new HashSet<Il>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UlkeID { get; set; }

        [StringLength(5)]
        public string IsoKodu { get; set; }

        [StringLength(50)]
        public string IsoAdi { get; set; }

        [StringLength(50)]
        public string UlkeAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Il> Il { get; set; }
    }
}
