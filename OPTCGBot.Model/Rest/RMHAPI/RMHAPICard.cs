using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public class RMHAPICard
    {
        public string? id { get; set; }
        public string? code { get; set; }
        public string? rarity { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public string? cost { get; set; }
        public string? attribute { get; set; }
        public string? power { get; set; }
        public string? counter { get; set; }
        public string? color { get; set; }
        public string? Class { get; set; }
        public string? effect { get; set; }
        public string? set { get; set; }
        public string? image { get; set; }
    }
}
