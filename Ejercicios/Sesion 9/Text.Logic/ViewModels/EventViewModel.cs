using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Text.Logic.Common;
using Text.Logic.Contracts;
using Text.Logic.Helpers;

namespace Test.Logic.ViewModels
{
    public class EventViewModel : BindableBase
    {
        IApiService apiService;

        public EventViewModel()
        {
            this.apiService = GetInstance<IApiService>();
        }

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

        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(Save);
            }
        }

        private async void Save()
        {
            MainViewModel main = GetInstance<MainViewModel>();

            await apiService
                .SaveItem(ViewModelHelper.GetItem(main.NewEvent));

            main.Events.Add(main.NewEvent);
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
            MainViewModel main = GetInstance<MainViewModel>();
          
            this.IsSelected = !this.IsSelected;

            if (this.IsSelected)
                main.TotalPoints += this.Points;
            else
                main.TotalPoints -= this.Points;
        }
    }
}
