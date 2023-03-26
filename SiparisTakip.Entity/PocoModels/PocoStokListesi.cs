using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Entity.PocoModels
{
    public class PocoStokListesi
    {
        public string FaturaNo { get; set; }
        public int StokID { get; set; }
        public string BarkodNo { get; set; }
        public string StokAdi { get; set; }
        public string StokGrubu { get; set; }
        public string Birimi { get; set; }
    }
}
