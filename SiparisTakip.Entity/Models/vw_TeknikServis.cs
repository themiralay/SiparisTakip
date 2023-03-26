namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_TeknikServis
    {
        [StringLength(200)]
        public string CariAdi { get; set; }

        public int? CariGrupID { get; set; }

        [StringLength(50)]
        public string CariGrup { get; set; }

        [StringLength(30)]
        public string YetkiliAdi { get; set; }

        [StringLength(30)]
        public string YetkiliSoyadi { get; set; }

        [StringLength(20)]
        public string CepTelNo { get; set; }

        [StringLength(40)]
        public string EMail { get; set; }

        public int? IlID { get; set; }

        [StringLength(50)]
        public string IlAdi { get; set; }

        public int? IlceID { get; set; }

        [StringLength(20)]
        public string IlceAdi { get; set; }

        [StringLength(200)]
        public string Adres { get; set; }

        [StringLength(30)]
        public string GarantiDurumu { get; set; }

        [StringLength(30)]
        public string ServisDurumu { get; set; }

        [StringLength(50)]
        public string ServisTuru { get; set; }

        [StringLength(50)]
        public string MarkaAdi { get; set; }

        [StringLength(50)]
        public string ModelAdi { get; set; }

        [StringLength(61)]
        public string Kullanici { get; set; }

        [StringLength(150)]
        public string IsyeriAdi { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeknikServisID { get; set; }

        public int? CariID { get; set; }

        public int? ServisDurumuID { get; set; }

        public int? ServisTuruID { get; set; }

        public int? MarkaID { get; set; }

        public int? ModelID { get; set; }

        [StringLength(30)]
        public string SeriNo { get; set; }

        public int? GarantiDurumuID { get; set; }

        public int? StokGrubuID { get; set; }

        public bool? YedekAlinacakMi { get; set; }

        [StringLength(150)]
        public string ResimUrl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KayitTarihi { get; set; }

        public DateTime? KayitZamani { get; set; }

        public int? KullaniciID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsyeriID { get; set; }

        [StringLength(2000)]
        public string MusteriBeyani { get; set; }

        [StringLength(200)]
        public string CalisanYorumu { get; set; }
    }
}
