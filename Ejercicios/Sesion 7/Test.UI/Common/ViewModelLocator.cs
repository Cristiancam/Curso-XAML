﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using Test.Logic.ViewModels;

namespace Test.UI.Common
{
    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().As<MainViewModel>().SingleInstance();

            container = builder.Build(ContainerBuildOptions.None);
        }

        public MainViewModel Main
        {
            get { return container.Resolve<MainViewModel>(); }
        }
    }
}
