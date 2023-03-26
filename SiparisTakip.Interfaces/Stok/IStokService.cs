using System.Collections.Generic;
using System.ServiceModel;

namespace SiparisTakip.Interfaces.Stok
{
    [ServiceContract]
    public interface IStokService:IGenericService<SiparisTakip.Entity.Models.Stok>
    {
        [OperationContract]
        List<SiparisTakip.Entity.Models.Stok> Listele2();

        List<SiparisTakip.Entity.Models.Stok> Listele3();
    }
}
