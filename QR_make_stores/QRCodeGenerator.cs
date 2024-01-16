using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using System.Drawing;
using ZXing.QrCode;


namespace QR_make_stores
{
    public class QRCodeGenerator
    {
        public Bitmap GenerateQRCode (string NAME ,string LASTNAME, string idiotita, string viografiko, string vgithub)
        {
            string content =($"{NAME}\n{LASTNAME}\n{idiotita}\nlinkedin: {viografiko}\n\ngithub: {vgithub}");

            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 600, Height = 600, Margin = 0 ,
                    CharacterSet = "UTF-8"
                }

            };

            return writer.Write(content);
        }
    }
}
