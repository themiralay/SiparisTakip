using SiparisTakip.Dal.Abstract.KullaniciDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;
using SiparisTakip.Dal.Abstract.KullaniciDal;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Kullanici Getir(int id)
        {
            return SiparisTakipContext.Kullanici.AsNoTracking().Where(x=>x.KullaniciID==id).SingleOrDefault();
        }

        public int Guncelle(Kullanici entity)
        {
            SiparisTakipContext.Kullanici.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Kullanici Kaydet(Kullanici entity)
        {
            SiparisTakipContext.Kullanici.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }
        public Kullanici KullaniciGiris(string kullaniciAdi, string sifre)
        {
            return SiparisTakipContext.Kullanici
                .Where(x => x.KullaniciKodu == kullaniciAdi && x.Sifre == sifre)
                .SingleOrDefault();
        }

        public List<Kullanici> Listele()
        {
            return SiparisTakipContext.Kullanici.AsNoTracking().ToList();
        }

        public List<Kullanici> Listele(Expression<Func<Kullanici, bool>> predicate)
        {
            return SiparisTakipContext.Kullanici.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            //var stk= SiparisTakipContext.Kullanici.AsNoTracking().Where(x => x.KullaniciID == id).SingleOrDefault();
            var Kullanici = Getir(id);
            return Sil(Kullanici);
        }


        public bool Sil(Kullanici entity)
        {
            SiparisTakipContext.Kullanici.Remove(entity);
            return SiparisTakipContext.SaveChanges()>0;
        }
    }
}
