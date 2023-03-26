using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Araclar
{
    public class YetkiKontrolu:ActionFilterAttribute
    {
        //public YetkiKontrolu(string a)
        //{
        //    this.modulAdi = a;
        //}
        //private string modulAdi;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.HttpContext.Session["KullaniciId"]==null || 
                string.IsNullOrEmpty(filterContext.HttpContext.Session["KullaniciId"].ToString()))
            {
                //filterContext.HttpContext.Response.Redirect("/Kullanici/KullaniciGiris");
                filterContext.Result = new 
                    RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                    { { "controller", "Kullanici" }, { "action", "KullaniciGiris" } });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}