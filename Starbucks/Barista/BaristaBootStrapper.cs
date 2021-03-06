using Rhino.ServiceBus.Internal;
using Rhino.ServiceBus.Sagas.Persisters;
using Microsoft.Practices.Unity;
using Rhino.ServiceBus.Unity;

namespace Starbucks.Barista
{
    public class BaristaBootStrapper : UnityBootStrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType(typeof(ISagaPersister<>), typeof(InMemorySagaPersister<>),
                                   new ContainerControlledLifetimeManager());
        }

        protected override bool IsTypeAcceptableForThisBootStrapper(System.Type t)
        {
            return t.Namespace == "Starbucks.Barista";
        }
    }
}
