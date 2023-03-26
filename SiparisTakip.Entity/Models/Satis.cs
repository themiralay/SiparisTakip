namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satis()
        {
            BankaHesapHareket = new HashSet<BankaHesapHareket>();
            CariHareket = new HashSet<CariHareket>();
            Fatura = new HashSet<Fatura>();
            Kasa = new HashSet<Kasa>();
            SatisDetay = new HashSet<SatisDetay>();
        }

        public int SatisID { get; set; }

        public byte OdemeTuruID { get; set; }

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

        public int KullaniciID { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? ToplamKar { get; set; }

        public int? BankaHesapID { get; set; }

        public int IsyeriID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankaHesapHareket> BankaHesapHareket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CariHareket> CariHareket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa> Kasa { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatisDetay> SatisDetay { get; set; }
    }
}
