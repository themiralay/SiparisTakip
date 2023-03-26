namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StokSayimDetay")]
    public partial class StokSayimDetay
    {
        public int StokSayimDetayID { get; set; }

        public int StokSayimID { get; set; }

        public int DepoID { get; set; }

        public int StokID { get; set; }

        public int? StokVaryantID { get; set; }

        public int? StokDepoID { get; set; }

        public double GirenMiktar { get; set; }

        public double CikanMiktar { get; set; }

        public double MevcutStokMiktari { get; set; }

        public double SayimMiktari { get; set; }

        public double FarkMiktari { get; set; }

        public virtual Stok Stok { get; set; }

        public virtual StokSayim StokSayim { get; set; }

        public virtual Tanim Tanim { get; set; }
    }
}
