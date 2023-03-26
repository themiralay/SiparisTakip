namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_StokHareketListesi
    {
        [StringLength(30)]
        public string IslemTuru { get; set; }

        [StringLength(50)]
        public string StokBirimAdi { get; set; }

        [StringLength(61)]
        public string KullaniciAdiSoyadi { get; set; }

        [StringLength(50)]
        public string Depo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokHareketID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepoID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime IslemTarihi { get; set; }

        public byte? IslemTuruID { get; set; }

        public decimal? Miktar { get; set; }

        public int? FaturaDetayID { get; set; }

        public int? SatisDetayID { get; set; }

        [StringLength(10)]
        public string BelgeNo { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }
    }
}
