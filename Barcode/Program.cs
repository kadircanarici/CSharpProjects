using System;
using System.IO;
using ZXing;

namespace BarcodeGeneratorReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate barcode and save to file
            string barcodeText = "Hello, world!";
            string barcodeFilePath = @"C:\temp\barcode.png";
            GenerateBarcode(barcodeText, barcodeFilePath);

            // Read barcode from file and display text in console
            string readBarcodeText = ReadBarcode(barcodeFilePath);
            Console.WriteLine(readBarcodeText);

            Console.ReadKey();
        }

        static void GenerateBarcode(string text, string filePath)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128 // Change barcode format as needed
            };
            var barcodeBitmap = barcodeWriter.Write(text);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                barcodeBitmap.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        static string ReadBarcode(string filePath)
        {
            var barcodeBitmap = (System.Drawing.Bitmap)System.Drawing.Image.FromFile(filePath);
            var barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(barcodeBitmap);

            return result.Text;
        }
    }
}
