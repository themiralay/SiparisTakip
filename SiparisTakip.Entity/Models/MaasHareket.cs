namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaasHareket")]
    public partial class MaasHareket
    {
        public int MaasHareketID { get; set; }

        public int? MaasID { get; set; }

        public int PersonelID { get; set; }

        public byte? Ay { get; set; }

        public short? Yil { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IslemTarihi { get; set; }

        public int? IslemTipiID { get; set; }

        public int? OdemeSekliID { get; set; }

        public decimal? IslemTutari { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? KayitZamani { get; set; }

        public int? ParaTuruID { get; set; }

        [StringLength(30)]
        public string MACCAdress { get; set; }

        public virtual Maas Maas { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
