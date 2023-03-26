namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_CariHareket
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string Sira { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        [StringLength(30)]
        public string YetkiliAdi { get; set; }

        [StringLength(30)]
        public string YetkiliSoyadi { get; set; }

        public int? CariGrupID { get; set; }

        [StringLength(20)]
        public string CariKodu { get; set; }

        public byte? SatisTarifesi { get; set; }

        [StringLength(30)]
        public string OdemeSekli { get; set; }

        [StringLength(30)]
        public string CariIslemTurAdi { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        public byte? KasaTipiID { get; set; }

        public int? BankaHesapHareketID { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Iade { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CariHareketID { get; set; }

        [Key]
        [Column(Order = 3)]
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

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? SatisID { get; set; }

        public int? BankaHesapID { get; set; }

        public int? FaturaID { get; set; }

        public int? IsyeriID { get; set; }
    }
}
