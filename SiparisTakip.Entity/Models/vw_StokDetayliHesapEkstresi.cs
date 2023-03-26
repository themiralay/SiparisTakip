namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_StokDetayliHesapEkstresi
    {
        [StringLength(200)]
        public string StokAdi { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        public decimal? Miktar { get; set; }

        public decimal? BirimFiyati { get; set; }

        public decimal? NetFiyat { get; set; }

        public decimal? AsilSatisFiyati { get; set; }

        public decimal? IskontoOrani { get; set; }

        public decimal? IskontoTutari { get; set; }

        public decimal? KdvOrani { get; set; }

        public decimal? KdvTutar { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? Toplam { get; set; }

        public decimal? ToplamTutar { get; set; }

        public decimal? GenelToplam { get; set; }

        [StringLength(10)]
        public string CariHareketEvrakNo { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        [StringLength(30)]
        public string OdemeSekli { get; set; }

        [StringLength(30)]
        public string YetkiliAdi { get; set; }

        [StringLength(30)]
        public string YetkiliSoyadi { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(20)]
        public string Faks { get; set; }

        [StringLength(40)]
        public string EMail { get; set; }

        [StringLength(30)]
        public string CariIslemTipi { get; set; }

        [StringLength(30)]
        public string IslemTarihi1 { get; set; }

        [StringLength(30)]
        public string VadeTarihi1 { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CariHareketID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CariID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IslemTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VadeTarihi { get; set; }

        public int? OdemeSekliID { get; set; }

        [StringLength(10)]
        public string EvrakNo { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public decimal? Borc { get; set; }

        public decimal? Alacak { get; set; }

        public decimal? Bakiye { get; set; }

        public short? CariIslemTuru { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? SatisID { get; set; }

        public int? BankaHesapID { get; set; }

        public int? FaturaID { get; set; }

        public int? IsyeriID { get; set; }
    }
}
