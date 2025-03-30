using Newtonsoft.Json;
using System.Collections.Generic;
namespace clashProgress.upgrade_costs_data
{
    public class UpgradeCostData {
        [JsonProperty("Buildings")]
        public Dictionary<string, Dictionary<int, UpgradeInfo>>? Buildings { get; set; } = new();

        [JsonProperty("Heroes")]
        public Dictionary<string, Dictionary<int, UpgradeInfo>>? Heroes { get; set; } = new();
    }

    public class UpgradeInfo {
        [JsonProperty("time")]
        public string? Time { get; set; }

        [JsonProperty("resources")]
        public Dictionary<string, int>? Resource { get; set; } = new();
    }
}