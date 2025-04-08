//Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace clashProgress.models.progress
{
    public class LevelCount {
        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("owned")]
        public int? Owned { get; set; }

}


public class Root
{
    public Dictionary<string, Dictionary<string, List<LevelCount>>>? Buildings { get; set; }
    public Dictionary<string, int>? Heroes { get; set; }
    public Dictionary<string, Dictionary<string, List<EquipmentItem>>>? HeroEquipment { get; set; }
    public Dictionary<string, Dictionary<string, int>>? Troops { get; set; }
    public Dictionary<string, Dictionary<string, int>>? Spells { get; set; }
    public Dictionary<string, int>? SiegeMachines { get; set; }
}

public class EquipmentItem
{
    public string? Rarity { get; set; }
    public int? Level { get; set; }
}

}
