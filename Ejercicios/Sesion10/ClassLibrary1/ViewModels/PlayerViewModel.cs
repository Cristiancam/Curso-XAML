using System.Windows.Input;
using Sesion3.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary1.Contracts;

namespace Sesion3.ViewModels
{
    public class PlayerViewModel : BindableBase
    {
        IDialogService dialogService;

        public PlayerViewModel()
        {
            dialogService = GetInstance<IDialogService>();
        }

        public string Name { get; set; }
        
        private string answer;

        public string Answer
        {
            get { return answer; }
            set 
            { 
                answer = value;

                if (this.WasDiscovered)
                    RaiseChange("Answer");
            }
        }

        public string Photo { get; set; }

        private bool wasDiscovered;

        public bool WasDiscovered
        {
            get { return wasDiscovered; }
            set 
            { 
                wasDiscovered = value;
                RaiseChange("WasDiscovered");

                if (this.WasDiscovered)
                    RaiseChange("Answer");
            }
        }


        public MainViewModel Parent { get; set; }

        public ObservableCollection<ClueViewModel> Clues { get; set; }

        public ICommand GuessCommand
        {
            get { return new CommandBase(Guess, ValidateUser); }
        }

        private bool ValidateUser()
        {
            return !WasDiscovered;
        }


        private void Guess()
        {
            if (this.Name.ToUpper() == this.Answer.ToUpper())
            {
                dialogService.Show("El jugador fue descubierto");
                this.WasDiscovered = true;
            }
            else
            {
                this.Answer = string.Empty;
                dialogService.Show("Intente otra vez");
            }
        }

        public ICommand ShowCluesCommand 
        {
            get { return new CommandBase(ShowClues, null); }
        }

        private void ShowClues()
        {
            if (this.WasDiscovered)
                dialogService.Show("El jugador ya fue descubierto");
            else
            {
                
                this.Parent.SelectedPlayer = this;
                this.Parent.NavigationService.Navigate("CluesWindow");
            }
        }
    }
}
