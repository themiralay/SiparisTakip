namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yetki")]
    public partial class Yetki
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YetkiID { get; set; }

        [StringLength(200)]
        public string YetkiAdi { get; set; }

        public byte? ModulID { get; set; }

        public DateTime? KayitZamani { get; set; }
    }
}
