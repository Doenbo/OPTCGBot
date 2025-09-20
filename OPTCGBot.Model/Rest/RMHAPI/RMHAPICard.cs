using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public class RMHAPICard
    {
        [JsonProperty("id")]
        public required string Id { get; set; }
        [JsonProperty("code")]
        public required string Code { get; set; }
        [JsonProperty("rarity")]
        public required string Rarity { get; set; }
        [JsonProperty("type")]
        public required string Type { get; set; }
        [JsonProperty("name")]
        public required string Name { get; set; }
        [JsonProperty("cost")]
        public required string Cost { get; set; }
        [JsonProperty("attribute")]
        public required string Attribute { get; set; }
        [JsonProperty("power")]
        public required string Power { get; set; }
        [JsonProperty("counter")]
        public required string Counter { get; set; }
        [JsonProperty("color")]
        public required string Color { get; set; }
        [JsonProperty("Class")]
        public required string Class { get; set; }
        [JsonProperty("effect")]
        public required string Effect { get; set; }
        [JsonProperty("set")]
        public required string Set { get; set; }
        [JsonProperty("image")]
        public required string Image { get; set; }
    }
}
