using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Viewer.Views;

namespace Events.Viewer.ViewModels
{
    public interface ISloganViewModel
    {
        ISloganView View { get; set; }
    }
}
