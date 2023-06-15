using Aspose.OCR;
using System;
using System.Collections.Generic;

namespace RecognizePNG
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStart();

            // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object to containerize images
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add("test1.jpg");

            // You can put in parameters MemoryStream with image
            // The result is the degree of skew
            List<SkewOutput> result = api.CalculateSkew(input);
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE 1:");
            Console.WriteLine(result[0].Angle);

            input.Clear();
            input.Add("test2.png");
            result = api.CalculateSkew(input);
            Console.WriteLine("\nSKEW IMAGE 2:");
            Console.WriteLine(result[0].Angle);

            input.Clear();
            input.Add("test3.png");
            result = api.CalculateSkew(input);
            Console.WriteLine("\nSKEW IMAGE 3:");
            Console.WriteLine(result[0].Angle);

            PrintEnd();
        }

        static void PrintStart()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This example will work without a license. The result will be reduced.\n");
            Console.WriteLine("Recognition has begun. Please, wait...\n\n");
        }

        static void PrintEnd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

