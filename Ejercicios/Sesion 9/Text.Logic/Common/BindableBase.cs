using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Text.Logic.Common
{
    public class BindableBase : ViewModelBase
    {
        public static IContainer Container { get; set; }
        
        public T GetInstance<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
