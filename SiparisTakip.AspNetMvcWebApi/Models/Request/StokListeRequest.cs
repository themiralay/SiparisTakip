using SiparisTakip.AspNetMvcWebApi.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcWebApi.Models.Request
{
    public class StokListeRequest
    {
        public Aut aut { get; set; }

        public int stokGrubuId { get; set; }
    }
}