using SiparisTakip.Interfaces.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SiparisTakip.Dal.Abstract.KullaniciDal;
using SiparisTakip.Entity.Models;

namespace SiparisTakip.Bll.KullanciBll
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            this._kullaniciDal = kullaniciDal;
        }

        public Kullanici Getir(int id)
        {
            return _kullaniciDal.Getir(id);
        }

        public int Guncelle(Kullanici entity)
        {
            return _kullaniciDal.Guncelle(entity);
        }

        public Kullanici Kaydet(Kullanici entity)
        {
            return _kullaniciDal.Kaydet(entity);
        }

        public Kullanici KullaniciGiris(string kullaniciAdi, string parola)
        {
            try
            {
                if(string.IsNullOrEmpty(kullaniciAdi.Trim()) || string.IsNullOrEmpty(parola.Trim()))
                {
                    throw new Exception("Kullanıcı Adı veya Parola Boş Geçilemez.");
                }

                var sifre = new ToPasswordRepository().Md5(parola);
                var kullanici=_kullaniciDal.KullaniciGiris(kullaniciAdi, sifre);
                if (kullanici == null)
                    throw new Exception("Kullanıcı ve Parola Uyuşmuyor.");
                else
                    return kullanici;
            }
            catch (Exception error)
            {
                throw new Exception("Kullanıcı Giriş Hata:"+error.Message);
            }
        }

        public List<Kullanici> Listele()
        {
            return _kullaniciDal.Listele();
        }

        public List<Kullanici> Listele(Expression<Func<Kullanici, bool>> predicate)
        {
            return _kullaniciDal.Listele(predicate);
        }

        public bool Sil(int id)
        {
            return _kullaniciDal.Sil(id);
        }

        public bool Sil(Kullanici entity)
        {
            return _kullaniciDal.Sil(entity);
        }
    }
}
