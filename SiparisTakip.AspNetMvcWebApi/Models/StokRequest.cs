using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcWebApi.Models
{
    public class StokRequest
    {
        public int StokId { get; set; }
        public string StokAdi { get; set; }
        public string Birimi { get; set; }
        public decimal Fiyati { get; set; }
    }
}