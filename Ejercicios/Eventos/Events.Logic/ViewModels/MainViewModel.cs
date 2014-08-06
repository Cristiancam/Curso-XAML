using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Logic.ViewModels
{
    public class MainViewModel
    {
        public ActivityViewModel Activity { get; set; }
        public EventViewModel EventInfo { get; set; }
        public ObservableCollection<DayViewModel> Days { get; set; }
    }
}
