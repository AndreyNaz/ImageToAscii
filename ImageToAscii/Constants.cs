using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAscii
{
    public static class Constants
    {
        // Contains the thresholds for each brightness level, from white (1.0) to black (0.0)
        public static readonly double[] constBrightnessLevels = 
            { 1.0, 0.9, 0.8, 0.7, 0.6, 0.5, 0.3, 0.2 };

        // Contains the char representation for each of the above.
        // Both arrays are ordered accordingly from brightest to darkest.
        public static readonly string[] constBrightnessSymbols = 
            { "  ", "..", ",,", ";;", "cc", "EE", "BB", "@@" };

        // Contains keyValuePairs of the corresponding elements from the above arrays; not used atm
        public static List<KeyValuePair<double, string>> brightnessKvpList = 
            new List<KeyValuePair<double, string>>()
            {
                new KeyValuePair<double, string>(constBrightnessLevels[0], constBrightnessSymbols[0]),
                new KeyValuePair<double, string>(constBrightnessLevels[1], constBrightnessSymbols[1]),
                new KeyValuePair<double, string>(constBrightnessLevels[2], constBrightnessSymbols[2]),
                new KeyValuePair<double, string>(constBrightnessLevels[3], constBrightnessSymbols[3]),
                new KeyValuePair<double, string>(constBrightnessLevels[4], constBrightnessSymbols[4]),
                new KeyValuePair<double, string>(constBrightnessLevels[5], constBrightnessSymbols[5]),
                new KeyValuePair<double, string>(constBrightnessLevels[6], constBrightnessSymbols[6]),
                new KeyValuePair<double, string>(constBrightnessLevels[7], constBrightnessSymbols[7])
            };

        // for utility
        public static int largestIndex = brightnessKvpList.Count - 1;
    }
}
