using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class RecognizeTextFromSpecificRectangle
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

            string result = api.RecognizeImage(dataDir + "sample.png", rects[0]);

            // Display the recognized text
            Console.WriteLine(result);
            // ExEnd:1

            Console.WriteLine("RecognizeTextFromSpecificRectangle executed successfully");
        }
    }
}
