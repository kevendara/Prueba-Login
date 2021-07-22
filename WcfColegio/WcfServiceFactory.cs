using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Unity.Wcf;

namespace WcfColegio
{
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            //base.ConfigureContainer();

            // register all your components with the container here
            // container
            //    .RegisterType<IService1, Service1>()
            //    .RegisterType<DataContext>(new HierarchicalLifetimeManager());
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //IUnityContainer container = new UnityContainer();
            container.RegisterInstance<IUnityContainer>(container);
            //container.RegisterType<IUnityContainer>(new InjectionConstructor());
            section.Configure(container, "containerOne");

        }
    }
}