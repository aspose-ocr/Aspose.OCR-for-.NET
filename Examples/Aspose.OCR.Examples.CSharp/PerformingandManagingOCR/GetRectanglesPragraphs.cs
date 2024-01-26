using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class GetRectanglesParagraphs
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Image Path
            string fullPath = dataDir + "sample.png";

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(fullPath);

            // Recognize image           
            List<RectangleOutput> output = api.DetectRectangles(input, AreasType.PARAGRAPHS, true);// if you want to get a paragraphs  - don't set detect_areas = false

            // return null without license
            //foreach (var rectanglesOut in output)
            //{
            //    // Print result           
            //    Console.WriteLine("Areas coordinates:");
            //    rectanglesOut.Rectangles.ForEach(a => Console.WriteLine($"x:{a.X} y:{a.Y} width:{a.Width} height:{a.Height}"));
            //}
            // ExEnd:1

            Console.WriteLine("GetRectanglesParagraphs executed successfully");
        }
    }
}
