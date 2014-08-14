using Events.Viewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Events.Viewer.Views
{
    /// <summary>
    /// Interaction logic for SponsorsView.xaml
    /// </summary>
    public partial class SponsorsView : UserControl, ISponsorsView
    {
        public SponsorsView()
        {
            InitializeComponent();
        }

        public ViewModels.IEventViewModel ViewModel
        {
            get
            {
                return this.DataContext as IEventViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
    }
}
