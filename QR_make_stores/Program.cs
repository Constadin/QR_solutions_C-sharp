using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;


namespace QR_make_stores
{
    public class Program
    {
        static void Main(string[] args)
        {
            QRCodeGenerator  generator = new QRCodeGenerator();
            string NAME = "First Name";
            string LASTNAME = "Last Name\n";
            string idiotita = "Developer, Application Technician ( Web Developer & Video Games) & Electronic Technician\n";
            string viografiko = "https://www.facebook.com";
            string vgithub = "https://www.instagram.com/";

            Bitmap qrCodeBitmap = generator.GenerateQRCode(NAME, LASTNAME, idiotita, viografiko, vgithub);
            // Save the QR code as an image file
            string outputPath = "../../Person.png"; // Output file path
            qrCodeBitmap.Save(outputPath);

            Console.WriteLine("QR code generated and saved as qrcode.png.");
            Console.ReadLine();
        }
    }
}
