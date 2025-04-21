namespace clashProgress.models.entities {
    public class Buildings {
        public string? Name { get; set; }
        public int? Level { get; set; }
        public int? Count { get; set; }
    }
    public class Heroes {
        public string? Name { get; set; }
        public int? Level { get; set; }
        public int? Count { get; set; }
    }
    public class Troops {  
        public string? Name { get; set; }
        public int? Level { get; set; }
        public bool? Unlocked { get; set; }
    }
    public class HeroEquipment {
        public string? Name { get; set; }
        public int? Level { get; set; }
        public bool? Owned { get; set; }
    }
}
