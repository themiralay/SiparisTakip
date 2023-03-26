namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_CariBakiye
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CariID { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        public int? CariGrupID { get; set; }

        [StringLength(50)]
        public string CariGrupAdi { get; set; }

        public decimal? Alacak { get; set; }

        public decimal? Borc { get; set; }

        public decimal? Bakiye { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string BakiyeDurumu { get; set; }
    }
}
