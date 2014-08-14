using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Logic.Models
{
    public class Event : ModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("organizer")]
        public string Organizer { get; set; }
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("copyRight")]
        public string CopyRight { get; set; }

        public string Sponsors { get; set; }
    }
}
