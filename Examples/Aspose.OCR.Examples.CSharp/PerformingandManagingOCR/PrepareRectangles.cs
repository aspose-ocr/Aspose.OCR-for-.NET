using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class PrepareRectangles
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(dataDir + "sample.png");

            // Recognize image
            List<Drawing.Rectangle> rects = new List<Drawing.Rectangle>()
            {
                new Drawing.Rectangle(138, 352, 2033, 537),
                new Drawing.Rectangle(147, 890, 2033, 1157),
                new Drawing.Rectangle(923, 2045, 465, 102),
                new Drawing.Rectangle(104, 2147, 2076, 819)
            };

            // first case
            List<RecognitionResult> listResult = api.Recognize(input, new RecognitionSettings
            {
                RecognitionAreas = rects
            });

            // Display the recognized text
            foreach (RecognitionResult s in listResult)
            {
                Console.WriteLine(s.RecognitionText);
            }

            // ExEnd:1
            Console.WriteLine("PrepareRectangles executed successfully");
        }
    }
}
