using SiparisTakip.Dal.Abstract.StokDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;
using SiparisTakip.Entity.PocoModels;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfStokRepository : IStokDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Stok Getir(int id)
        {
            return SiparisTakipContext.Stok.AsNoTracking().Where(x=>x.StokID==id).SingleOrDefault();
        }

        public int Guncelle(Stok entity)
        {
            SiparisTakipContext.Stok.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Stok Kaydet(Stok entity)
        {
            using (var aaa = new SiparisTakipContext())
            {
                aaa.Stok.Add(entity);
                SiparisTakipContext.SaveChanges();
                return entity;
            }
        }

        public List<Stok> Listele()
        {
            return SiparisTakipContext.Stok.AsNoTracking().ToList();
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> predicate)
        {
            return SiparisTakipContext.Stok.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            //var stk= SiparisTakipContext.Stok.AsNoTracking().Where(x => x.StokID == id).SingleOrDefault();
            var stok = Getir(id);
            return Sil(stok);
        }


        public bool Sil(Stok entity)
        {
            SiparisTakipContext.Stok.Remove(entity);
            return SiparisTakipContext.SaveChanges()>0;
        }

        public PocoStokListesi StokListesi(string id)
        {
            var sonuc = SiparisTakipContext.Database.SqlQuery<PocoStokListesi>(@"select top 1
                                                            stk.StokID,stk.BarkodNo,stk.StokAdi,
                                                            sg.TanimAdi as StokGrubu,br.TanimAdi as Birimi
                                                            from Stok stk
                                                            left outer join Tanim sg on (sg.TanimID=stk.StokGrubuID)
                                                            left outer join Tanim br on (br.TanimID=stk.StokBirimID)").AsQueryable();

            //SiparisTakipContext.Fatura.Include("FaturaDetay")



            var sonuc2 = SiparisTakipContext.Fatura.AsNoTracking()
                .Join(SiparisTakipContext.FaturaDetay, f => f.FaturaID, fd => fd.FaturaID, (f, fd) => new { f, fd })
                .Join(SiparisTakipContext.Stok, fd1 => fd1.fd.StokID, s => s.StokID, (fd1, s) => new PocoStokListesi()
                {
                    BarkodNo = fd1.fd.BarkodNo,
                    StokAdi = fd1.fd.StokAdi,
                    StokID = fd1.fd.StokID ?? 0,
                    FaturaNo = fd1.f.FaturaNo
                }).OrderBy(x=>x.FaturaNo).ThenBy(y=>y.BarkodNo).OrderByDescending(t=>t.StokAdi).ToList()[0];

              return sonuc2;
            //Fatura f = new Fatura();
            //f.FaturaNo = "123";
            //f.FaturaDetay = new List<FaturaDetay>()
            //{
            //    new FaturaDetay()
            //    {
            //        StokID=1,
            //        StokAdi="Peçete"
            //    },
            //    new FaturaDetay()
            //    {
            //         StokID=2,
            //        StokAdi="Selpak"
            //    }
            //};

            //SiparisTakipContext.Fatura.AddOrUpdate();


            //SiparisTakipContext.Database.ExecuteSqlCommand("delete from Stok where StokID=" + id + "");
            //SiparisTakipContext.Database.ExecuteSqlCommand("delete from Stok where StokID={0})",id)
        }

        public IQueryable StokListesi()
        {
            throw new NotImplementedException();
        }

        //public IQueryable StokListesi()
        //{
        //    //checked
        //    //{

        //    //}
        //    //unchecked
        //    //{

        //    //}


        //    //int deger = 0;
        //    //decimal? deger2 = null;
        //    //DateTime? dt = null;

        //    //Nullable<int> b = null;
        //    //int? deger3 =null;

        //    //var sonuc = deger2 ?? 0;

        //    //var sonuc2 = deger2 == null ? 0 : 1;

        //    ////primitiv tip//ilker
        //    ////stack
        //    //int g = 10;//4 byte

        //    ////kullanıcı tanımlı tip//referans
        //    ////heap
        //    //Int32 g2 = 10;//4 byte
        //}
    }
}
