using Ninject;
using Sushi.DependencyAndRepositories.Repositories;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Sushi.DepencyAndRepositories
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBinding();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBinding()
        {
            kernel.Bind<ICategoryRepositories>().To<CatalogRepository>();
            kernel.Bind<IOrdersRepository>().To<OrdersRepository>();
            kernel.Bind<IProductRepositories>().To<ProductRepository>();
            kernel.Bind<DataManager>().To<DataManager>().InSingletonScope();
            kernel.Bind<ICart>().To<Cart>().InSingletonScope();
        }
    }
}