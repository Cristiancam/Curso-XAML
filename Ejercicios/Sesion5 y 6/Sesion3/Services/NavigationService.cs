using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3.Services
{
    public class NavigationService
    {
        public void Navigate(string window)
        {
            switch (window)
            {
                case "CluesWindow":
                    CluesWindow newWindow = new CluesWindow();
                    newWindow.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
