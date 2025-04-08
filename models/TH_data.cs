using System.Collections.Generic;

namespace clashProgress.Models.Meta
{
    public class TownHallData
    {
        public Dictionary<string, TownHallDefinition> THLevels { get; set; } = new();
    }

    public class TownHallDefinition
    {
        public Dictionary<string, BuildingInfo>? Buildings { get; set; }
        public Dictionary<string, int>? Heroes { get; set; }
        public Dictionary<string, int>? Troops { get; set; }
        public Dictionary<string, int>? Pets { get; set; }
        public Dictionary<string, HeroEquipmentItem>? HeroEquipment { get; set; }
    }

    public class BuildingInfo
    {
        public int MaxLevel { get; set; }
        public int MaxCount { get; set; }
    }

    public class HeroEquipmentItem
    {
        public string Hero { get; set; } = "";
        public int MaxLevel { get; set; }
        public bool Unlocked { get; set; }
    }
}
