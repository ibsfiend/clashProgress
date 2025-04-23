using clashProgress.models.entities;
using clashProgress.models.progress;

namespace clashProgress.services.processes {
    public static class Processor {
        /// <summary>
        /// Processes raw building data from the progress file into a list of Building objects.
        /// </summary>
        /// <param name="rawBuildings">Dictionary containing building categories and their levels. The outer dictionary maps building types (e.g. "Town Hall") to an inner dictionary of building names and levels. Can be null.</param>
        /// <returns>A list of Building objects containing the processed building data. Returns empty list if input is null.</returns>
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

        /// <summary>
        /// Processes raw hero data from the progress file into a list of Hero objects.
        /// </summary>
        /// <param name="rawHeroes">Dictionary containing hero names and their levels. Can be null.</param>
        /// <returns>A list of Hero objects containing the processed hero data. Returns empty list if input is null.</returns>
        public static List<Hero> ProcessHeroes(Dictionary<string, int>? rawHeroes) {
            if (rawHeroes == null) return new List<Hero>();

            return rawHeroes.Select(h => new Hero {
                Name = h.Key,
                Level = h.Value
            }).ToList();
        }
        
        /// <summary>
        /// Processes raw troop data from the progress file into a list of Troop objects.
        /// </summary>
        /// <param name="rawTroops">Dictionary containing troop categories and their levels. The outer dictionary maps troop types (e.g. "Dark Troops") to an inner dictionary of troop names and levels. Can be null.</param>
        /// <returns>A list of Troop objects containing the processed troop data. Returns empty list if input is null.</returns>
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
