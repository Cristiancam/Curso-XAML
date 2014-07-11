using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Text.Logic.Contracts;
using Text.Logic.Helpers;
using Text.Logic.Common;

namespace Test.Logic.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private int totalPoints;

        public int TotalPoints
        {
            get { return totalPoints; }
            set 
            {
                Set<int>(ref totalPoints, value); 
            }
        }

        public EventViewModel NewEvent { get; set; }

        private ObservableCollection<EventViewModel> events;

        public ObservableCollection<EventViewModel> Events
        {
            get { return events; }
            set 
            {
                Set<ObservableCollection<EventViewModel>>(ref events, value);
            }
        }

        private IApiService apiService;

        public MainViewModel(IApiService apiService)
        {
            this.Events = new ObservableCollection<EventViewModel>();
            this.NewEvent = new EventViewModel();

            this.apiService = apiService;
            LoadData();
        }

        private async void LoadData()
        {
            var items = await apiService.GetItemsAsync();
            this.Events = ViewModelHelper.GetEvents(items);
        }

        public ICommand ClearCommand
        {
            get
            {
                return new RelayCommand(Clear);
            }
        }

        private void Clear()
        {
            foreach (var item in this.Events)
            {
                item.IsSelected = false;
            }
        }
    }
}
