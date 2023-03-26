using SiparisTakip.AspNetMvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SiparisTakip.AspNetMvcWebApi.Controllers
{
    public class StokController : ApiController
    {
        // GET: api/Stok
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Stok/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stok
        public void Post([FromBody]StokRequest value)
        {
        }

        // PUT: api/Stok/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stok/5
        public void Delete(int id)
        {
        }
    }
}
