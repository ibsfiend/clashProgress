using System.Collections.Generic;

namespace clashProgress
{
    public class UpgradeTimesData
    {
        public Dictionary<string, Dictionary<string, Dictionary<string, string>>> Buildings { get; set; }
        public Dictionary<string, Dictionary<string, string>> Heroes { get; set; }
        public Dictionary<string, object> Troops { get; set; }
    }
}
