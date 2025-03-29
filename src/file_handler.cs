using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace clashProgress.src {
    public class FileHandler {
        public static T LoadJson<T>(string path) {
            if(!File.Exists(path)) {
                throw new FileNotFoundException($"File not found: {path}");
            }

            try {
                string jsonString = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<T>(jsonString);
            } catch (Exception e) {
                throw new Exception($"Error loading JSON file: {e.Message}");
            }
        }

    public static void SaveJson<T>(string path, T data) {
        try {
            string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, jsonString);
            } catch (Exception e) {
                throw new Exception($"Error saving JSON file: {e.Message}");
            }
        }
    }
}

