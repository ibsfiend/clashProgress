
using Newtonsoft.Json;

namespace clashProgress.models.progress
{
    public class LevelCount {
        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("owned")]
        public int? Owned { get; set; }

    }

    public class PlayerProgressContainer
    {
        [JsonProperty("PlayerProgress")]
        public PlayerProgress Progress { get; set; }
    }
    public class PlayerProgress
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
