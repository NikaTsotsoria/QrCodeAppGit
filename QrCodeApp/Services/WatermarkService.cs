using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using QrCodeApp.Interfaces;

namespace QrCodeApp.Services
{
    public class WatermarkService : IWatermarkService
    {
        public Bitmap AddTextWatermark(Bitmap image, string text)
        {
            Bitmap bmp = new Bitmap(image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Font font = new Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Pixel);
                SizeF textSize = g.MeasureString(text, font);
                float x = bmp.Width - textSize.Width - 10;
                float y = bmp.Height - textSize.Height - 10;
                SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 0));
                SolidBrush brush = new SolidBrush(Color.FromArgb(128, 255, 255, 255));
                g.DrawString(text, font, shadowBrush, x + 2, y + 2);
                g.DrawString(text, font, brush, x, y);
            }
            return bmp;
        }
    }
}
