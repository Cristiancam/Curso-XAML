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

namespace Test.UI.Controls
{
    /// <summary>
    /// Interaction logic for Formulario.xaml
    /// </summary>
    public partial class Formulario : UserControl
    {
        public Formulario()
        {
            InitializeComponent();
        }

        public SolidColorBrush FormBackground
        {
            get { return (SolidColorBrush)GetValue(FormBackgroundProperty); }
            set { SetValue(FormBackgroundProperty, value); }
        }

        public static readonly DependencyProperty FormBackgroundProperty =
            DependencyProperty.Register("FormBackground", typeof(SolidColorBrush), typeof(Formulario), null);

        public string Event
        {
            get { return (string)GetValue(EventProperty); }
            set { SetValue(EventProperty, value); }
        }

        public static readonly DependencyProperty EventProperty =
            DependencyProperty.Register("Event", typeof(string), typeof(Formulario), null);

        public int Points
        {
            get { return (int)GetValue(PointsProperty); }
            set { SetValue(PointsProperty, value); }
        }

        public static readonly DependencyProperty PointsProperty =
            DependencyProperty.Register("Points", typeof(int), typeof(Formulario), null);

        public ICommand SaveCommand
        {
            get { return (ICommand)GetValue(SaveCommandProperty); }
            set { SetValue(SaveCommandProperty, value); }
        }

        public static readonly DependencyProperty SaveCommandProperty =
            DependencyProperty.Register("SaveCommand", typeof(ICommand), typeof(Formulario), null);

    }
}
