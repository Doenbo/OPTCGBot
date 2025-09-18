using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest.RMHAPI
{
    public class RMHAPIData
    {
        public List<RMHAPICard>? data { get; set; }
        public string? total { get; set; }
        public string? current_page { get; set; }
        public string? per_page { get; set; }
        public string? total_pages { get; set; }
    }
}
