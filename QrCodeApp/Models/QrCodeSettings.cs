using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QrCodeApp.Models
{
    public class QrCodeSettings
    {
        public int PixelSize { get; set; } = 10;
        public Color ForegroundColor { get; set; } = Color.Black;
        public Color BackgroundColor { get; set; } = Color.White;
    }
}