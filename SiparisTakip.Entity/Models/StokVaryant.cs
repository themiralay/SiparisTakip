namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StokVaryant")]
    public partial class StokVaryant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StokVaryant()
        {
            FaturaDetay = new HashSet<FaturaDetay>();
            StokDepo = new HashSet<StokDepo>();
        }

        public int StokVaryantID { get; set; }

        public int StokID { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        public int? RenkID { get; set; }

        public int? NumaraID { get; set; }

        public int? MevcutStokAdeti { get; set; }

        public int? KritikStokAdeti { get; set; }

        public byte? SatisKdvDurumID { get; set; }

        public int? IndirimTuruID { get; set; }

        public decimal? Indirim { get; set; }

        public decimal? SatisFiyati1 { get; set; }

        public decimal? SatisFiyati2 { get; set; }

        public decimal? SatisFiyati3 { get; set; }

        public decimal? SatisFiyati4 { get; set; }

        public decimal? SatisFiyati5 { get; set; }

        public int? DepoID { get; set; }

        public int IsyeriID { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MaccAdress { get; set; }

        public bool Aktif { get; set; }

        public int? UzunlukID { get; set; }

        public int? BedenID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaDetay> FaturaDetay { get; set; }

        public virtual Isyeri Isyeri { get; set; }

        public virtual Stok Stok { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokDepo> StokDepo { get; set; }
    }
}
