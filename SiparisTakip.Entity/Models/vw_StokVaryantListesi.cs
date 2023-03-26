namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_StokVaryantListesi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokDepoID { get; set; }

        [StringLength(30)]
        public string VaryantBarkodNo { get; set; }

        [StringLength(50)]
        public string StokGrubuAdi { get; set; }

        [StringLength(50)]
        public string StokBirimAdi { get; set; }

        [StringLength(30)]
        public string AlisKdvDurumAdi { get; set; }

        [StringLength(30)]
        public string SatisKdvDurumAdi { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        public decimal? ToplamAlis { get; set; }

        public decimal? ToplamSatis { get; set; }

        [StringLength(50)]
        public string Depo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepoIsyeriID { get; set; }

        public int? DepoID { get; set; }

        public int? StokVaryantID { get; set; }

        public int? DepoKritikStokAdeti { get; set; }

        public int? GirenAdet { get; set; }

        public int? CikanAdet { get; set; }

        public int? DepoMevcutStokAdeti { get; set; }

        public decimal? ToplamVarlik { get; set; }

        [StringLength(50)]
        public string AltStokGrubuAdi { get; set; }

        [StringLength(50)]
        public string AltStokGrubuAdi2 { get; set; }

        [StringLength(50)]
        public string AltStokGrubuAdi3 { get; set; }

        public int? RenkTanimID { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }

        public long? RenkN11Kodu { get; set; }

        public int? NumaraTanimID { get; set; }

        [StringLength(50)]
        public string Numara { get; set; }

        public long? NumaraN11Kodu { get; set; }

        public int? UzunlukTanimID { get; set; }

        [StringLength(50)]
        public string Uzunluk { get; set; }

        public long? UzunlukN11Kodu { get; set; }

        public int? BedenTanimID { get; set; }

        [StringLength(50)]
        public string Beden { get; set; }

        public long? BedenN11Kodu { get; set; }

        [StringLength(50)]
        public string Marka { get; set; }

        [StringLength(50)]
        public string UrunCinsiyet { get; set; }

        [StringLength(50)]
        public string UrunMalzeme { get; set; }

        [StringLength(204)]
        public string VaryantAdi { get; set; }

        [StringLength(405)]
        public string StokVaryantAdi { get; set; }

        [StringLength(50)]
        public string ParaBirimi { get; set; }

        [StringLength(10)]
        public string ParaSembolu { get; set; }

        [StringLength(10)]
        public string ParaBirimiKodu { get; set; }

        public int? StokID { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        [StringLength(30)]
        public string StokKodu { get; set; }

        public int? StokGrubuID { get; set; }

        [StringLength(200)]
        public string StokAdi { get; set; }

        public int? StokBirimID { get; set; }

        public decimal? AlisFiyati { get; set; }

        public byte? AlisKdvDurumID { get; set; }

        public decimal? KdvOrani { get; set; }

        public decimal? SatisFiyati { get; set; }

        public decimal? Kdv { get; set; }

        public decimal? ToplamFiyati { get; set; }

        public byte? SatisKdvDurumID { get; set; }

        public int? MevcutStokAdeti { get; set; }

        public int? KritikStokAdeti { get; set; }

        public bool? Aktif { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public string Notlar { get; set; }

        [StringLength(100)]
        public string ResimUrl { get; set; }

        public bool? HizliMenuAktif { get; set; }

        public int? HizliMenuSira { get; set; }

        public decimal? SatisFiyati2 { get; set; }

        public byte? SatisKdvDurumID2 { get; set; }

        public decimal? SatisFiyati3 { get; set; }

        public byte? SatisKdvDurumID3 { get; set; }

        [StringLength(30)]
        public string OzelKodu1 { get; set; }

        [StringLength(30)]
        public string OzelKodu2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] Resim { get; set; }

        public int? MarkaID { get; set; }

        public int? UrunMalzemeID { get; set; }

        public int? UrunCinsiyetID { get; set; }

        public int? IsyeriID { get; set; }

        public int? AltStokGrubID { get; set; }

        public int? AltStokGrubID2 { get; set; }

        public int? AltStokGrubID3 { get; set; }

        public int? RenkID { get; set; }

        public int? NumaraID { get; set; }

        public int? UzunlukID { get; set; }

        public decimal? SatisFiyati4 { get; set; }

        public byte? SatisKdvDurumID4 { get; set; }

        public decimal? SatisFiyati5 { get; set; }

        public byte? SatisKdvDurumID5 { get; set; }

        [StringLength(200)]
        public string StokAdi2 { get; set; }

        [StringLength(255)]
        public string StokKisaAciklama { get; set; }

        [StringLength(255)]
        public string StokAnahtarKelime { get; set; }

        public int? ParaBirimiID { get; set; }
    }
}
