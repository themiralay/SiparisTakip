namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_BankaHesap
    {
        [StringLength(50)]
        public string BankaAdi { get; set; }

        [StringLength(50)]
        public string ParaBirimi { get; set; }

        public decimal? Bakiye { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
    }
}
