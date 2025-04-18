using clashProgress.models.upgrades;
using clashProgress.utils;
using clashProgress.models.progress;
using clashProgress.models.maxTH;

namespace clashProgress.services {
    public class ProgressManager {
        /// <summary>
        /// Gets the current Town Hall level from the buildings data.
        /// </summary>
        /// <param name="buildings">Dictionary containing building data including Town Hall levels</param>
        /// <returns>An integer representing the current Town Hall level</returns>
        /// <remarks>
        /// This method:
        /// 1. Tries to get the Defense category from the buildings data
        /// 2. Tries to get the Town Hall building from the Defense category
        /// 3. Returns the maximum level of the Town Hall building
        /// </remarks>
        /// <exception cref="Exception">Thrown when Town Hall not found in buildings data</exception>
        private static int GetCurrentTHLevel(Dictionary<string, Dictionary<string, List<LevelCount>>> buildings) {
            if (buildings.TryGetValue("Defense", out var defenseBuildings) && defenseBuildings.TryGetValue("Town Hall", out var townHallList)) {
                return townHallList.Max(th => th.Level ?? 0);
            }
            throw new Exception("Town Hall not found in buildings data.");
        }

        public static double timeToMax(double buidingTime, double heroTime, double troopTime) {
            var timeToMax =

            return timeToMax;
        }

        /// <summary>
        /// Calculates the total level progress of the player's progress.
        /// </summary>
        /// <param name="buildings">Dictionary containing building data including Town Hall levels</param>
        /// <returns>A double representing the total level progress</returns>
        /// <remarks>
        /// This method:
        /// 1. Gets the building progress
        /// 2. Gets the hero progress
        /// 3. Gets the troop progress
        /// 4. Adds the progress values together
        /// 5. Returns the total progress
        /// </remarks>
        public static double getTotalLevelProgress(Dictionary<string, Dictionary<string, List<LevelCount>>> buildings) {
            var buildingProgress = getBuildingProgress();
            var heroProgress = getHeroProgress();
            var troopProgress = getTroopProgress();
            var totalProgress = (buildingProgress + heroProgress + troopProgress);
            return (double)totalProgress;
        }

        public static double getBuildingProgress(string building, int level, Dictionary<string, Dictionary<string, List<LevelCount>>> buildings) {
            var buildingList = buildings["Defense"][building];
                
        }

        public static double getHeroProgress(string hero, Dictionary<string, int> heroes) {
            var heroLevel = heroes[hero];
            var maxHeroLevel = THData.MaxTHLevels[hero];
            return (double)heroLevel / maxHeroLevel;
        }

        public static double getTroopProgress(string troop, int level, Dictionary<string, Dictionary<string, int>> troops) {
            var troopList = troops["Troops"][troop];
        }
    }
}
