namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_SatisListesi
    {
        [StringLength(30)]
        public string OdemeTuru { get; set; }

        [StringLength(30)]
        public string IslemTuru { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SatisID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte OdemeTuruID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte SatisIslemTuruID { get; set; }

        public int? FisNo { get; set; }

        public decimal? Tutar { get; set; }

        public decimal? Kdv { get; set; }

        public decimal? IskontoOrani { get; set; }

        public decimal? IndirimTutari { get; set; }

        public decimal? ToplamTutar { get; set; }

        public decimal? GenelToplam { get; set; }

        public decimal? Odeme { get; set; }

        public decimal? ParaUstu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SatisTarihi { get; set; }

        public DateTime? SatisZamani { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciID { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? ToplamKar { get; set; }

        public int? BankaHesapID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsyeriID { get; set; }
    }
}
