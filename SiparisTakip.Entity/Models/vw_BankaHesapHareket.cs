namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_BankaHesapHareket
    {
        [StringLength(50)]
        public string BankaAdi { get; set; }

        [StringLength(20)]
        public string HesapKodu { get; set; }

        [StringLength(30)]
        public string HesapNo { get; set; }

        [StringLength(50)]
        public string IBAN { get; set; }

        [StringLength(10)]
        public string SubeKodu { get; set; }

        [StringLength(50)]
        public string SubeAdi { get; set; }

        [StringLength(30)]
        public string BankaHareket { get; set; }

        [StringLength(30)]
        public string OdemeSekli { get; set; }

        [StringLength(50)]
        public string ParaTuru { get; set; }

        [StringLength(50)]
        public string EvrakTuru { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        [StringLength(150)]
        public string IsyeriAdi { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        public bool? KrediKarti { get; set; }

        public bool? POSVarmi { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
    }
}
