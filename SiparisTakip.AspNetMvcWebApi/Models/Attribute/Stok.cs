using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcWebApi.Models.Attribute
{
    public class Stok
    {
        public int StokID { get; set; }

        public string BarkodNo { get; set; }

        public string StokKodu { get; set; }

        public int StokGrubuID { get; set; }

        public string StokAdi { get; set; }

        public decimal AlisFiyati { get; set; }

        public decimal KdvOrani { get; set; }

        public decimal SatisFiyati { get; set; }

    }
}