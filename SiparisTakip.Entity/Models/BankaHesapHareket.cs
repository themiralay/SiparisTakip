namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankaHesapHareket")]
    public partial class BankaHesapHareket
    {
        public int BankaHesapHareketID { get; set; }

        public int? BankaHesapID { get; set; }

        public int? BankaHareketTipi { get; set; }

        public byte? OdemeSekliID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IslemTarihi { get; set; }

        public int? CariID { get; set; }

        [StringLength(15)]
        public string EvrakNo { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public decimal? Tutar { get; set; }

        public int? BankaIslemTipi { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? CariHareketID { get; set; }

        public int? SatisID { get; set; }

        public int? KasaID { get; set; }

        public int? EvrakTuruID { get; set; }

        public int? BBVirmanHareketID { get; set; }

        public virtual BankaHesap BankaHesap { get; set; }

        public virtual Satis Satis { get; set; }
    }
}
