namespace MaitlandCodes.OSRS.GEItemAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public partial class ItemResult
    {
        [JsonPropertyName("total")]
        public long Total { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonPropertyName("icon")]
        public Uri Icon { get; set; }

        [JsonPropertyName("icon_large")]
        public Uri IconLarge { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("typeIcon")]
        public Uri TypeIcon { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("current")]
        public PriceTrend Current { get; set; }

        [JsonPropertyName("today")]
        public PriceTrend Today { get; set; }

        [JsonPropertyName("members")]
        public string Members { get; set; }
    }

    public partial class PriceTrend
    {
        [JsonPropertyName("trend")]
        public string Trend { get; set; }

        [JsonPropertyName("price")]
        public JsonElement Price { get; set; }
    }
}