using SiparisTakip.Bll.Stok;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Interfaces.Fatura;
using SiparisTakip.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class AnasayfaController : Controller
    {
        IStokService _stokService;
        IFaturaService _faturaService;

        //IStokService stokService = new StokManager(new EfStokRepository());

        public AnasayfaController(IStokService stokService,IFaturaService faturaService)
        {
            this._stokService = stokService;
            this._faturaService = faturaService;
        }
        public ActionResult Index()
        {
            var liste = _stokService.Listele();
            return View(liste);
        }
    }
}