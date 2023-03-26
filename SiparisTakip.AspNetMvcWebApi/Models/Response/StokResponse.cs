using SiparisTakip.AspNetMvcWebApi.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcWebApi.Models.Response
{
    public class StokResponse
    {
        public Status status { get; set; }

        public int StokId { get; set; }
    }
}