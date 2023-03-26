namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SatisDetay")]
    public partial class SatisDetay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SatisDetay()
        {
            StokHareket = new HashSet<StokHareket>();
        }

        public int SatisDetayID { get; set; }

        public int SatisID { get; set; }

        public int StokID { get; set; }

        public decimal? Miktari { get; set; }

        public decimal? AsilSatisFiyati { get; set; }

        public decimal? SatisFiyati { get; set; }

        public decimal? IskontoOrani { get; set; }

        public decimal? IndirimTutari { get; set; }

        public decimal? Tutar { get; set; }

        public decimal? KdvOrani { get; set; }

        public decimal? Kdv { get; set; }

        public decimal? ToplamTutar { get; set; }

        public decimal? GenelToplam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SatisTarihi { get; set; }

        public int? KullaniciID { get; set; }

        public int? DepoID { get; set; }

        public decimal? BirimFiyati { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? NetFiyat { get; set; }

        public decimal? Kar { get; set; }

        public decimal? AlisFiyati { get; set; }

        public byte? AlisKdvDurumID { get; set; }

        public int? StokVaryantID { get; set; }

        public int IsyeriID { get; set; }

        public int DovizParaBirimiID { get; set; }

        public decimal DovizBirimFiyati { get; set; }

        public double DovizSatisDegeri { get; set; }

        public virtual Satis Satis { get; set; }

        public virtual Stok Stok { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokHareket> StokHareket { get; set; }
    }
}
