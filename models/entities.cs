namespace clashProgress.models.entities {

    public class Building {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Count { get; set; }
        public string Category { get; set; } = ""; // e.g., "Defense", "Army", etc.
    }

    public class Hero {
        public string Name { get; set; } = "";
        public int Level { get; set; }
    }

    public class Troop {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public bool Unlocked { get; set; } = true;
        public string Type { get; set; } = "";         // "Elixir Troops" or "Dark Elixir Troops"
        public string ResourceType { get; set; } = ""; // "Elixir", "Dark Elixir"
    }

    public class HeroEquipment {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public string Rarity { get; set; } = "";
        public string Hero { get; set; } = "";
    }
}
