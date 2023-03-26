using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.FaturaDal
{
    public interface IFaturaDal
    {
        Fatura Kaydet(Fatura entity);
        List<Fatura> Listele();
        List<Fatura> Listele(Expression<Func<Fatura, bool>> predicate);
        Fatura Getir(int id);
        int Guncelle(Fatura entity);

        bool Sil(int id);

        bool Sil(Fatura entity);

        IQueryable FaturaRaporu(DateTime baslangic, DateTime bitis);
    }
}
