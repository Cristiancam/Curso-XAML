using Sesion3.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            this.Players = new ObservableCollection<PlayerViewModel>();
            this.Players.Add(new PlayerViewModel() 
                { 
                    Name = "Falcao",
                    Photo = "/SampleData/MainDataSource/MainDataSource_Files/image01.png",
                    Answer = string.Empty,
                    Clues = new ObservableCollection<ClueViewModel>(),
                    WasDiscovered = false
                });

            this.Players.Add(new PlayerViewModel()
            {
                Name = "David Ospina",
                Photo = "/SampleData/MainDataSource/MainDataSource_Files/image02.png",
                Answer = "David Ospina",
                Clues = new ObservableCollection<ClueViewModel>(),
                WasDiscovered = true
            });

        }

        public PlayerViewModel SelectedPlayer { get; set; }
        public ObservableCollection<PlayerViewModel> Players  { get; set; }
    }
}
