using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animaciones
{
	/// <summary>
	/// Interaction logic for Message.xaml
	/// </summary>
	public partial class Message : UserControl
	{
		public Message()
		{
			this.InitializeComponent();
		}

        public void Show()
        {
            Storyboard animation 
                = (Storyboard)this.Resources["MessageIn"];
            animation.Begin();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            Storyboard animation
                = (Storyboard)this.Resources["MessageOut"];
            animation.Begin();
        }
	}
}