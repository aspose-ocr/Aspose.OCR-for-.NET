using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class OCROperationWithList
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object and add images
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(dataDir + "0001460985.Jpeg");
            input.Add(dataDir + "sample.png");

            // Recognize image           
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
               //default or custom
            });

            // Print result
            for (int i = 0; i < result.Count; i++)
            {
                 Console.WriteLine($"Image: {i}\n Result:\n {result[i].RecognitionText}");
            }
           
            // ExEnd:1
            Console.WriteLine("OCROperationWithList executed successfully");
        }
    }
}
