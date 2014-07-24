using ClassLibrary1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sesion3.Services
{
    class DialogService : IDialogService
    {
        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }
}
