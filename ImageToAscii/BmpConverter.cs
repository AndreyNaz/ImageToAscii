using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAscii
{
    public static class BmpConverter
    {
        public static string[] ConvertBmp(Bitmap bmp)
        {
            int[,] converted = new int[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var color = bmp.GetPixel(j, i);

                    if (color.GetBrightness() < 0.20)
                    {
                        converted[i, j] = 7;
                    }
                    else if (color.GetBrightness() < 0.30)
                    {
                        converted[i, j] = 6;
                    }
                    else if (color.GetBrightness() < 0.48)
                    {
                        converted[i, j] = 5;
                    }
                    else if (color.GetBrightness() < 0.6)
                    {
                        converted[i, j] = 4;
                    }
                    else if (color.GetBrightness() < 0.7)
                    {
                        converted[i, j] = 3;
                    }
                    else if (color.GetBrightness() < 0.8)
                    {
                        converted[i, j] = 2;
                    }
                    else if (color.GetBrightness() < 0.9)
                    {
                        converted[i, j] = 1;
                    }
                    else
                    {
                        converted[i, j] = 0;
                    }
                }
            }

            return ConvertArray(converted);
        }

        public static string[] ConvertBmpInversed(Bitmap bmp)
        {
            int[,] converted = new int[bmp.Height, bmp.Width];

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var color = bmp.GetPixel(j, i);

                    if (color.GetBrightness() < 0.20)
                    {
                        converted[i, j] = 0;
                    }
                    else if (color.GetBrightness() < 0.30)
                    {
                        converted[i, j] = 1;
                    }
                    else if (color.GetBrightness() < 0.48)
                    {
                        converted[i, j] = 2;
                    }
                    else if (color.GetBrightness() < 0.6)
                    {
                        converted[i, j] = 3;
                    }
                    else if (color.GetBrightness() < 0.7)
                    {
                        converted[i, j] = 4;
                    }
                    else if (color.GetBrightness() < 0.8)
                    {
                        converted[i, j] = 5;
                    }
                    else if (color.GetBrightness() < 0.9)
                    {
                        converted[i, j] = 6;
                    }
                    else
                    {
                        converted[i, j] = 7;
                    }
                }
            }

            return ConvertArray(converted);
        }

        private static string[] ConvertArray(int[,] converted)
        {
            string[] lines = new string[converted.GetLength(0)];

            for (int i = 0; i < lines.Length; i++)
            {
                int[] row = new int[converted.GetLength(1)];

                for (int j = 0; j < converted.GetLength(1); j++)
                {
                    row[j] = converted[i, j];
                }

                string line = String.Join("", row.Select(p => p.ToString()).ToArray());

                lines[i] = line;
            }

            return lines;
        }
    }
}
