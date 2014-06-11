using System.Windows.Input;
using Sesion3.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sesion3.ViewModels
{
    public class PlayerViewModel : BindableBase
    {
        public string Name { get; set; }
        public string Answer { get; set; }
        public string Photo { get; set; }
        public bool WasDiscovered { get; set; }

        public ObservableCollection<ClueViewModel> Clues { get; set; }

        public ICommand ShowCluesCommand 
        {
            get { return new CommandBase(ShowClues); }
        }

        private void ShowClues()
        {
            MessageBox.Show("Invocacion al botón");
        }
    }
}
