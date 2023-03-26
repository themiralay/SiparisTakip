namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Maas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maas()
        {
            MaasHareket = new HashSet<MaasHareket>();
        }

        public int MaasID { get; set; }

        public int? PersonelID { get; set; }

        public byte? Ay { get; set; }

        public short? Yil { get; set; }

        public decimal? MaasTutari { get; set; }

        public decimal? BankayaYatanTutar { get; set; }

        public decimal? MaxAvansTutari { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? MaasTutariParaTuruID { get; set; }

        public int? MaxAvansTutariParaTuruID { get; set; }

        public virtual Personel Personel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaasHareket> MaasHareket { get; set; }
    }
}
