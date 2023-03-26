using SiparisTakip.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using System.Linq.Expressions;
using SiparisTakip.Bll.Stok;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;

namespace SiparisTakip.WcfServiceLibrary
{
    public class StokService : IStokService
    {
        IStokService stokService = new StokManager(new EfStokRepository());
        public Stok Getir(int id)
        {
            return stokService.Getir(id);
        }

        public int Guncelle(Stok entity)
        {
            return stokService.Guncelle(entity);
        }

        public Stok Kaydet(Stok entity)
        {
            return stokService.Kaydet(entity); ;
        }

        public List<Stok> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Stok> Listele2()
        {
            throw new NotImplementedException();
        }

        public List<Stok> Listele3()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Stok entity)
        {
            throw new NotImplementedException();
        }
    }
}
