using Newtonsoft.Json;
using Sesion3.Common;
using Sesion3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;

namespace Sesion3.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public Sesion3.Services.NavigationService NavigationService { get; set; }

        public MainViewModel()
        {
            NavigationService = new Services.NavigationService();

            List<Player> players = LoadPlayers();

            this.Players = new ObservableCollection<PlayerViewModel>();
            foreach (var item in players)
            {
                ObservableCollection<ClueViewModel> clues = new ObservableCollection<ClueViewModel>();
                foreach (var clue in item.Clues)
                {
                    clues.Add(new ClueViewModel() 
                    {
                        Name = clue.Split(':')[0],
                        Value = clue.Split(':')[1],
                    });
                }

                this.Players.Add(new PlayerViewModel()
                {
                    Name = item.Name,
                    Photo = item.Photo,
                    Answer = string.Empty,
                    Clues = clues,
                    WasDiscovered = false,
                    Parent = this,
                });
            }
        }

        public List<Player> LoadPlayers()
        {
            string json = string.Empty;

            using (StreamReader sr = new StreamReader("Data/Players.json"))
            {
                json += sr.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Player>>(json);
        }

        private async Task<string> ReadTextAsync(string fileName)
        {
            StreamResourceInfo stream = Application.GetResourceStream(new Uri(fileName, UriKind.Relative));
            using (StreamReader reader = new StreamReader(stream.Stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public PlayerViewModel SelectedPlayer { get; set; }
        public ObservableCollection<PlayerViewModel> Players  { get; set; }
    }
}
