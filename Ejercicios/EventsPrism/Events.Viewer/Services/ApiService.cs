using Events.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.Services
{
    public class ApiService : IApiService
    {
        public Event GetEventInfo(string eventId)
        {
            return new Event() 
            { 
                Name = "Feria del libro",
                Description = "Fiesta del libro y la cultura en Medellin",
                Sponsors = "Alcaldia de Medellin y EPM"
            };
        }
    }
}
