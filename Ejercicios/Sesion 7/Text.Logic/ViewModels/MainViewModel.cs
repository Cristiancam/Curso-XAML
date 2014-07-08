using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Test.Logic.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public int TotalPoints { get; set; }
        public ObservableCollection<EventViewModel> Events { get; set; }

        public ICommand ClearCommand
        {
            get
            {
                return new RelayCommand(Clear);
            }
        }

        private void Clear()
        {

        }
    }
}
