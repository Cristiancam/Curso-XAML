using Events.Viewer.Services;
using Events.Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.ViewModels
{
    public class EventViewModel : IEventViewModel
    {
        IApiService apiService;
        public EventViewModel(IEventView view, IApiService apiService)
        {
            this.View = view;
            this.View.ViewModel = this;
            this.apiService = apiService;

            LoadEventInfo();
        }

        private void LoadEventInfo()
        {
            var eventInfo = apiService.GetEventInfo("Fake");
            
            this.Sponsors = eventInfo.Sponsors;
            this.Slogan = eventInfo.Description;
        }

        public Views.IEventView View { get; set; }

        public string Sponsors { get; set; }

        public string Slogan { get; set; }
    }
}
