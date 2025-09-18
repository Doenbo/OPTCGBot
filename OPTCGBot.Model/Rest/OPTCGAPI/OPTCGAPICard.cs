using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTCGBot.Model.Rest
{
    [JsonObject]
    public  class OPTCGAPICard : IAPICard
    {
        [JsonProperty("inventory_price")]
        public required string InventoryPrice { get; set; }

        [JsonProperty("market_price")]
        public required string MarketPrice { get; set; }

        [JsonProperty("card_name")]
        public required string CardName { get; set; }

        [JsonProperty("set_name")]
        public required string SetName { get; set; }

        [JsonProperty("card_text")]
        public required string CardText { get; set; }

        [JsonProperty("set_id")]
        public required string SetId { get; set; }

        [JsonProperty("rarity")]
        public required string Rarity { get; set; }

        [JsonProperty("card_set_id")]
        public required string CardSetId { get; set; }

        [JsonProperty("card_color")]
        public required string CardColor { get; set; }

        [JsonProperty("card_type")]
        public required string CardType { get; set; }

        [JsonProperty("life")]
        public required string Life { get; set; }

        [JsonProperty("card_cost")]
        public required string CardCost { get; set; }

        [JsonProperty("card_power")]
        public required string CardPower { get; set; }

        [JsonProperty("sub_types")]
        public required string SubTypes { get; set; }

        [JsonProperty("counter_amount")]
        public required string CounterAmount { get; set; }

        [JsonProperty("attribute")]
        public required string Attribute { get; set; }

        [JsonProperty("date_scraped")]
        public required string DateScraped { get; set; }

        [JsonProperty("card_image_id")]
        public required string CardImageId { get; set; }

        [JsonProperty("card_image")]
        public required string CardImage { get; set; }
    }
}
