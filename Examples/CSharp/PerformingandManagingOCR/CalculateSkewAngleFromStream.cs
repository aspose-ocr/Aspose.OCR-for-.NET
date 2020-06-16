using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class CalculateSkewAngleFromStream
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();
            float angle = 0;

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Calculate Angle
            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(dataDir + "skew_image.png", FileMode.Open, FileAccess.Read))
            {
                file.CopyTo(ms);
                angle = api.CalculateSkew(ms);
            }

            // Display the result
            Console.WriteLine(angle);
            // ExEnd:1

            Console.WriteLine("CalculateSkewAngleFromStream executed successfully");
        }
    }
}
