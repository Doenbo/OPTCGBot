using Newtonsoft;
using Newtonsoft.Json;
using OPTCGBot.Model.Cards;
using OPTCGBot.Model.Enums;
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
    public class OPTCGAPIGet : IAPIGet
    {
        private static readonly string apibase = "https://optcgapi.com/api";
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
            string api = $"{apibase}/sets/card/{id}/";
            var result = client.GetStringAsync(api).Result;
            var json = JsonConvert.DeserializeObject<List<OPTCGAPICard>>(result);

            //TODO dynamic?
            //var json2 = JsonConvert.DeserializeObject<dynamic>(result);
            //var name = json2[0].card_name;

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

        public List<Card>? GetAllStCards()
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        public List<Card>? GetAllSetCards()
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------

        private List<Card> Convert(List<OPTCGAPICard> jards)
        {
            var cards = new List<Card>();

            foreach (var jard in jards)
            {
                _ = int.TryParse(jard.CardCost, out int cost);
                _ = int.TryParse(jard.CardPower, out int power);
                _ = Enum.TryParse(jard.Attribute, out Attribute attribute);
                _ = int.TryParse(jard.CounterAmount, out int counter);

                var effects = new List<string>() { jard.CardText }; //TODO
                var trigger = jard.CardText; //TODO

                var jolors = jard.CardColor.Split(' ');
                var colors = new List<Color>();
                foreach (var jolor in jolors)
                {
                    _ = Enum.TryParse(jolor, out Color color);
                    colors.Add(color);
                }

                _ = Enum.TryParse(jard.CardType, out Category category);
                var name = jard.CardName;
                _ = int.TryParse(jard.Life, out int life);
                var types = TypeConverter.Convert(jard.SubTypes);
                var id = jard.CardImageId;
                _ = Enum.TryParse(jard.Rarity, out Rarity rarity);
                //TODO blocksymbol
                //TODO version

                var image = jard.CardImage;

                cards.Add(new Card(cost, power, attribute, counter, effects, trigger, colors, category, name, life, types, id, rarity, BlockSymbol.One, 1, image));
            }
            return cards;
        }

        //----------------------------------------------------------------------
    }
}
