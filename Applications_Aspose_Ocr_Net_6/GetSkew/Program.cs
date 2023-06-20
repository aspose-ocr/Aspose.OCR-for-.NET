using Aspose.OCR;
using System;
using System.Collections.Generic;

namespace RecognizePNG
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args.Length > 0 ? args[0] : "images/test1.jpg";
            PrintStart(fileName);

            // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object to containerize images
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(fileName);

            // You can put in parameters MemoryStream with image
            // The result is the degree of skew
            List<SkewOutput> result = api.CalculateSkew(input);
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE:");
            Console.WriteLine(result[0].Angle);

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
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(1000);
        }
    }
}

