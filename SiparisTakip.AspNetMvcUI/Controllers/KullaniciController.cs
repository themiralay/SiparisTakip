using SiparisTakip.AspNetMvcUI.Models;
using SiparisTakip.Bll.KullanciBll;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces.Kullanici;
using System.Web.Mvc;
using System.Web.Security;
using static SiparisTakip.AspNetMvcUI.Models.IslemSonucuEnum;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class KullaniciController : Controller
    {

        //IKullaniciService _kullaniciService = 
        //    new KullaniciManager(new EfKullaniciRepository());

        IKullaniciService _kullaniciService;
        tcTest.KPSPublicSoapClient tc = new tcTest.KPSPublicSoapClient();
       
        public KullaniciController(IKullaniciService kullaniciService)
        {
            this._kullaniciService = kullaniciService;
        }


        [HttpGet]
        public ActionResult KullaniciGiris()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult KullaniciGiris(Kullanici kullanici)
        //{
        //    try
        //    {
        //        var _kullanici = _kullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);
        //        if (_kullanici != null)
        //        {
        //            Session["KullaniciId"] = _kullanici.KullaniciID;
        //            Session["KullaniciAdi"] = _kullanici.KullaniciAdi + " " + _kullanici.KullaniciSoyadi;

        //            return RedirectToAction("Index", "Anasayfa");
        //        }
        //        else
        //        {

        //        }
        //    }
        //    catch (System.Exception error)
        //    {
        //        return RedirectToAction();
        //    }

        //    return new JsonResult();
        //}

        [HttpPost]
        public JsonResult KullaniciGiris(Kullanici kullanici)
        {
            IslemSonucModel islemSonucu;
            //dynamic abc;
            //abc.kodu = 1;
            //abc.aciklama = "efwefwe";

            try
            {
                var _kullanici = _kullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);
                if (_kullanici != null)
                {
                    //FormsAuthentication.SetAuthCookie("KullaniciId", false);
                    Session["KullaniciId"] = _kullanici.KullaniciID;
                    Session["KullaniciAdi"] = _kullanici.KullaniciAdi + " " + _kullanici.KullaniciSoyadi;

                    islemSonucu = new IslemSonucModel(IslemSonucKodlari.Basarili, "Kullanıcı Giriş Başarılı");
                }
                else
                {
                    islemSonucu = new IslemSonucModel(IslemSonucKodlari.Uyari, "Kullanıcı Giriş Başarısız");
                }
            }
            catch (System.Exception error)
            {
                islemSonucu = new IslemSonucModel(IslemSonucKodlari.Hata, "Kullanıcı Giriş Kontrol Sırasında Hata Oluştu." + error.Message);
            }

            return Json(islemSonucu);
        }

        public ActionResult OturumuKapat()
        {
            //FormsAuthentication.SignOut();
            Session.Abandon();
            Session["adi"] = "dssd";
            Session.Add("soyadi", "ahmet");
            Session["adi"] = null;
            Session.Remove("adi");//belirtilen keyi iis üzerinden siler
            Session.RemoveAll();//tümünü siler

            return RedirectToAction("","");
        }

        public ActionResult KullaniciKayit(Kullanici kullanici)
        {
            tcNoKontrol.KPSPublicV2SoapClient aa = new tcNoKontrol.KPSPublicV2SoapClient();
            //aa.KisiVeCuzdanDogrula()

            tc.TCKimlikNoDogrula(13232323, "şafak", "çakır", 1985);
            return View();
        }
    }
}