namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeknikServis
    {
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

        public int IsyeriID { get; set; }

        [StringLength(2000)]
        public string MusteriBeyani { get; set; }

        [StringLength(200)]
        public string CalisanYorumu { get; set; }
    }
}
