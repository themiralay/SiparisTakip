namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aksesuar")]
    public partial class Aksesuar
    {
        public int AksesuarID { get; set; }

        public int? TeknikServisID { get; set; }

        public int? StokID { get; set; }
    }
}
