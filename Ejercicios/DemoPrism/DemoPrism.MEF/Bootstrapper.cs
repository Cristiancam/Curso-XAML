using DemoPrism.ModuleAMEF;
using Microsoft.Practices.Prism.MefExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoPrism.MEF
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            
            AggregateCatalog.Catalogs
                .Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));

            AggregateCatalog.Catalogs
                .Add(new AssemblyCatalog(typeof(ModuleAMEFModule).Assembly));
        }
    }
}
