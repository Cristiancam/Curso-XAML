using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Logic.ViewModels;
using Text.Logic.Models;

namespace Text.Logic.Helpers
{
    class ViewModelHelper
    {
        internal static ObservableCollection<EventViewModel> GetEvents(IEnumerable<Item> items)
        {
            ObservableCollection<EventViewModel> result = new ObservableCollection<EventViewModel>();
            foreach (var item in items)
            {
                result.Add(new EventViewModel() 
                {
                    Description = item.Name,
                    Points = item.Points,
                    IsSelected = false
                });
            }

            return result;
        }
    }
}
