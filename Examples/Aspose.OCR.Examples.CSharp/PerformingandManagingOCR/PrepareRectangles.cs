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

            // Recognize image
            List<Rectangle> rects = new List<Rectangle>()
            {
                new Rectangle(138, 352, 2033, 537),
                new Rectangle(147, 890, 2033, 1157),
                new Rectangle(923, 2045, 465, 102),
                new Rectangle(104, 2147, 2076, 819)
            };

            // first case
            List<string> listResult = api.RecognizeImage(dataDir + "sample.png", rects);

            // Display the recognized text
            foreach (string s in listResult)
            {
                Console.WriteLine(s);
            }
           

            // second case
            RecognitionResult result = api.RecognizeImage(dataDir + "sample.png", new RecognitionSettings
            {
                RecognitionAreas = rects
            });

            // Display the recognized text
            foreach (string s in result.RecognitionAreasText)
            {
                Console.WriteLine(s);
            }

            // ExEnd:1
            Console.WriteLine("PrepareRectangles executed successfully");
        }
    }
}
