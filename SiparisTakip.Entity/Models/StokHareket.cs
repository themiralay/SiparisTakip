namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StokHareket")]
    public partial class StokHareket
    {
        public int StokHareketID { get; set; }

        public int StokID { get; set; }

        public int DepoID { get; set; }

        [Column(TypeName = "date")]
        public DateTime IslemTarihi { get; set; }

        public byte? IslemTuruID { get; set; }

        public decimal? Miktar { get; set; }

        public int? FaturaDetayID { get; set; }

        public int? SatisDetayID { get; set; }

        [StringLength(10)]
        public string BelgeNo { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public virtual SatisDetay SatisDetay { get; set; }

        public virtual Stok Stok { get; set; }
    }
}
