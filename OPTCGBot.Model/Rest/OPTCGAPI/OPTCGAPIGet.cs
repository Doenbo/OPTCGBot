using Newtonsoft;
using Newtonsoft.Json;
using OPTCGBot.Model.Cards;
using OPTCGBot.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Card>? GetAllSets() => GetCards($"{apibase}/AllSets/");
        public List<Card>? GetAllDecks() => GetCards($"{apibase}/AllDecks/");
        public List<Card>? GetSetId(string set_id) => GetCards($"{apibase}/sets/{set_id}");
        public List<Card>? GetSetCardId(string card_id) => GetCards($"{apibase}/sets/card/{card_id}/");
        public List<Card>? GetDeckId(string st_id) => GetCards($"{apibase}/decks/{st_id}");
        public List<Card>? GetDeckCardId(string card_id) => GetCards($"{apibase}/decks/card/{card_id}/");
        public List<Card>? GetSetIdColor(string set_id, string card_color) => GetCards($"{apibase}/sets/{set_id}/{card_color}");
        public List<Card>? GetDeckIdColor(string deck_id, string card_color) => GetCards($"{apibase}/decks/{deck_id}/{card_color}");

        private List<Card> GetCards(string api)
        {
            var result = client.GetStringAsync(api).Result;
            var json = JsonConvert.DeserializeObject<List<OPTCGAPICard>>(result);

            if (json == null) throw new NoNullAllowedException();
            return Convert(json);
        }

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
