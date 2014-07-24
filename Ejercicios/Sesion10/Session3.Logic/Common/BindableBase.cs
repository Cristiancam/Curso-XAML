using Autofac;
using System.ComponentModel;

namespace Sesion3.Common
{
    public class BindableBase : INotifyPropertyChanged
    {
        public static Autofac.IContainer Container {get; set; }

        public static T GetInstance<T>()
        {
            return Container.Resolve<T>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseChange(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
