namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stok")]
    public partial class Stok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stok()
        {
            CariStokFiyat = new HashSet<CariStokFiyat>();
            FaturaDetay = new HashSet<FaturaDetay>();
            SatisDetay = new HashSet<SatisDetay>();
            StokDepo = new HashSet<StokDepo>();
            StokETicaret = new HashSet<StokETicaret>();
            StokHareket = new HashSet<StokHareket>();
            StokResim = new HashSet<StokResim>();
            StokSayimDetay = new HashSet<StokSayimDetay>();
            StokVaryant = new HashSet<StokVaryant>();
        }

        public int StokID { get; set; }

        [Required]
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

        public int ParaBirimiID { get; set; }


    



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CariStokFiyat> CariStokFiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaDetay> FaturaDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatisDetay> SatisDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokDepo> StokDepo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokETicaret> StokETicaret { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokHareket> StokHareket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokResim> StokResim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokSayimDetay> StokSayimDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokVaryant> StokVaryant { get; set; }
    }
}
