using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3.Common
{
    public class BindableBase : INotifyPropertyChanged
    {
        public static IContainer X {get; set; }

        public static T GetInstance<T>()
        {
            return X.Resolve<T>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseChange(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
