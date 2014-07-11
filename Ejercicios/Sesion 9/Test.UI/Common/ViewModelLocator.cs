using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using Test.Logic.ViewModels;
using Text.Logic.Contracts;
using Text.Logic.Services;
using Text.Logic.Common;

namespace Test.UI.Common
{
    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().As<MainViewModel>().SingleInstance();
            builder.RegisterType<FakeApiService>().As<IApiService>();

            container = builder.Build(ContainerBuildOptions.None);

            BindableBase.Container = container;
        }

        public MainViewModel Main
        {
            get { return container.Resolve<MainViewModel>(); }
        }
    }
}
