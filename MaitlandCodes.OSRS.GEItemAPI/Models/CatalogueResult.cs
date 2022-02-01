namespace MaitlandCodes.OSRS.GEItemAPI.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Nodes;
    using System.Text.Json.Serialization;

    public partial class CatalogueResult
    {
        [JsonPropertyName("types")]
        public JsonArray Types { get; set; }

        [JsonPropertyName("alpha")]
        public List<Alpha> Alpha { get; set; }
    }

    public partial class Alpha
    {
        [JsonPropertyName("letter")]
        public string Letter { get; set; }

        [JsonPropertyName("items")]
        public long Items { get; set; }
    }
}
