using Newtonsoft;
using Newtonsoft.Json;
using OPTCGBot.Model.Cards;
using OPTCGBot.Model.Enums;
using OPTCGBot.Model.Rest.RMHAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using Attribute = OPTCGBot.Model.Enums.Attribute;
using Color = OPTCGBot.Model.Enums.Color;

namespace OPTCGBot.Model.Rest
{
    public class RMHAPIGet// : ICardGet
    {
        private static readonly string apibase = "https://optcg-api.ryanmichaelhirst.us/api/v1";
        private static readonly HttpClient client = new HttpClient();

        public List<Card>? GetAllSets()
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetAllDecks()
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetSetId(string id)
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetSetCardId(string id)
        {
            string api = $"{apibase}/cards?id={id}/";
            var result = client.GetStringAsync(api).Result;
            var json = JsonConvert.DeserializeObject<RMHAPIData>(result);
            if (json == null) return null; //TODO?
            return Convert(json);
        }

        //----------------------------------------------------------------------

        public List<Card>? GetDeckId(string id)
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetDeckCardId(string id)
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetSetIdColor(string id, string color)
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetDeckIdColor(string id, string color)
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        private List<Card> Convert(RMHAPIData jards)
        {
            var cards = new List<Card>();

            foreach (var jard in jards.Data)
            {
                _ = int.TryParse(jard.Cost, out int cost);
                _ = int.TryParse(jard.Power, out int power);
                _ = Enum.TryParse(jard.Attribute, out Attribute attribute);
                _ = int.TryParse(jard.Counter, out int counter);

                var effects = new List<string>() { jard.Effect }; //TODO
                var trigger = jard.Effect; //TODO

                var jolors = jard.Color.Split(' ');
                var colors = new List<Color>();
                foreach (var jolor in jolors)
                {
                    _ = Enum.TryParse(jolor, out Color color);
                    colors.Add(color);
                }

                _ = Enum.TryParse(jard.Type, out Category category);
                var name = jard.Name;
                var life = 0;
                var types = TypeConverter.Convert(jard.Class);
                var id = jard.Id;
                _ = Enum.TryParse(jard.Rarity, out Rarity rarity);
                //TODO blocksymbol
                //TODO version

                var image = jard.Image;

                cards.Add(new Card(cost, power, attribute, counter, effects, trigger, colors, category, name, life, types, id, rarity, BlockSymbol.One, 1, image));
            }
            return cards;
        }
    }
}
