using clashProgress.models.upgrades;
using clashProgress.services;
using System;

public class FileHandlerUpgradeCostsLoadTest {
    //Test helper method that lists all the upgradeables in the data file loaded from json
    public static void ListAllUpgradeables(UpgradeCostData data)
    {
        Console.WriteLine("Buildings:");
        foreach (var category in data.Buildings)
        {
            Console.WriteLine($"- {category.Key}");
            foreach (var levelPair in category.Value)
            {
                Console.WriteLine($"  Level {levelPair.Key}:");
                Console.WriteLine($"    Time: {levelPair.Value.Time}");
                foreach (var resource in levelPair.Value.Resource)
                {
                    Console.WriteLine($"    Resource: {resource.Key}, Amount: {resource.Value}");
                }
            }
        }

        Console.WriteLine("\nHeroes:");
        foreach (var hero in data.Heroes)
        {
            Console.WriteLine($"- {hero.Key}");
            foreach (var levelPair in hero.Value)
            {
                Console.WriteLine($"  Level {levelPair.Key}:");
                Console.WriteLine($"    Time: {levelPair.Value.Time}");
                foreach (var resource in levelPair.Value.Resource)
                {
                    Console.WriteLine($"    Resource: {resource.Key}, Amount: {resource.Value}");
                }
            }
        }
    }

    /*public static void Main(string[] args) {
        string path = "data/upgrade_costs.json";
        var upgradeCosts = FileHandler.LoadJson<UpgradeCostData>(path);
        ListAllUpgradeables(upgradeCosts);
    }*/
}
