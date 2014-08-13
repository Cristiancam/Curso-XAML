using DemoPrism.ModuleAUnity.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrism.ModuleAUnity
{
    public class ModuleAUnityModule: IModule
    {
        private IRegionManager regionManager;

        public ModuleAUnityModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(ToolbarView));
            regionManager.RegisterViewWithRegion("StatusbarRegion", typeof(StatusbarView));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }
    }
}
