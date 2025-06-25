using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using ZXing;
using System.Drawing;
using QrCodeApp.Models;
using QrCodeApp.Interfaces;

namespace QrCodeApp.Services
{
    public class QrCodeService : IQrCodeService
    {
        public Bitmap GenerateQrCode(string data, QrCodeSettings settings)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                return qrCode.GetGraphic(settings.PixelSize, settings.ForegroundColor, settings.BackgroundColor, true);
            }
        }

        public string DecodeQrCode(Bitmap bitmap)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            return result?.Text;
        }
    }
}
