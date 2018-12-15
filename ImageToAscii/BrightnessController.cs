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
            double[] consts = { 1.0, 0.9, 0.8, 0.7, 0.6, 0.5, 0.3, 0.1 };
            //WHY THE FUCK WONT THIS WORK BY REFERENCING THE CONSTANTS CLASS
            //INSTEAD OF ME HAVING TO HARDCODE THE ABOVE LINE LIKE A FUCKING PAJEET??????
            //Referencing constants.constBrightnessLevels above causes the code below
            //to change the elements in consts for some strange unknown reason
            for (int i = 0; i < Constants.constBrightnessLevels.Length; i++)
            {
                double level = consts[i];
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
