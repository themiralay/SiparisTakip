namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CariHareket")]
    public partial class CariHareket
    {
        public int CariHareketID { get; set; }

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

        public int KullaniciID { get; set; }

        public DateTime KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public int? SatisID { get; set; }

        public int? BankaHesapID { get; set; }

        public int? FaturaID { get; set; }

        public int? IsyeriID { get; set; }

        public virtual Cari Cari { get; set; }

        public virtual Satis Satis { get; set; }
    }
}
