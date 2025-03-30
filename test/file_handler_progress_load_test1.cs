using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using clashProgress.progress_data;
using clashProgress.src;

public class FileHandlerProgressLoadTest {
    
    /// <summary>
    /// Main method to test the FileHandler class to load the progress.json file.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    public static void Main(string[] args) {
        string path = "data/progress.json";
        Root progress = FileHandler.LoadJson<Root>(path);
        Console.WriteLine("Archer Queen Level: " + (progress.Heroes.TryGetValue("Archer Queen", out int level) ? level : 0));
        Console.WriteLine("Number of Archer Towers at level " + progress.Buildings["Defense"]["Archer Towers"][0].Level + ": " + (progress.Buildings.TryGetValue("Defense", out var defense) && defense.TryGetValue("Archer Towers", out var archerTowers) ? archerTowers[0].Count : 0));
    }
}

