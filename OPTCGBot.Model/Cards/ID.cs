using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPTCGBot.Model.Enums;

namespace OPTCGBot.Model.Cards
{
    public class ID(string set, int number)
    {

        //TODO Use Enum -> TryParse?
        public string Set { get; set; } = set;
        public string Number { get; set; } = number.ToString("D3");

        public override string ToString() => Set.ToString() + "-" + Number;
        
    }
}
