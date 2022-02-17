using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class CalculateSkewAngle
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Calculate Angle
            float angle = api.CalculateSkew(dataDir + "skew_image.png");

            // Display the result
            Console.WriteLine(angle);
            // ExEnd:1

            Console.WriteLine("CalculateSkewAngle executed successfully");
        }
    }
}
