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
        var aqLevel = progress.Heroes["Archer Queen"];
        Console.WriteLine("Archer Queen Level: " + aqLevel);
        var atList = progress.Buildings["Defense"]["Archer Towers"]; 
        var level6at = atList.FirstOrDefault(at => at.Level == 6);
        Console.WriteLine("Number of Archer Towers at level 6: " + level6at.Count);
    }
}

