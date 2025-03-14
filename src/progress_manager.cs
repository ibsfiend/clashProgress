#include "progress_manager.h"   
#include "file_handler.h"
#include "calculations.h"
#include <string>
#include <iostream>

class ProgressManager {
private:
    json progressData;  
    json upgradeData;

public:
    ProgressManager() {
        progressData = FileHandler::loadJsonFile("data/progress.json");
        upgradeData = FileHandler::loadJsonFile("data/upgrade_times.json");
    }

    int getUpgradeTime(const std::string& category, const std::string& name, int level) {
        if (upgradeData.contains(category) && upgradeData[category].contains(name)) {
            if (upgradeData[category][name].contains(std::to_string(level))) {
                std::string timeStr = upgradeData[category][name][std::to_string(level)];
                return Calculations::parseTimeString(timeStr);
            }   
        }
        return -1;  // Level not found
    }

    void printUpgradeTime(const std::string& category, const std::string& name, int level) {
        int timeInSeconds = getUpgradeTime(category, name, level);
        if (timeInSeconds == -1) {
            std::cout << "Upgrade time not found for " << name << " at level " << level << "\n";
        } else {
            std::cout << "Upgrade time for " << name << " at level " << level << ": " 
                      << timeInSeconds << " seconds.\n";
        }
    }
};
