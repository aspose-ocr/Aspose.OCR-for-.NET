using Aspose.Drawing;
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
            input.Add("test.png");

            // set
            // 1) the full path to the image
            // 2) type of areas to search
            // 3) set this to true for AreasType.LINES if you want to split lines after defining paragraphs     
            List<RectangleOutput> result = api.DetectRectangles(input, AreasType.PARAGRAPHS, detectAreas: true);

            Console.WriteLine("AREAS RECTANGLES COORDINATES:");
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            // Print the result
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].Source);
                foreach(Rectangle rect in result[i].Rectangles)
                Console.WriteLine($"X: {rect.X} Y: {rect.Y} Width: {rect.Width} Height: {rect.Height}");    
            }

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

