using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    public class APITCGCard
    {
        public string? id { get; set; }
        public string? code { get; set; }
        public string? rarity { get; set; }
        public string? type { get; set; }
        public string? name { get; set; }
        public List<string>? images { get; set; }
        public string? cost { get; set; }
        public List<string>? attribute { get; set; }
        public string? power { get; set; }
        public string? counter { get; set; }
        public string? color { get; set; }
        public string? family { get; set; }
        public string? ability { get; set; }
        public string? trigger { get; set; }
        public List<string>? set { get; set; }
        public string? notes { get; set; }
    }
}
