using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Logic.Models
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
