using Aspose.OCR;
using System;

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

            // You can put in parameters MemoryStream with image
            // The result is the degree of skew
            float result = api.CalculateSkew("test1.jpg");
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE 1:");
            Console.WriteLine(result);

            result = api.CalculateSkew("test2.png");
            Console.WriteLine("\nSKEW IMAGE 2:");
            Console.WriteLine(result);

            result = api.CalculateSkew("test3.png");
            Console.WriteLine("\nSKEW IMAGE 3:");
            Console.WriteLine(result);

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

