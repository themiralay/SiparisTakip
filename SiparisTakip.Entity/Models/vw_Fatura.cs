namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Fatura
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string Sira { get; set; }

        [StringLength(30)]
        public string FaturaTipiAdi { get; set; }

        [StringLength(61)]
        public string SatisEleman { get; set; }

        [StringLength(50)]
        public string Depo { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        [StringLength(20)]
        public string CepTelNo { get; set; }

        [StringLength(11)]
        public string TCKimlikNo { get; set; }

        public decimal? Maliyet { get; set; }

        public decimal? Kar { get; set; }

        public decimal? YuzdeKar { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FaturaID { get; set; }

        public int? CariID { get; set; }

        [StringLength(20)]
        public string CariKodu { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        [StringLength(200)]
        public string CariAdresi { get; set; }

        [StringLength(20)]
        public string CariIlce { get; set; }

        [StringLength(20)]
        public string CariIl { get; set; }

        [StringLength(200)]
        public string CariVergiDairesi { get; set; }

        [StringLength(25)]
        public string CariVergiNo { get; set; }

        public bool? FaturaIslemTuru { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IrsaliyeTarihi { get; set; }

        [StringLength(100)]
        public string IrsaliyeNo { get; set; }

        [StringLength(8)]
        public string IrsaliyeSaati { get; set; }

        public bool? FaturaDurum { get; set; }

        [StringLength(100)]
        public string FaturaNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FaturaTarihi { get; set; }

        [StringLength(8)]
        public string FaturaSaati { get; set; }

        public int? VedeGun { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VadeTarihi { get; set; }

        public byte? FaturaTipi { get; set; }

        public int? SatisElemanID { get; set; }

        public int? DepoID { get; set; }

        public bool? KdvDahil { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? ToplamIndirim { get; set; }

        public decimal? ToplamTutar { get; set; }

        public decimal? ToplamKdv { get; set; }

        public decimal? GenelToplam { get; set; }

        public bool? Iptal { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? KullaniciID { get; set; }

        public int? SatisID { get; set; }

        public byte? SatisTarifesi { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte StokIslemTuruID { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool HizliStokGiris { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime Tarih { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool HizliSatis { get; set; }

        public byte? OdemeSekliID { get; set; }

        public decimal? Odenen { get; set; }

        public decimal? Kalan { get; set; }

        public int? BankaHesapID { get; set; }

        public bool? FaturaKapat { get; set; }

        public decimal? AraToplam0 { get; set; }

        public decimal? AraToplam1 { get; set; }

        public decimal? Kdv1 { get; set; }

        public decimal? AraToplam8 { get; set; }

        public decimal? Kdv8 { get; set; }

        public decimal? AraToplam18 { get; set; }

        public decimal? Kdv18 { get; set; }

        public decimal? AsilToplam { get; set; }

        public bool? Iade { get; set; }

        [StringLength(5)]
        public string IrsaliyeSeri { get; set; }

        [StringLength(5)]
        public string FaturaSeri { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsyeriID { get; set; }

        [StringLength(1500)]
        public string Aciklama { get; set; }
    }
}
