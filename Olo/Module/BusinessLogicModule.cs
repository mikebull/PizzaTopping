using Ninject.Modules;
using Olo.Factory;
using Olo.Factory.Interface;
using Olo.Service;
using Olo.Service.Interface;

namespace Olo.Module
{
    /// <summary>
    /// The business logic module.
    /// </summary>
    public class BusinessLogicModule : NinjectModule
    {
        /// <summary>
        /// Bindings for Ninject
        /// </summary>
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
            Bind<IClientFactory>().To<OrderClientFactory>();
            Bind<IRequestFactory>().To<OrderRequestFactory>();
        }
    }
}
