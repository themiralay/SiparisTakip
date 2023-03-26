namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kasa")]
    public partial class Kasa
    {
        public int KasaID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        public byte? KasaTipiID { get; set; }

        public int? EvrakTuruID { get; set; }

        [StringLength(15)]
        public string EvrakNo { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public decimal? Tutar { get; set; }

        public int? CariHareketID { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? SatisID { get; set; }

        public int? BankaHesapHareketID { get; set; }

        public int? FaturaID { get; set; }

        public int? BankaHesapID { get; set; }

        public int? KasaIslemTipiID { get; set; }

        public int IsyeriID { get; set; }

        public virtual Isyeri Isyeri { get; set; }

        public virtual Satis Satis { get; set; }
    }
}
