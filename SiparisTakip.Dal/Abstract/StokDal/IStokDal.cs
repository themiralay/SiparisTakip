using System.Collections.Generic;
using SiparisTakip.Entity.Models;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace SiparisTakip.Dal.Abstract.StokDal
{
    public interface IStokDal
    {
        Stok Kaydet(Stok entity);
        List<Stok> Listele();
        List<Stok> Listele(Expression<Func<Stok,bool>> predicate);
        Stok Getir(int id);
        int Guncelle(Stok entity);

        bool Sil(int id);

        bool Sil(Stok entity);

        IQueryable StokListesi();
    }
}
