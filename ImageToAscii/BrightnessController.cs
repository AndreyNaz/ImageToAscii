using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAscii
{
    public static class BrightnessController
    {

        public static double[] ChangeBrightness(double[] levels, double brigtnessCounter)
        {
            //Referencing constants.constBrightnessLevels above causes the code below
            //to change the elements in consts. Using a deep copy in the converter constructor 
            //fixes the issue.
            for (int i = 0; i < Constants.constBrightnessLevels.Length; i++)
            {
                double level = Constants.constBrightnessLevels[i];
                double newLevel = level - level * brigtnessCounter;
                //newLevel = level - level * brigtnessCounter adjusts gamma and looks better
                //newLevel = level - brigtnessCounter adjusts brightness

                if (newLevel > 0 && newLevel < 1)
                {
                    levels[i] = newLevel;
                }
                else
                {
                    if (newLevel < 0)
                    {
                        levels[i] = 0;
                    }
                    else if (newLevel > 1)
                    {
                        levels[i] = 1;
                    }
                }
            }

            return levels;
        }
    }
}
