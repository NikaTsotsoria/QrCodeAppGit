using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QrCodeApp.Interfaces
{
    public interface IWatermarkService
    {
        Bitmap AddTextWatermark(Bitmap image, string text);
    }
}
