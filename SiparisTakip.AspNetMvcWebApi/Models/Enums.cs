using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcWebApi.Models
{
    public class Enums
    {
        public enum MessageCode
        {
            [Description("İşlem Başarılı.")]
            Basarili=100,

            [Description("İşlem Başarısız.")]
            Basarisiz =200,

            [Description("İşlem Hatalı.")]
            Hata =300,

            [Description("Gelen TC Kimlik No Uyumsuz.")]
            TCNoUyumsuzlufu =301,

            [Description("Listeleme Hatası.")]
            ListeleHatası =302,

            [Description("Kullanıcı Adı veya Parola Yanlış.")]
            OturumBilgisi = 400
        }
    }
}