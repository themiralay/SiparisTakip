namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_StokSayim
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokSayimDetayID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokSayimID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StokID { get; set; }

        public int? StokVaryantID { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        [StringLength(30)]
        public string StokKodu { get; set; }

        [StringLength(405)]
        public string StokAdi { get; set; }

        [StringLength(50)]
        public string StokBirimAdi { get; set; }

        [StringLength(50)]
        public string StokGrubu { get; set; }

        [StringLength(50)]
        public string MarkaAdi { get; set; }

        [StringLength(50)]
        public string Depo { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Tarih { get; set; }

        [StringLength(20)]
        public string SayimKodu { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime KayitZamani { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [Key]
        [Column(Order = 5)]
        public double GirenMiktar { get; set; }

        [Key]
        [Column(Order = 6)]
        public double CikanMiktar { get; set; }

        [Key]
        [Column(Order = 7)]
        public double MevcutStokMiktari { get; set; }

        [Key]
        [Column(Order = 8)]
        public double SayimMiktari { get; set; }

        [Key]
        [Column(Order = 9)]
        public double FarkMiktari { get; set; }
    }
}
