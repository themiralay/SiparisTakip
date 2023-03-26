using SiparisTakip.Dal.Abstract.FaturaDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using System.Linq.Expressions;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfFaturaRepository : IFaturaDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();

        public IQueryable FaturaRaporu(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public Fatura Getir(int id)
        {
            return SiparisTakipContext.Fatura.AsNoTracking().Where(x => x.FaturaID == id).SingleOrDefault();

        }

        public int Guncelle(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public Fatura Kaydet(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public List<Fatura> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Fatura> Listele(Expression<Func<Fatura, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Fatura entity)
        {
            throw new NotImplementedException();
        }
    }
}
