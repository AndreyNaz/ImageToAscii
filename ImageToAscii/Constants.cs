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
            //{ 1.0, 0.9, 0.8, 0.7, 0.6, 0.5, 0.4, 0.3, 0.2, 0.1 };
            { 1.00, 0.92, 0.84, 0.76, 0.68, 0.60, 0.52, 0.44, 0.36, 0.26, 0.16, 0.08 };

        // Contains the char representation for each of the above.
        // Both arrays are ordered accordingly from brightest to darkest.
        public static readonly string[] constBrightnessSymbols = 
            { "  ", "..", "..", ",,", ";;", "cc", "cy", "YY","EE", "BB","B@", "@@" };

        // for utility
        public static int largestIndex = constBrightnessLevels.Length - 1;
    }
}
