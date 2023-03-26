namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FaturaDetay")]
    public partial class FaturaDetay
    {
        public int FaturaDetayID { get; set; }

        public int? FaturaID { get; set; }

        public int? StokID { get; set; }

        [StringLength(30)]
        public string BarkodNo { get; set; }

        [StringLength(30)]
        public string StokKodu { get; set; }

        [StringLength(200)]
        public string StokAdi { get; set; }

        public decimal? AsilSatisFiyati { get; set; }

        public decimal? BirimFiyati { get; set; }

        public decimal? KdvOrani { get; set; }

        public decimal? KdvTutar { get; set; }

        public decimal? Miktar { get; set; }

        [StringLength(20)]
        public string Birimi { get; set; }

        public decimal? IskontoOrani { get; set; }

        public decimal? IskontoTutari { get; set; }

        public decimal? ToplamIskontoTutari { get; set; }

        public decimal? NetFiyat { get; set; }

        public decimal? AraToplam { get; set; }

        public decimal? Tutar { get; set; }

        public decimal? Toplam { get; set; }

        public int? SatisDetayID { get; set; }

        [StringLength(150)]
        public string Aciklama { get; set; }

        public byte StokIslemTuruID { get; set; }

        public bool HizliStokGiris { get; set; }

        public int DepoID { get; set; }

        public decimal? AsilToplam { get; set; }

        public decimal? AlisFiyati { get; set; }

        public byte? AlisKdvDurumID { get; set; }

        public int? StokVaryantID { get; set; }

        public int IsyeriID { get; set; }

        public int DovizParaBirimiID { get; set; }

        public decimal DovizBirimFiyati { get; set; }

        public double DovizSatisDegeri { get; set; }

        public virtual Fatura Fatura { get; set; }

        public virtual Stok Stok { get; set; }

        public virtual StokVaryant StokVaryant { get; set; }
    }
}
