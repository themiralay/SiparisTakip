namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StokDepo")]
    public partial class StokDepo
    {
        public int StokDepoID { get; set; }

        public int? DepoID { get; set; }

        public int? StokID { get; set; }

        public int? GirenAdet { get; set; }

        public int? CikanAdet { get; set; }

        public int? MevcutStokAdeti { get; set; }

        public int? KritikStokAdeti { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        [StringLength(10)]
        public string KoridorNo { get; set; }

        [StringLength(10)]
        public string RafNo { get; set; }

        public int IsyeriID { get; set; }

        public decimal? SatisFiyati1 { get; set; }

        public decimal? SatisFiyati2 { get; set; }

        public decimal? SatisFiyati3 { get; set; }

        public decimal? SatisFiyati4 { get; set; }

        public decimal? SatisFiyati5 { get; set; }

        public byte? SatisKdvDurumID { get; set; }

        public int? IndirimTuruID { get; set; }

        public decimal? Indirim { get; set; }

        public int? StokVaryantID { get; set; }

        public bool Varyant { get; set; }

        public bool Aktif { get; set; }

        public virtual Stok Stok { get; set; }

        public virtual StokVaryant StokVaryant { get; set; }

        public virtual Tanim Tanim { get; set; }
    }
}
