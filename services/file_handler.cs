using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace clashProgress.services {
    /// <summary>
    /// Handles loading and saving JSON files.
    /// </summary>
    public class FileHandler {
        /// <summary>
        /// Loads a JSON file and deserializes it into an object of type T.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize.</typeparam>
        /// <param name="path">The path to the file to load the object from.</param>
        /// <returns>The deserialized object.</returns>
        public static T LoadFromFileJson<T>(string path) {
            if(!File.Exists(path)) {
                throw new FileNotFoundException($"File not found: {path}");
            }

            try {
                string jsonString = File.ReadAllText(path);
                var result = JsonConvert.DeserializeObject<T>(jsonString);
                if (result == null) {
                    throw new Exception("Deserialized object is null");
                }
                return result;
            } catch (Exception e) {
                throw new Exception($"Error loading JSON file: {e.Message}");
            }
        }

        /// <summary>
        /// Saves an object of type T to a JSON file.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="path">The path to the file to save the object to.</param>
        /// <param name="data">The object to save to the file.</param>
        public static void SaveToFileJson<T>(string path, T data) {
            try {
                string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(path, jsonString);
            } catch (Exception e) {
                throw new Exception($"Error saving JSON file: {e.Message}");
            }
        }
    }
}

