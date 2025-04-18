using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using clashProgress.models.progress;
using clashProgress.services;

public class FileHandlerProgressLoadTest {
    
    /// <summary>
    /// Main method to test the FileHandler class to load the progress.json file.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    /// <remarks>
    /// This method:
    /// 1. Loads the progress.json file
    /// 2. Prints the Archer Queen level
    /// 3. Prints the number of Archer Towers at level 6
    /// 4. Prints the progress for each category of buildings
    /// </remarks>
    public static void Main(string[] args) {
        string path = "data/progress.json";
        Root progress = FileHandler.LoadJson<Root>(path);
        var aqLevel = progress.Heroes["Archer Queen"];
        Console.WriteLine("Archer Queen Level: " + aqLevel);
        var atList = progress.Buildings["Defense"]["Archer Towers"]; 
        var level6at = atList.FirstOrDefault(at => at.Level == 6);
        Console.WriteLine("Number of Archer Towers at level 6: " + level6at.Count);
        foreach (var category in progress.Buildings) // "Defense", "Support", etc.
        {
            Console.WriteLine($"Category: {category.Key}");

            foreach (var building in category.Value) // "Archer Towers", "Walls", etc.
            {
                Console.WriteLine($"  Building: {building.Key}");

                foreach (var levelEntry in building.Value) // list of LevelCount
                {
                    Console.WriteLine($"    Level {levelEntry.Level}: Count = {levelEntry.Count}");
                }
            }
        }

    }
    
}

