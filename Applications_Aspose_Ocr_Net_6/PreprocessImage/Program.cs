using Aspose.OCR;
using Aspose.OCR.Models.PreprocessingFilters;
using System;
using System.IO;

namespace RecognizePNG
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args.Length > 0 ? args[0] : "images/test.jpg";
            PrintStart(fileName);
            // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create OcrInput object to containerize images
            // Set:
            // 1) path to the image or MemruStream with the image.
            // 2) set of filters for preprocessing. You can call any number of filters.
            OcrInput input = new OcrInput(InputType.SingleImage, new PreprocessingFilter { PreprocessingFilter.ContrastCorrectionFilter() });
            input.Add(fileName);


            OcrInput result = ImageProcessing.Render(input);
            MemoryStream memoryStream = result[0].Stream;

            // Use Stream for further recognition or simply save it on the disk
            FileStream fs = new FileStream("out/corrected.jpg", FileMode.OpenOrCreate);
            memoryStream.WriteTo(fs);
            fs.Close();
            memoryStream.Close();
            result.Clear();

            PrintEnd();
        }

        static void PrintStart(string fileName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This example will work without a license. The result will be reduced.\n");
            Console.WriteLine($"Recognition [{fileName}] has begun. Please, wait...\n\n");
        }

        static void PrintEnd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The preprocessed image was saved by the name corrected.jpg. Check the folder.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(1000);
        }
    }
}

