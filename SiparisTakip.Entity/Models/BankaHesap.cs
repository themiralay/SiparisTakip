namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankaHesap")]
    public partial class BankaHesap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankaHesap()
        {
            BankaHesapHareket = new HashSet<BankaHesapHareket>();
        }

        public int BankaHesapID { get; set; }

        [StringLength(20)]
        public string HesapKodu { get; set; }

        public int? BankaID { get; set; }

        [StringLength(50)]
        public string SubeAdi { get; set; }

        [StringLength(10)]
        public string SubeKodu { get; set; }

        [StringLength(30)]
        public string HesapNo { get; set; }

        [StringLength(50)]
        public string IBAN { get; set; }

        public int? ParaTuruID { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        public bool? KrediKarti { get; set; }

        public int? IsyeriID { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public bool? Aktif { get; set; }

        public bool? POSVarmi { get; set; }

        public byte? POSSirasi { get; set; }

        public virtual Isyeri Isyeri { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Tanim Tanim { get; set; }

        public virtual Tanim Tanim1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankaHesapHareket> BankaHesapHareket { get; set; }
    }
}
