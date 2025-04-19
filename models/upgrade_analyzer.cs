namespace clashProgress.models.upgrade_analyzer {
    public static class UpgradeAnalyzer {
        public static List<UpgradeInfoEntry> GetMissingBuildingUpgrades(PlayerProgress progress, TownHallDefinition maxDef, UpgradeCostData costs) { ... }
        public static List<UpgradeInfoEntry> GetMissingHeroUpgrades(PlayerProgress progress, TownHallDefinition maxDef, UpgradeCostData costs) { ... }
        public static List<UpgradeInfoEntry> GetMissingTroopUpgrades(PlayerProgress progress, TownHallDefinition maxDef, UpgradeCostData costs) { ... }
    }
}