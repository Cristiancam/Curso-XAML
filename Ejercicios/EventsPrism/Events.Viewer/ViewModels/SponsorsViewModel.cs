﻿using Events.Viewer.Services;
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
        IApiService apiService;
        public SponsorsViewModel(ISponsorsView view, IApiService apiService)
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
        }

        public Views.ISponsorsView View { get; set; }

        public string Sponsors { get; set; }
    }
}
