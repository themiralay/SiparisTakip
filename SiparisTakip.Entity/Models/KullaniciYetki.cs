namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciYetki")]
    public partial class KullaniciYetki
    {
        public int KullaniciYetkiID { get; set; }

        public int? YetkiID { get; set; }

        public int? KullaniciID { get; set; }
    }
}
