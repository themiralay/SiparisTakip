using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    [ServiceContract]
    public interface IGenericService<T>
    {
        [OperationContract]
        T Kaydet(T entity);
        List<T> Listele();
        List<T> Listele(Expression<Func<T, bool>> predicate);
        T Getir(int id);
        int Guncelle(T entity);

        bool Sil(int id);

        bool Sil(T entity);
    }
}
