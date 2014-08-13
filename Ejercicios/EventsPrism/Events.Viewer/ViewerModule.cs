using Events.Viewer.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer
{
    public class ViewerModule : IModule
    {
        private IRegionManager regionManager;
        private IUnityContainer container;

        public ViewerModule(IRegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("SloganRegion", typeof(SloganView));
            regionManager.RegisterViewWithRegion("SponsorsRegion", typeof(SponsorsView));
        }
    }
}
