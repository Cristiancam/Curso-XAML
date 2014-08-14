using Events.Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.ViewModels
{
    public class SponsorsViewModel : ISponsorsViewModel
    {
        public SponsorsViewModel(ISponsorsView view)
        {
            this.View = view;
            this.View.ViewModel = this;

            this.Sample = "Este es un ejemplo de sponsors";
        }

        public Views.ISponsorsView View { get; set; }

        public string Sample { get; set; }
    }
}
