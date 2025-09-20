using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest.RMHAPI
{
    public class RMHAPIData
    {
        [JsonProperty("data")]
        public required List<RMHAPICard> Data { get; set; }

        [JsonProperty("total")]
        public required string Total { get; set; }

        [JsonProperty("current_page")]
        public required string CurrentPage { get; set; }

        [JsonProperty("per_page")]
        public required string PerPage { get; set; }

        [JsonProperty("total_pages")]
        public required string TotalPages { get; set; }
    }
}
