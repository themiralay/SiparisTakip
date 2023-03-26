namespace SiparisTakip.Dal.Concrete.EntityFramework.Context
{
    using SiparisTakip.Entity.Models;
    using System.Data.Entity;

    public partial class SiparisTakipContext : DbContext
    {
        public SiparisTakipContext()
            : base("name=SiparisTakipContext")
        {
        }

        public virtual DbSet<Aksesuar> Aksesuar { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Ayarlar> Ayarlar { get; set; }
        public virtual DbSet<BankaHesap> BankaHesap { get; set; }
        public virtual DbSet<BankaHesapHareket> BankaHesapHareket { get; set; }
        public virtual DbSet<Cari> Cari { get; set; }
        public virtual DbSet<CariHareket> CariHareket { get; set; }
        public virtual DbSet<CariStokFiyat> CariStokFiyat { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetay { get; set; }
        public virtual DbSet<Il> Il { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Isyeri> Isyeri { get; set; }
        public virtual DbSet<Kasa> Kasa { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciYetki> KullaniciYetki { get; set; }
        public virtual DbSet<Maas> Maas { get; set; }
        public virtual DbSet<MaasHareket> MaasHareket { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<RutHareketPlani> RutHareketPlani { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<SatisDetay> SatisDetay { get; set; }
        public virtual DbSet<Sektor> Sektor { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<StokDepo> StokDepo { get; set; }
        public virtual DbSet<StokETicaret> StokETicaret { get; set; }
        public virtual DbSet<StokHareket> StokHareket { get; set; }
        public virtual DbSet<StokResim> StokResim { get; set; }
        public virtual DbSet<StokSayim> StokSayim { get; set; }
        public virtual DbSet<StokSayimDetay> StokSayimDetay { get; set; }
        public virtual DbSet<StokVaryant> StokVaryant { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tanim> Tanim { get; set; }
        public virtual DbSet<TanimGrup> TanimGrup { get; set; }
        public virtual DbSet<TeknikServis> TeknikServis { get; set; }
        public virtual DbSet<Ulke> Ulke { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }
        public virtual DbSet<Sabit> Sabit { get; set; }
        public virtual DbSet<vw_BankaHesap> vw_BankaHesap { get; set; }
        public virtual DbSet<vw_BankaHesapHareket> vw_BankaHesapHareket { get; set; }
        public virtual DbSet<vw_CariBakiye> vw_CariBakiye { get; set; }
        public virtual DbSet<vw_CariHareket> vw_CariHareket { get; set; }
        public virtual DbSet<vw_Fatura> vw_Fatura { get; set; }
        public virtual DbSet<vw_FaturaDetay> vw_FaturaDetay { get; set; }
        public virtual DbSet<vw_Kullanici> vw_Kullanici { get; set; }
        public virtual DbSet<vw_SatisDetayListesi> vw_SatisDetayListesi { get; set; }
        public virtual DbSet<vw_SatisListesi> vw_SatisListesi { get; set; }
        public virtual DbSet<vw_StokDetayliHesapEkstresi> vw_StokDetayliHesapEkstresi { get; set; }
        public virtual DbSet<vw_StokHareketListesi> vw_StokHareketListesi { get; set; }
        public virtual DbSet<vw_StokListesi> vw_StokListesi { get; set; }
        public virtual DbSet<vw_StokSayim> vw_StokSayim { get; set; }
        public virtual DbSet<vw_StokVaryantListesi> vw_StokVaryantListesi { get; set; }
        public virtual DbSet<vw_TeknikServis> vw_TeknikServis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ayarlar>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<Ayarlar>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<Cari>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<Cari>()
                .HasMany(e => e.CariHareket)
                .WithRequired(e => e.Cari)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cari>()
                .HasMany(e => e.CariStokFiyat)
                .WithRequired(e => e.Cari)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CariStokFiyat>()
                .Property(e => e.MaccAdress)
                .IsUnicode(false);

            modelBuilder.Entity<Fatura>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<Fatura>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<FaturaDetay>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FaturaDetay>()
                .Property(e => e.DovizBirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.VergiDairesi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.VergiNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.YetkiliAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.YetkiliSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.TelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.FaksNo)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.Ili)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.Ilcesi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.WebAdresi)
                .IsUnicode(false);

            modelBuilder.Entity<Isyeri>()
                .Property(e => e.TicaretSicilNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Isyeri>()
                .HasOptional(e => e.Ayarlar)
                .WithRequired(e => e.Isyeri);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.CariStokFiyat)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.Kasa)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.StokSayim)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Isyeri>()
                .HasMany(e => e.StokVaryant)
                .WithRequired(e => e.Isyeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.CariStokFiyat)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Fatura)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Satis)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marka>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.ModelAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Personel>()
                .HasMany(e => e.MaasHareket)
                .WithRequired(e => e.Personel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personel>()
                .HasMany(e => e.RutHareketPlani)
                .WithOptional(e => e.Personel)
                .HasForeignKey(e => e.PlasiyerID);

            modelBuilder.Entity<RutHareketPlani>()
                .Property(e => e.Gun)
                .IsUnicode(false);

            modelBuilder.Entity<RutHareketPlani>()
                .Property(e => e.MaccAdress)
                .IsUnicode(false);

            modelBuilder.Entity<Satis>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.BankaHesapHareket)
                .WithOptional(e => e.Satis)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.CariHareket)
                .WithOptional(e => e.Satis)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.Fatura)
                .WithOptional(e => e.Satis)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.Kasa)
                .WithOptional(e => e.Satis)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SatisDetay>()
                .Property(e => e.Miktari)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SatisDetay>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SatisDetay>()
                .HasMany(e => e.StokHareket)
                .WithOptional(e => e.SatisDetay)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sektor>()
                .Property(e => e.SektorAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.CariStokFiyat)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.SatisDetay)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokDepo)
                .WithOptional(e => e.Stok)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokETicaret)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokHareket)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokResim)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokSayimDetay)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.StokVaryant)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StokDepo>()
                .Property(e => e.KoridorNo)
                .IsUnicode(false);

            modelBuilder.Entity<StokDepo>()
                .Property(e => e.RafNo)
                .IsUnicode(false);

            modelBuilder.Entity<StokHareket>()
                .Property(e => e.Miktar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StokResim>()
                .Property(e => e.MaccAdress)
                .IsUnicode(false);

            modelBuilder.Entity<StokVaryant>()
                .HasMany(e => e.StokDepo)
                .WithOptional(e => e.StokVaryant)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.BankaHesap)
                .WithOptional(e => e.Tanim)
                .HasForeignKey(e => e.ParaTuruID);

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.BankaHesap1)
                .WithOptional(e => e.Tanim1)
                .HasForeignKey(e => e.BankaID);

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.StokDepo)
                .WithOptional(e => e.Tanim)
                .HasForeignKey(e => e.DepoID);

            modelBuilder.Entity<Tanim>()
                .HasMany(e => e.StokSayimDetay)
                .WithRequired(e => e.Tanim)
                .HasForeignKey(e => e.DepoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TanimGrup>()
                .HasMany(e => e.Tanim)
                .WithRequired(e => e.TanimGrup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vw_BankaHesap>()
                .Property(e => e.Bakiye)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_BankaHesapHareket>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Alacak)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Borc)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Bakiye)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.BakiyeDurumu)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CariHareket>()
                .Property(e => e.Sira)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Sira)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Maliyet)
                .HasPrecision(38, 4);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Kar)
                .HasPrecision(38, 4);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.YuzdeKar)
                .HasPrecision(38, 6);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<vw_FaturaDetay>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_FaturaDetay>()
                .Property(e => e.DovizBirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.SatisTarihi1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.SatisZamani1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.Miktari)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_SatisListesi>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_StokDetayliHesapEkstresi>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_StokHareketListesi>()
                .Property(e => e.Miktar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_StokListesi>()
                .Property(e => e.ToplamVarlik)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokListesi>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<vw_StokSayim>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamAlis)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamSatis)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamVarlik)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.ModelAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);
        }
    }
}
