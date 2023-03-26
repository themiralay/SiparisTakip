namespace SiparisTakip.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_Kullanici
    {
        [StringLength(150)]
        public string IsyeriAdi { get; set; }

        public int? DepoID { get; set; }

        [StringLength(30)]
        public string Yetki { get; set; }

        [StringLength(50)]
        public string MerkezDepo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciID { get; set; }

        [StringLength(30)]
        public string KullaniciAdi { get; set; }

        [StringLength(30)]
        public string KullaniciSoyadi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string KullaniciKodu { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Parola { get; set; }

        public DateTime? KayitZamani { get; set; }

        public bool? Aktif { get; set; }

        public int? IsyeriID { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte YetkiID { get; set; }

        [StringLength(128)]
        public string Sifre { get; set; }

        public DateTime? EnSonGirisZamani { get; set; }

        [StringLength(15)]
        public string CepTelNo { get; set; }

        [StringLength(30)]
        public string EMail { get; set; }

        public bool? CariGoruntulemeYetki { get; set; }

        public bool? CariYeniYetki { get; set; }

        public bool? CariDuzenleYetki { get; set; }

        public bool? CariSilYetki { get; set; }

        public bool? CariTahsilatYapYetki { get; set; }

        public bool? CariOdemeYapYetki { get; set; }

        public bool? CariAlacaklandirYetki { get; set; }

        public bool? CariBorclandirYetki { get; set; }

        public bool? CariIslemDuzenleYetki { get; set; }

        public bool? CariIslemSilYetki { get; set; }

        public bool? StokGoruntulemeYetki { get; set; }

        public bool? StokYeniYetki { get; set; }

        public bool? StokSilYetki { get; set; }

        public bool? StokDuzenleYetki { get; set; }

        public bool? StokGirisYetki { get; set; }

        public bool? StokCikisYetki { get; set; }

        public bool? StokDepodanAktarYetki { get; set; }

        public bool? StokIslemSilYetki { get; set; }

        public bool? StokIslemDuzenleYetki { get; set; }

        public bool? StokHareketGoruntuleYetki { get; set; }

        public bool? StokFiyatHareketiGoruntuleYetki { get; set; }

        public bool? StokEtiketBasYetki { get; set; }

        public bool? StokRafEtiketBasYetki { get; set; }

        public bool? KasaGoruntulemeYetki { get; set; }

        public bool? KasaGirisYapYetki { get; set; }

        public bool? KasaCikisYapYetki { get; set; }

        public bool? KasaIslemDuzeltYetki { get; set; }

        public bool? KasaIslemSilYetki { get; set; }

        public bool? BankaGoruntulemeYetki { get; set; }

        public bool? BankaEkleYetki { get; set; }

        public bool? BankaDuzenleYetki { get; set; }

        public bool? BankaSilYetki { get; set; }

        public bool? BankaGirisYapYetki { get; set; }

        public bool? BankaCikisYapYetki { get; set; }

        public bool? BankaIslemDuzenleYetki { get; set; }

        public bool? BankaIslemSilYetki { get; set; }

        public bool? KullaniciGoruntulemeYetki { get; set; }

        public bool? KullaniciEkleYetki { get; set; }

        public bool? KullaniciDuzenleYetki { get; set; }

        public bool? KullaniciSilYetki { get; set; }

        public bool? SirketBilgileriGoruntulemeYetki { get; set; }

        public bool? AyarlarGoruntulemeYetki { get; set; }

        public bool? BankaKasayaVirmanYetki { get; set; }

        public bool? BankadanBankayaVirmanYetki { get; set; }

        public bool? StokDepodanHizliAktarYetki { get; set; }

        public bool? StokTopluFiyatGuncelleYetki { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IrsaliyeGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool FaturaGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CekSenetGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool TaksitGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool PersonelGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool HizliSatisGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool HizliYeniSatisFaturasiGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool HizliYeniAlisFaturasiGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool RutHareketPlaniYetki { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool RaporlariGoruntulemeYetki { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool TanimamalariGoruntulemeYetki { get; set; }

        [StringLength(11)]
        public string TCKimlikNo { get; set; }
    }
}
