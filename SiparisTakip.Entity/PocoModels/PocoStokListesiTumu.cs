using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Entity.PocoModels
{
    [NotMapped]

    public class PocoStokListesiTumu:Stok
    {
        public string StokGrubu { get; set; }
    }
}
