using OPTCGBot.Model.Enums;
using OPTCGBot.Model.Rest;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Attribute = OPTCGBot.Model.Enums.Attribute;
using Color = OPTCGBot.Model.Enums.Color;

namespace OPTCGBot.Model.Cards
{
    public class Card
    {
        public Card(int cost, int power, Attribute attribute, int counter, List<string> effects, string trigger, List<Color> colors, Category category, string name, int life, List<string> types, string iD, Rarity rarity, BlockSymbol blockSymbol, int version, string image)
        {
            Cost = cost;
            Power = power;
            Attribute = attribute;
            Counter = counter;
            Effects = effects;
            Trigger = trigger;
            Colors = colors;
            Category = category;
            Name = name;
            Life = life;
            Types = types;
            ID = iD;
            Rarity = rarity;
            BlockSymbol = blockSymbol;
            Version = version;
            Image = image;
        }

        public int Cost { get; set; }
        public int Power { get; set; }
        public Attribute Attribute { get; set; }
        public int Counter { get; set; }
        public List<string> Effects { get; set; }
        public string Trigger { get; set; }
        public List<Color> Colors { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Life { get; set; }
        public List<string> Types { get; set; }
        public string ID { get; set; }
        public Rarity Rarity { get; set; }
        public BlockSymbol BlockSymbol { get; set; }
        public int Version { get; set; }
        public string Image { get; set; }
    }
}
