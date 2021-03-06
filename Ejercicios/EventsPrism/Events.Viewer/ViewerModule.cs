﻿using Events.Viewer.Services;
using Events.Viewer.ViewModels;
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
            RegisterDataTypes();

            if (regionManager.Regions.ContainsRegionWithName("SloganRegion"))
            {
                regionManager.Regions["SloganRegion"]
                    .Add(this.container.Resolve<ISloganViewModel>().View);
            }

            if (regionManager.Regions.ContainsRegionWithName("SponsorsRegion"))
            {
                regionManager.Regions["SponsorsRegion"]
                    .Add(this.container.Resolve<ISponsorsViewModel>().View);
            }
        }

        private void RegisterDataTypes()
        {

            container.RegisterType<IEventViewModel, EventViewModel>();
            container.RegisterType<ISponsorsView, SponsorsView>();
            //container.RegisterType<ISponsorsViewModel, SponsorsViewModel>();
            container.RegisterType<ISloganView, SloganView>();
            //container.RegisterType<ISloganViewModel, SloganViewModel>();
            container.RegisterType<IApiService, ApiService>();

        }
    }
}
