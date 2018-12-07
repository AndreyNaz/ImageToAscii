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
        //TODO: refactor further, implement into app

        public static StringBuilder ConvertImage(string inputFilePath, bool isDark)
        {
            StringBuilder sb = new StringBuilder();

            //StreamWriter sw = new StreamWriter(outputFile);

            int n = 1;

            Bitmap bmp = (Bitmap)Image.FromFile(inputFilePath);
            string[] convertedBmp = BmpConverter.ConvertBmp(bmp);

            if (isDark)
            {
                convertedBmp = BmpConverter.ConvertBmpInversed(bmp);
            }
            
            for (int i = 0; i < convertedBmp.Length; i++)
            {
                string currentLine = convertedBmp[i];
                DrawLine(n, currentLine, sb);
            }

            return sb;
        }

        public static void DrawLine(int n, string lineCode, StringBuilder sb)
        {
            var square = 2 * n;

            string black = new string('@', square);
            string veryDark = new string('B', square);
            string dark = new string('E', square);
            string neutralDark = new string('c', square);
            string neutralLight = new string(';', square);
            string light = new string('"', square);
            string veryLight = new string('.', square);
            string white = new string(' ', square);

            string lineFormat = string.Empty;

            foreach (char c in lineCode)
            {
                lineFormat += ("{" + c.ToString() + "}");
            }

            for (int i = 0; i < n; i++)
            {
                sb.AppendFormat(lineFormat, white, veryLight, light, neutralLight, neutralDark, dark, veryDark, black);
                sb.AppendLine();
                //sw.WriteLine(lineFormat, white, veryLight, light, neutralLight, neutralDark, dark, veryDark, black);
            }
        }
    }
}
