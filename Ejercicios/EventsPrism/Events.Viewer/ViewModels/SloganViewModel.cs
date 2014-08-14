using Events.Viewer.Services;
using Events.Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.ViewModels
{
    public class SloganViewModel : ISloganViewModel
    {
        IApiService apiService;
        public SloganViewModel(ISloganView view, IApiService apiService)
        {
            this.View = view;
            this.View.ViewModel = this;
            this.apiService = apiService;

            LoadEventInfo();
        }

        private void LoadEventInfo()
        {
            var eventInfo = apiService.GetEventInfo("Fake");
            this.Slogan = eventInfo.Description;
        }

        public Views.ISloganView View { get; set; }

        public string Slogan { get; set; }
    }
}
