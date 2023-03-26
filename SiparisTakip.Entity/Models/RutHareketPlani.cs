namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RutHareketPlani")]
    public partial class RutHareketPlani
    {
        public int RutHareketPlaniID { get; set; }

        public int CariID { get; set; }

        [Column(TypeName = "date")]
        public DateTime RutBaslamaTarihi { get; set; }

        public int? PlasiyerID { get; set; }

        [Required]
        [StringLength(10)]
        public string Gun { get; set; }

        public int PeriyodID { get; set; }

        public bool? IslemDurumu { get; set; }

        public int? KullaniciID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MaccAdress { get; set; }

        public int IsyeriID { get; set; }

        public DateTime? IslemZamani { get; set; }

        public int? IslemKullaniciID { get; set; }

        public bool OtoOnay { get; set; }

        public byte? Hafta { get; set; }

        public int? Yil { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
