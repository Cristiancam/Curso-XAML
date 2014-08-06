using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Logic.ViewModels
{
    public class DayViewModel
    {

        public DateTime Date { get; set; }
        public ObservableCollection<ActivityViewModel> MyProperty { get; set; }
    }
}
