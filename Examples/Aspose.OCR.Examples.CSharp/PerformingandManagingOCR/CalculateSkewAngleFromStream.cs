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
            List<SkewOutput> angle = null;

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Calculate Angle
            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(dataDir + "skew_image.png", FileMode.Open, FileAccess.Read))
            {
                file.CopyTo(ms);

                // Create OcrInput object and add stream
                OcrInput input = new OcrInput(InputType.SingleImage);
                input.Add(ms);
                angle = api.CalculateSkew(input);
            }

            // Display the result
            Console.WriteLine(angle[0].Angle);
            // ExEnd:1

            Console.WriteLine("CalculateSkewAngleFromStream executed successfully");
        }
    }
}
