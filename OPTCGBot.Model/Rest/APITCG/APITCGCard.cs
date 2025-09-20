using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public class APITCGCard
    {
        public required string id { get; set; }
        public required string code { get; set; }
        public required string rarity { get; set; }
        public required string type { get; set; }
        public required string name { get; set; }
        public required List<string> images { get; set; }
        public required string cost { get; set; }
        public required List<string> attribute { get; set; }
        public required string power { get; set; }
        public required string counter { get; set; }
        public required string color { get; set; }
        public required string family { get; set; }
        public required string ability { get; set; }
        public required string trigger { get; set; }
        public required List<string> set { get; set; }
        public required string notes { get; set; }
    }
}
