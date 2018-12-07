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
        public static double[] brightnessLevels = 
            { 1.0, 0.9, 0.8, 0.7, 0.6, 0.5, 0.3, 0.2 };

        // Contains the char representation for each of the above.
        // Both arrays are ordered accordingly from brightest to darkest.
        public static string[] brightnessSymbols = 
            { "  ", "..", ",,", ";;", "cc", "EE", "BB", "@@" };

        // Contains keyValuePairs of the corresponding elements from the above arrays
        public static List<KeyValuePair<double, string>> brightnessKvpList = 
            new List<KeyValuePair<double, string>>()
            {
                new KeyValuePair<double, string>(brightnessLevels[0], brightnessSymbols[0]),
                new KeyValuePair<double, string>(brightnessLevels[1], brightnessSymbols[1]),
                new KeyValuePair<double, string>(brightnessLevels[2], brightnessSymbols[2]),
                new KeyValuePair<double, string>(brightnessLevels[3], brightnessSymbols[3]),
                new KeyValuePair<double, string>(brightnessLevels[4], brightnessSymbols[4]),
                new KeyValuePair<double, string>(brightnessLevels[5], brightnessSymbols[5]),
                new KeyValuePair<double, string>(brightnessLevels[6], brightnessSymbols[6]),
                new KeyValuePair<double, string>(brightnessLevels[7], brightnessSymbols[7])
            };

        // for utility
        public static int largestIndex = brightnessKvpList.Count - 1;
    }
}
