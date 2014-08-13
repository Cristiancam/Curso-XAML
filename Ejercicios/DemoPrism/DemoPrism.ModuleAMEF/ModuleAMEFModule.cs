using DemoPrism.ModuleAMEF.Views;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrism.ModuleAMEF
{
    [ModuleExport(typeof(ModuleAMEFModule), 
        InitializationMode = InitializationMode.WhenAvailable)]
    public class ModuleAMEFModule : IModule
    {
        private IRegionManager regionManager;

        [ImportingConstructor]
        public ModuleAMEFModule(IRegionManager regionManager)
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
