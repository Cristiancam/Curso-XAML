using Events.Viewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.Views
{
    public interface ISponsorsView
    {
        ISponsorsViewModel ViewModel { get; set; }
    }
}
