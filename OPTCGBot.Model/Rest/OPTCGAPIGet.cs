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
using Type = OPTCGBot.Model.Enums.Type;

namespace OPTCGBot.Model.Rest
{
    public class OPTCGAPIGet : ICardGet
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

        private List<Card> Convert(List<OPTCGAPICard> jards)
        {
            var cards = new List<Card>();

            foreach (var jard in jards)
            {
                _ = int.TryParse(jard.card_cost, out int cost);
                _ = int.TryParse(jard.card_power, out int power);
                _ = Enum.TryParse(jard.attribute, out Attribute attribute);
                _ = int.TryParse(jard.counter_amount, out int counter);

                var effects = new List<string>() { jard.card_text }; //TODO
                var trigger = jard.card_text; //TODO

                var jolors = jard.card_color.Split(' ');
                var colors = new List<Color>();
                foreach (var jolor in jolors)
                {
                    _ = Enum.TryParse(jolor, out Color color);
                    colors.Add(color);
                }

                _ = Enum.TryParse(jard.card_type, out Category category);
                var name = jard.card_name;
                _ = int.TryParse(jard.life, out int life);



                var jypes = jard.sub_types.Split(' ');
                var types = new List<Type>();
                foreach (var jype in jypes)
                {
                    _ = Enum.TryParse(jype, out Type type);
                    types.Add(type);
                }


                var id = jard.card_image_id;
                _ = Enum.TryParse(jard.rarity, out Rarity rarity);
                //TODO blocksymbol
                //TODO version

                var image = jard.card_image;

                cards.Add(new Card(cost, power, attribute, counter, effects, trigger, colors, category, name, life, types, id, rarity, BlockSymbol.One, 1, image));
            }
            return cards;
        }
    }
}
