using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Logic.Models
{
    public class ModelBase
    {
        [JsonProperty("__createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("__updatedAt")]
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonProperty("version")]
        public byte[] Version { get; set; }
    }
}
