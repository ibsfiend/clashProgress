using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class FileHandler {
    public static T LoadJson<T>(string path) {
        if(!File.Exists(path)) {
            throw new FileNotFoundException($"File not found: {path}");
        }
        string jsonString = File.ReadAllText(path);
        return JsonSerializer.Deserialize<T>(jsonString);
    }

    public static void SaveJson<T>(string path, T data) {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(path, jsonString);
    }
}

