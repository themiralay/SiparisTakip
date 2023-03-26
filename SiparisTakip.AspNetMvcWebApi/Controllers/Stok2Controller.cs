using SiparisTakip.AspNetMvcWebApi.Models;
using SiparisTakip.AspNetMvcWebApi.Models.Request;
using SiparisTakip.AspNetMvcWebApi.Models.Response;
using SiparisTakip.Bll.Stok;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces.Stok;
using System;
using System.Linq;
using System.Web.Http;

namespace SiparisTakip.AspNetMvcWebApi.Controllers
{
    [RoutePrefix("StokApi/Stok2")]
    public class Stok2Controller : ApiController
    {
        IStokService StokService = new StokManager(new EfStokRepository());

        //[HttpGet]
        //[Route("Listele")]
        //public List<Stok> Listele()
        //{
        //    return StokService.Listele();
        //}

        //[HttpGet]
        //[Route("Getir")]
        //public Stok Getir(int stokId)
        //{
        //    return StokService.Getir(stokId);
        //}

        [HttpPost]
        [Route("StokKaydet")]
        public StokResponse StokKaydet([FromBody]Models.Request.StokRequest stok)
        {
            StokResponse response;
            try
            {
                if (stok.aut.password != "1234" || stok.aut.username != "ali")
                {
                    return response = new StokResponse()
                    {
                        status = new Models.Attribute.Status()
                        {
                            code = (int)Enums.MessageCode.OturumBilgisi,
                            message = Enums.MessageCode.OturumBilgisi.ToString()
                        }
                    };
                }

                var entity = StokService.Kaydet(new Stok()
                {
                    StokID = stok.stok.StokID,
                    StokAdi = stok.stok.StokAdi,
                    AlisFiyati = stok.stok.AlisFiyati,
                    SatisFiyati = stok.stok.SatisFiyati,
                    KdvOrani = stok.stok.KdvOrani,
                    StokGrubuID = stok.stok.StokGrubuID
                });

                if (entity != null)
                {
                    return response = new StokResponse()
                    {
                        status = new Models.Attribute.Status()
                        {
                            code = (int)Enums.MessageCode.Basarili,
                            message = Enums.MessageCode.Basarili.ToString()
                        }
                        ,
                        StokId = entity.StokID
                    };
                }
                else
                {
                    return response = new StokResponse()
                    {
                        status = new Models.Attribute.Status()
                        {
                            code = (int)Enums.MessageCode.Basarisiz,
                            message = Enums.MessageCode.Basarisiz.ToString()
                        }
                    };
                }
            }
            catch (Exception error)
            {

                return response = new StokResponse()
                {
                    status = new Models.Attribute.Status()
                    {
                        code = (int)Enums.MessageCode.Hata,
                        message = Enums.MessageCode.Hata.ToString() + error.Message
                    }
                };
            }
        }


        [HttpPost]
        [Route("StokListele")]
        public StokListeleResponse StokListele(StokListeRequest listeRequest)
        {
            StokListeleResponse response;
            try
            {

                if (listeRequest.aut.password != "1234" || listeRequest.aut.username != "ali")
                {
                    return response = new StokListeleResponse()
                    {
                        status = new Models.Attribute.Status()
                        {
                            code = (int)Enums.MessageCode.OturumBilgisi,
                            message = Enums.MessageCode.OturumBilgisi.ToString()
                        }
                    };
                }

                var liste = StokService.Listele().Select(x => new
                {
                    x.StokID,
                    x.BarkodNo,
                    x.StokGrubuID,
                    x.StokKodu,
                    x.StokAdi,
                    x.AlisFiyati,
                    x.SatisFiyati,
                    x.KdvOrani
                }).ToList()
                .Select(x => new SiparisTakip.AspNetMvcWebApi.Models.Attribute.Stok()
                {
                    BarkodNo = x.BarkodNo,
                    AlisFiyati = x.AlisFiyati ?? 0,
                    KdvOrani = x.KdvOrani ?? 0,
                    SatisFiyati = x.SatisFiyati ?? 0,
                    StokAdi = x.StokAdi,
                    StokGrubuID = x.StokGrubuID ?? 0,
                    StokID = x.StokID,
                    StokKodu = x.StokKodu
                }).ToList();


                return response = new StokListeleResponse()
                {
                    status = new Models.Attribute.Status()
                    {
                        code = (int)Enums.MessageCode.Basarili,
                        message = Enums.MessageCode.Basarili.ToString()
                    },
                    stokListesi = liste
                };
            }
            catch (Exception error)
            {
                return response = new StokListeleResponse()
                {
                    status = new Models.Attribute.Status()
                    {
                        code = (int)Enums.MessageCode.Hata,
                        message = Enums.MessageCode.Hata.ToString() + error.Message
                    }
                };
            }
        }


        public IHttpActionResult Kaydet()
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {

                return NotFound();
            }

        }


        [HttpPost]
        [Route("StokKaydet2")]
        public StokResponse StokKaydet2([FromBody]Models.Request.StokRequest stok,int kullaniciId)
        {
            return null;
           
        }
    }

}
