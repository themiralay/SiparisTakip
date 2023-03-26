using SiparisTakip.AspNetMvcUI.Araclar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    //[Authorize]
    [YetkiKontrolu]
    public class StokController : Controller
    {
        public ActionResult Index()
        {
            //if (Session["KullaniciId"] == null)
            //    return RedirectToAction("KullaniciGiris","Kullanici");

            return View();
        }

        //[Authorize]
        //[YetkiKontrolu("Giris")]
        [YetkiKontrolu]
        public ActionResult Kaydet()
        {
            return View();
        }

        //[Authorize]
        //[YetkiKontrolu("Yonetici")]
        public ActionResult Sil()
        {
            return View();
        }
        //[Authorize]
        //[YetkiKontrolu("Admin")]
        public ActionResult Guncelle()
        {
            return View();
        }

        public decimal KDVHEsapla(decimal tutar,byte kdvOrani)
        {
            return (decimal)23.5;
        }
    }
}