using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QrCodeApp.Interfaces
{
    public interface IQrCodeService
    {
        Bitmap GenerateQrCode(string data, Models.QrCodeSettings settings);
        string DecodeQrCode(Bitmap bitmap);
    }
}
