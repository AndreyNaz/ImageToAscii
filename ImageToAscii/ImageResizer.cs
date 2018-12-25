using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAscii
{
    public static class ImageResizer
    {
        //public Bitmap Image { get; private set; }
        //public double ScalingFactor { get; private set; }
        //
        //public ImageResizer(Bitmap image, double scalingFactor)
        //{
        //    Image = image;
        //    ScalingFactor = scalingFactor;
        //}

        public static Bitmap ResizeImage(Bitmap Image, int scalingFactor)
        {
            int newWidth = Image.Width - (Image.Width / 12 * Math.Abs(scalingFactor));
            int newHeight = Image.Height - (Image.Height / 12 * Math.Abs(scalingFactor));

            var destRect = new Rectangle(0, 0, newWidth, newHeight);
            var destImage = new Bitmap(newWidth, newHeight);

            destImage.SetResolution(Image.HorizontalResolution, Image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(Image, destRect, 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
