namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Il")]
    public partial class Il
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Il()
        {
            Ilce = new HashSet<Ilce>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IlID { get; set; }

        public int? UlkeID { get; set; }

        public int? IlKodu { get; set; }

        [StringLength(50)]
        public string IlAdi { get; set; }

        public virtual Ulke Ulke { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ilce> Ilce { get; set; }
    }
}
