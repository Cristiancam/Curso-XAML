using Events.Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.ViewModels
{
    public interface IEventViewModel
    {
        IEventView View { get; set; }
    }
}
