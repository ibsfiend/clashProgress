using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using clashProgress.src;
using clashProgress.data;

public class FileHandlerTest {
    public static void Main(string[] args) {
        string path = "data/progress.json";
        Progress progress = FileHandler.LoadJson<Progress>(path);
        Console.WriteLine(progress);
    }
}

