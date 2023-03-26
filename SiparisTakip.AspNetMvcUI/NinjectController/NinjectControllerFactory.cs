using Ninject;
using SiparisTakip.Bll.Fatura;
using SiparisTakip.Bll.KullanciBll;
using SiparisTakip.Bll.Stok;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Interfaces.Fatura;
using SiparisTakip.Interfaces.Kullanici;
using SiparisTakip.Interfaces.Stok;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace SiparisTakip.AspNetMvcUI.NinjectController
{
    public class NinjectControllerFactory: DefaultControllerFactory
    {
        private readonly IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBllBindings();
        }
        private void AddBllBindings()
        {
            ninjectKernel.Bind<IKullaniciService>()
                .To<KullaniciManager>()
                .WithConstructorArgument("kullaniciDal", 
                new EfKullaniciRepository());

            ninjectKernel.Bind<IStokService>()
                .To<StokManager>()
                .WithConstructorArgument("stokDal", new EfStokRepository());

            ninjectKernel.Bind<IFaturaService>()
                .To<FaturaManager>()
                .WithConstructorArgument("faturaDal", new EfFaturaRepository());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}