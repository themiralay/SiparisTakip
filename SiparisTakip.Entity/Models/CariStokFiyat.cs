namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CariStokFiyat")]
    public partial class CariStokFiyat
    {
        public int CariStokFiyatID { get; set; }

        public int CariID { get; set; }

        public int StokID { get; set; }

        public decimal SatisFiyati { get; set; }

        public bool Aktif { get; set; }

        public DateTime? KayitZamani { get; set; }

        public int KullaniciID { get; set; }

        [StringLength(30)]
        public string MaccAdress { get; set; }

        public int IsyeriID { get; set; }

        public virtual Cari Cari { get; set; }

        public virtual Isyeri Isyeri { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Stok Stok { get; set; }
    }
}
