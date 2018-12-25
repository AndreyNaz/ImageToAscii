using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAscii
{
    public class ASCIIGenerator
    {
        //TODO: refactor further
        public ASCIIGenerator(double[] levels)
        {
            BrightnessLevels = new double[Constants.constBrightnessLevels.Length];
            Array.Copy(levels, BrightnessLevels, Constants.constBrightnessLevels.Length);
            //Deep copies the const to avoid referencing it
        }

        public double[] BrightnessLevels
        {
            get;
            set;
        }


        public StringBuilder ConvertImage(Bitmap bitmap, bool isDark)
        {
            StringBuilder sb = new StringBuilder();

            string[] convertedBitmap = ConvertBitmap(bitmap, isDark);

            for (int i = 0; i < convertedBitmap.Length; i++)
            {
                string currentLine = convertedBitmap[i];
                DrawLine(currentLine, sb);
            }

            return sb;
        }

        private void DrawLine(string lineCode, StringBuilder sb)
        {
            string currentLine = string.Empty;

            int[] charCodes = lineCode.Split(' ').Select(int.Parse).ToArray();

            foreach (int i in charCodes)
            {
                currentLine += Constants.constBrightnessSymbols[i];
            }

            sb.AppendLine(currentLine);
        }

        private string[] ConvertBitmap(Bitmap bitmap, bool isDark)
        {
            int[,] converted = new int[bitmap.Height, bitmap.Width];

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    var color = bitmap.GetPixel(j, i);
                    double brightness = color.GetBrightness();

                    if (isDark)
                    {
                        for (int k = 0; k <= Constants.largestIndex; k++)
                        {
                            if (brightness >= BrightnessLevels[k])
                            {
                                converted[i, j] = Constants.largestIndex - k;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int k = Constants.largestIndex; k >= 0; k--)
                        {
                            if (brightness <= BrightnessLevels[k])
                            {
                                converted[i, j] = k;
                                break;
                            }
                        }
                    }
                }
            }
            return MatrixToStringArray(converted);
        }

        private string[] MatrixToStringArray(int[,] converted)
        {
            string[] lines = new string[converted.GetLength(0)];

            for (int i = 0; i < lines.Length; i++)
            {
                int[] row = new int[converted.GetLength(1)];

                for (int j = 0; j < converted.GetLength(1); j++)
                {
                    row[j] = converted[i, j];
                }

                string line = String.Join(" ", row.Select(p => p.ToString()).ToArray());

                lines[i] = line;
            }

            return lines;
        }
    }
}
