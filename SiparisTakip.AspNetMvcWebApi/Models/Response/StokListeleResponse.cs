using SiparisTakip.AspNetMvcWebApi.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcWebApi.Models.Response
{
    public class StokListeleResponse
    {
        public Status status { get; set; }

        public List<Stok> stokListesi { get; set; }
    }
}