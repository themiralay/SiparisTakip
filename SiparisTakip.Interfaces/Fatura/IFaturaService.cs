using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces.Fatura
{
    public interface IFaturaService:IGenericService<SiparisTakip.Entity.Models.Fatura>
    {
        IQueryable FaturaRaporu(DateTime baslangic,DateTime bitis);
    }
}
