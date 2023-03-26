using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces.Kullanici
{
    public interface IKullaniciService:IGenericService<SiparisTakip.Entity.Models.Kullanici>
    {
        SiparisTakip.Entity.Models.Kullanici KullaniciGiris(string kullaniciAdi,string parola);
    }
}
