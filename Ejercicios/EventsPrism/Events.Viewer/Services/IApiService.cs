using Events.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Viewer.Services
{
    public interface IApiService
    {
        Event GetEventInfo(string eventId);
    }
}
