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

namespace Media
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.sound.Play();
        }

        private void btnStop_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.sound.Stop();
        }

        private void btnPause_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.sound.Pause();
        }

        private void btnResume_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void MediaTimeline_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            this.lblPosition.Text = media.Position.ToString();
            this.slPosition.Value = media.Position.TotalMilliseconds;
        }

        private void media_MediaEnded(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void media_MediaOpened(object sender, System.Windows.RoutedEventArgs e)
        {
            this.slPosition.Maximum = media.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
    }
}
