using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using clashProgress.src;
using clashProgress;

public class FileHandlerTest {
    public static void Main(string[] args) {
        string path = "data/progress.json";
        Root progress = FileHandler.LoadJson<Root>(path);
        Console.WriteLine(progress);
        Console.WriteLine("Archer Queen Level: " + (progress?.Heroes?.ArcherQueen ?? 0));
        Console.WriteLine("Number of Archer Towers: " + (progress?.Buildings?.Defense?.ArcherTowers?.Count ?? 0));
    }
}

