namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_SatisDetayListesi
    {
        public decimal? SatisToplamTutar { get; set; }

        public decimal? OdemeTutari { get; set; }

        public decimal? ParaUstu { get; set; }

        [StringLength(50)]
        public string StokGrubu { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        [StringLength(200)]
        public string StokAdi { get; set; }

        [StringLength(50)]
        public string Birimi { get; set; }

        public int? FisNo { get; set; }

        [StringLength(30)]
        public string OdemeTuru { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        public int? StokBirimID { get; set; }

        public int? StokGrubuID { get; set; }

        [StringLength(10)]
        public string SatisTarihi1 { get; set; }

        [StringLength(10)]
        public string SatisZamani1 { get; set; }

        public DateTime? SatisZamani { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SatisDetayID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SatisID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokID { get; set; }

        public decimal? Miktari { get; set; }

        public decimal? AsilSatisFiyati { get; set; }

        public decimal? SatisFiyati { get; set; }

        public decimal? IskontoOrani { get; set; }

        public decimal? IndirimTutari { get; set; }

        public decimal? Tutar { get; set; }

        public decimal? KdvOrani { get; set; }

        public decimal? Kdv { get; set; }

        public decimal? ToplamTutar { get; set; }

        public decimal? GenelToplam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SatisTarihi { get; set; }

        public int? KullaniciID { get; set; }

        public int? DepoID { get; set; }

        public decimal? BirimFiyati { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? NetFiyat { get; set; }

        public decimal? Kar { get; set; }

        public decimal? AlisFiyati { get; set; }

        public byte? AlisKdvDurumID { get; set; }

        public int? StokVaryantID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsyeriID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DovizParaBirimiID { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal DovizBirimFiyati { get; set; }

        [Key]
        [Column(Order = 6)]
        public double DovizSatisDegeri { get; set; }
    }
}
