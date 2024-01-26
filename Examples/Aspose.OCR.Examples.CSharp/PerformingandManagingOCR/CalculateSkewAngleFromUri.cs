using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;
using Aspose.OCR.Models.PreprocessingFilters;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class CalculateSkewAngleFromUri
    {
        public static void Run()
        {
            // ExStart:1   

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object and add URL
            OcrInput input = new OcrInput(InputType.URL);
            input.Add("https://i.stack.imgur.com/0A4M9.png");

            // Calculate Angle
            List<SkewOutput> angle = api.CalculateSkew(input);

            // Display the result
            Console.WriteLine(angle[0].Angle);
          
            // ExEnd:1

            Console.WriteLine("CalculateSkewAngleFromUri executed successfully");
        }
    }
}
