namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cari")]
    public partial class Cari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cari()
        {
            CariHareket = new HashSet<CariHareket>();
            CariStokFiyat = new HashSet<CariStokFiyat>();
            Fatura = new HashSet<Fatura>();
        }

        public int CariID { get; set; }

        public int? CariGrupID { get; set; }

        [StringLength(200)]
        public string CariAdi { get; set; }

        [StringLength(30)]
        public string YetkiliAdi { get; set; }

        [StringLength(30)]
        public string YetkiliSoyadi { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(20)]
        public string Faks { get; set; }

        [StringLength(20)]
        public string CepTelNo { get; set; }

        [StringLength(40)]
        public string EMail { get; set; }

        [StringLength(40)]
        public string WebAdresi { get; set; }

        public int? PostaKodu { get; set; }

        [StringLength(200)]
        public string VergiDairesi { get; set; }

        [StringLength(25)]
        public string VergiNo { get; set; }

        [StringLength(25)]
        public string TicaretSicilNo { get; set; }

        [StringLength(20)]
        public string Ili { get; set; }

        [StringLength(20)]
        public string Ilcesi { get; set; }

        [StringLength(200)]
        public string Adres { get; set; }

        [StringLength(200)]
        public string SevkAdresi { get; set; }

        public int? BankaID { get; set; }

        [StringLength(10)]
        public string BankaSubeKodu { get; set; }

        [StringLength(20)]
        public string BankaHesapNo { get; set; }

        [StringLength(10)]
        public string BankaEkNo { get; set; }

        [StringLength(40)]
        public string BankaIbanNo { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public bool? Aktif { get; set; }

        public int? IlID { get; set; }

        public int? IlceID { get; set; }

        public int IsyeriID { get; set; }

        public byte? SatisTarifesi { get; set; }

        [StringLength(20)]
        public string CariKodu { get; set; }

        [StringLength(11)]
        public string TCKimlikNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CariHareket> CariHareket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CariStokFiyat> CariStokFiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }
    }
}
