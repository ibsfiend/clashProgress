using clashProgress.models.entities;
using clashProgress.models.progress;

namespace clashProgress.services.processes {
    public static class Processor {

        public static List<Building> ProcessBuildings(Dictionary<string, Dictionary<string, List<LevelCount>>>? rawBuildings) {
            var buildings = new List<Building>();

            if (rawBuildings == null) return buildings;

            foreach (var category in rawBuildings) {
                string categoryName = category.Key;
                foreach (var nameGroup in category.Value) {
                    string buildingName = nameGroup.Key;
                    foreach (var levelData in nameGroup.Value) {
                        buildings.Add(new Building {
                            Name = buildingName,
                            Level = levelData.Level ?? 0,
                            Count = levelData.Count ?? 0,
                            Category = categoryName
                        });
                    }
                }
            }

            return buildings;
        }

        public static List<Hero> ProcessHeroes(Dictionary<string, int>? rawHeroes) {
            if (rawHeroes == null) return new List<Hero>();

            return rawHeroes.Select(h => new Hero {
                Name = h.Key,
                Level = h.Value
            }).ToList();
        }

        public static List<Troop> ProcessTroops(Dictionary<string, Dictionary<string, int>>? rawTroops) {
            var troops = new List<Troop>();
            if (rawTroops == null) return troops;

            foreach (var group in rawTroops) {
                string troopType = group.Key;
                string resource = troopType.Contains("Dark") ? "Dark Elixir" : "Elixir";

                foreach (var troop in group.Value) {
                    troops.Add(new Troop {
                        Name = troop.Key,
                        Level = troop.Value,
                        Type = troopType,
                        ResourceType = resource
                    });
                }
            }

            return troops;
        }
    }
}
