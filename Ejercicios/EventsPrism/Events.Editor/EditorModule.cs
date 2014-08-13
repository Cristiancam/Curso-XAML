using Events.Editor.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Editor
{
    public class EditorModule : IModule
    {
        private IRegionManager regionManager;
        private IUnityContainer container;

        public EditorModule(IRegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("EventEditorRegion", typeof(EventEditorView));
        }
    }
}
