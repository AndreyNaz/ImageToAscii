using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAscii
{
    public static class ASCIIGenerator
    {
        //TODO: refactor further

        public static StringBuilder ConvertImage(string inputFilePath, bool isDark)
        {
            StringBuilder sb = new StringBuilder();

            Bitmap bitmap = (Bitmap)Image.FromFile(inputFilePath);
            string[] convertedBitmap = ConvertBitmap(bitmap, isDark);
            
            for (int i = 0; i < convertedBitmap.Length; i++)
            {
                string currentLine = convertedBitmap[i];
                DrawLine(currentLine, sb);
            }

            return sb;
        }

        private static void DrawLine(string lineCode, StringBuilder sb)
        {
            string currentLine = string.Empty;

            foreach (char c in lineCode)
            {                
                currentLine += Constants.brightnessKvpList[int.Parse(c.ToString())].Value;
            }

            sb.AppendLine(currentLine);
        }

        private static string[] ConvertBitmap(Bitmap bitmap, bool isDark)
        {
            int[,] converted = new int[bitmap.Height, bitmap.Width];

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    var color = bitmap.GetPixel(j, i);
                    var brightness = color.GetBrightness();
                    
                    for (int k = Constants.largestIndex; k >= 0; k--)
                    {
                        if (brightness <= Constants.brightnessKvpList[k].Key)
                        {
                            converted[i, j] = k;

                            if (isDark)
                            {
                                converted[i, j] = Constants.largestIndex - k;
                            }

                            break;
                        }
                    }
                }
            }

            return MatrixToStringArray(converted);
        }

        private static string[] MatrixToStringArray(int[,] converted)
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
