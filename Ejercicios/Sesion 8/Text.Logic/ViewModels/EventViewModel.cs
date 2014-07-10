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
        private string description;

        public string Description
        {
            get { return description; }
            set 
            {
                Set<string>(ref description, value);
            }
        }
        
        public int Points { get; set; }
        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set 
            {
                Set<bool>(ref isSelected, value);
            }
        }


        public ICommand SelectEventCommand
        {
            get
            {
                return new RelayCommand(SelectEvent);
            }
        }

        private void SelectEvent()
        {
            this.IsSelected = !this.IsSelected;
        }
    }
}
