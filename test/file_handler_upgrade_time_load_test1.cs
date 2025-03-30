using clashProgress.upgrade_times_data;
using clashProgress.src;
using System;

public class FileHandlerUpgradeTimesLoadTest {
    public static void Main(string[] args) {
        string path = "data/upgrade_times.json";
        Root upgradeTimes = FileHandler.LoadJson<Root>(path);
        Console.WriteLine("The time for a level 1 cannon is " + upgradeTimes.Buildings.Cannons._1);
    }
}
