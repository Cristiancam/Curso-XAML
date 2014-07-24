
using Autofac;
using Autofac.Builder;
using ClassLibrary1.Contracts;
using Sesion3.Common;
using Sesion3.Services;
using Sesion3.ViewModels;
using Session3.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session.Locator
{
    public class ViewModelLocator
    {
        IContainer container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().As<MainViewModel>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            
            builder.RegisterType<DialogService>().As<IDialogService>();

            container = builder.Build(ContainerBuildOptions.None);

            BindableBase.X = container;
        }


        public MainViewModel Main {
            get {
                return container.Resolve<MainViewModel>();
            }
        }

    }
}
