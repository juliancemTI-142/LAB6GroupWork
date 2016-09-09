using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using ForwardingProject.Domain.Abstract;
using ForwardingProject.Domain.Context;

namespace ForwardingProject.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IDriverRepository>().To<EFDriverRepository>();
            kernel.Bind<ICustomerRepository>().To<EFCustomerRepository>();
            kernel.Bind<IBrokerRepository>().To<EFBrokerRepository>();
            kernel.Bind<ITruckRepository>().To<EFTruckRepository>();
            kernel.Bind<IInvoiceRepository>().To<EFInvoiceRepository>();
            kernel.Bind<ITrailerRepository>().To<EFTrailerRepository>();
        }
    }
}