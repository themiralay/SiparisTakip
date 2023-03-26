using System.Collections.Generic;
using SiparisTakip.Entity.Models;
using System.Linq.Expressions;
using System;

namespace SiparisTakip.Dal.Abstract.KullaniciDal
{
    public interface IKullaniciDal
    {
        Kullanici Kaydet(Kullanici entity);
        List<Kullanici> Listele();
        List<Kullanici> Listele(Expression<Func<Kullanici,bool>> predicate);
        Kullanici Getir(int id);
        int Guncelle(Kullanici entity);

        bool Sil(int id);

        bool Sil(Kullanici entity);

        Kullanici KullaniciGiris(string kullaniciAdi, string sifre);
    }
}
