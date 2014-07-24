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

namespace Animaciones
{
    /// <summary>
    /// Interaction logic for GeneralContent.xaml
    /// </summary>
    public partial class GeneralContent : Page
    {
        public GeneralContent()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Message.Show();
        }
    }
}
