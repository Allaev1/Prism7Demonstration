using System;
using Prism.Regions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using FirstModuleProject.Views;
using Prism.Ioc;
using Prism.Unity;

namespace FirstModuleProject
{
    public class FirstModule : IModule
    {
        IRegionManager regionManager;

        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager = containerProvider.Resolve<IRegionManager>();

            regionManager.RequestNavigate("ContentRegion", "ViewB");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();

            containerRegistry.RegisterForNavigation<ViewA1>();
            containerRegistry.RegisterForNavigation<ViewA2>();
        }
    }
}
