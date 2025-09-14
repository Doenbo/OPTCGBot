using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OPTCGBot.Model.Enums;
using Attribute = OPTCGBot.Model.Enums.Attribute;
using Type = OPTCGBot.Model.Enums.Type;

namespace OPTCGBot.Model.Cards
{
    public class Card
    {
        public Card(int cost, int power, Attribute attribute, int counter, List<string> effects, string trigger, List<Color> color, Category category, string name, int life, List<Type> type, string iD, Rarity rarity, BlockSymbol blockSymbol, int version)
        {
            Cost = cost;
            Power = power;
            Attribute = attribute;
            Counter = counter;
            Effects = effects;
            Trigger = trigger;
            Color = color;
            Category = category;
            Name = name;
            Life = life;
            Type = type;
            ID = iD;
            Rarity = rarity;
            BlockSymbol = blockSymbol;
            Version = version;
        }

        public int Cost { get; set; }
        public int Power { get; set; }
        public Attribute Attribute { get; set; }
        public int Counter { get; set; }
        public List<string> Effects { get; set; }
        public string Trigger { get; set; }
        public List<Color> Color { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Life { get; set; }
        public List<Type> Type { get; set; }
        public string ID { get; set; }
        public Rarity Rarity { get; set; }
        public BlockSymbol BlockSymbol { get; set; }
        public int Version { get; set; }
    }
}
