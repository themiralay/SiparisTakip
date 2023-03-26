namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_FaturaDetay
    {
        [StringLength(30)]
        public string DepoDurum { get; set; }

        [StringLength(50)]
        public string Depo { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        public int? CariID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IrsaliyeTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FaturaTarihi { get; set; }

        public byte? FaturaTipi { get; set; }

        [StringLength(30)]
        public string OdemeSekli { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool FDHizliStokGiris { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte FDStokIslemTuruID { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        public int? StokGrubuID { get; set; }

        [StringLength(50)]
        public string StokGrubu { get; set; }

        public DateTime? KayitZamani { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FaturaDetayID { get; set; }

        public int? FaturaID { get; set; }

        public int? StokID { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        [StringLength(30)]
        public string StokKodu { get; set; }

        [StringLength(200)]
        public string StokAdi { get; set; }

        public decimal? AsilSatisFiyati { get; set; }

        public decimal? BirimFiyati { get; set; }

        public decimal? KdvOrani { get; set; }

        public decimal? KdvTutar { get; set; }

        public decimal? Miktar { get; set; }

        [StringLength(20)]
        public string Birimi { get; set; }

        public decimal? IskontoOrani { get; set; }

        public decimal? IskontoTutari { get; set; }

        public decimal? ToplamIskontoTutari { get; set; }

        public decimal? NetFiyat { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? Tutar { get; set; }

        public decimal? Toplam { get; set; }

        public int? SatisDetayID { get; set; }

        [StringLength(150)]
        public string Aciklama { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte StokIslemTuruID { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool HizliStokGiris { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepoID { get; set; }

        public decimal? AsilToplam { get; set; }

        public decimal? AlisFiyati { get; set; }

        public byte? AlisKdvDurumID { get; set; }

        public int? StokVaryantID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsyeriID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DovizParaBirimiID { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DovizBirimFiyati { get; set; }

        [Key]
        [Column(Order = 9)]
        public double DovizSatisDegeri { get; set; }
    }
}
