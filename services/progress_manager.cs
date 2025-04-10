using clashProgress.models.upgrades;
using clashProgress.utils;
using clashProgress.models.progress;
using clashProgress.models.maxTH;

namespace clashProgress.services {
    public class ProgressManager {
        private static int GetCurrentTHLevel(Dictionary<string, Dictionary<string, List<LevelCount>>> buildings) {
            if (buildings.TryGetValue("Defense", out var defenseBuildings) && defenseBuildings.TryGetValue("Town Hall", out var townHallList)) {
                return townHallList.Max(th => th.Level ?? 0);
            }
            throw new Exception("Town Hall not found in buildings data.");
        }

        public static timeToMax(Dictionary<string, Dictionary<string, List<LevelCount>>> buildings) {
            var currentTHLevel = GetCurrentTHLevel(buildings);
            var maxTHLevel = THData.MaxTHLevels.Keys.Max();
            var levelsToMax = maxTHLevel - currentTHLevel;
            var timeToMax = TimeSpan.FromDays(levelsToMax * 3);
            return timeToMax;
        }
    }
}
