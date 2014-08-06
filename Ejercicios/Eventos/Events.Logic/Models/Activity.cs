using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Logic.Models
{
    public class Activity : ModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("responsible")]
        public string Responsible { get; set; }
        [JsonProperty("category")]
        public Category Category { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("internalId")]
        public string InternalId { get; set; }
        [JsonProperty("keywords")]
        public string Keywords { get; set; }
        [JsonProperty("calendarVersionId")]
        public string CalendarVersionId { get; set; }
    }
}
