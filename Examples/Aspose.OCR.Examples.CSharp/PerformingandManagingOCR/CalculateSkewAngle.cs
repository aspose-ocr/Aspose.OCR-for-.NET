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

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(dataDir + "skew_image.png");

            // Calculate Angle
            List<SkewOutput> angle = api.CalculateSkew(input);

            // Display the result
            Console.WriteLine(angle[0].Angle);
            // ExEnd:1

            Console.WriteLine("CalculateSkewAngle executed successfully");
        }
    }
}
