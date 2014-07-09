using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Test.Logic.ViewModels
{
    public class EventViewModel : ViewModelBase
    {
        public string Description { get; set; }
        public int Points { get; set; }
        public bool IsSelected { get; set; }

        public ICommand SelectEventCommand
        {
            get
            {
                return new RelayCommand(SelectEvent);
            }
        }

        private void SelectEvent()
        {
            
        }
    }
}
