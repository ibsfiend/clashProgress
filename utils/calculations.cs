using System;

namespace clashProgress.utils
{
    public class Calculations
    {
        // Converts time from format "1d 2h 3m 4s" to seconds
        public static double convertToSeconds(string time)
        {
            // Split the time string into parts
            string[] parts = time.Split(' ');

            // Initialize seconds to 0
            double seconds = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                // Split the part into a number and a unit
                string[] part = parts[i].Split(new char[] { 'd', 'h', 'm', 's' }, StringSplitOptions.RemoveEmptyEntries);
                // Get the number from the part
                double number = double.Parse(part[0]);

                // Convert to seconds based on unit
                if (parts[i].EndsWith("d"))
                    seconds += number * 86400; // days to seconds
                else if (parts[i].EndsWith("h"))
                    seconds += number * 3600;  // hours to seconds
                else if (parts[i].EndsWith("m"))
                    seconds += number * 60;    // minutes to seconds
                else if (parts[i].EndsWith("s"))
                    seconds += number;         // already in seconds
                
            }
            return seconds;
        }

        // Converts seconds to time in format "1d 2h 3m 4s"
        public static string convertToTime(double seconds)
        {
            // Calculate the number of days, hours, minutes, and seconds
            int days = (int)(seconds / 86400);
            int hours = (int)((seconds % 86400) / 3600);
            int minutes = (int)((seconds % 3600) / 60);
            int secs = (int)(seconds % 60);

            // Build the time string
            string time = "";
            if (days > 0) time += days + "d ";
            if (hours > 0) time += hours + "h ";
            if (minutes > 0) time += minutes + "m ";
            if (secs > 0) time += secs + "s";

            return time;
        }
        
    }
}