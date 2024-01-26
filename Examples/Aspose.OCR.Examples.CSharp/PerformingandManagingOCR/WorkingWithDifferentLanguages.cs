using System.IO;

using Aspose.OCR;
using System;
using System.Collections.Generic;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class WorkingWithDifferentLanguages
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(dataDir + "SpanishOCR.bmp");

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                Language = Language.Spa
            });

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("WorkingWithDifferentLanguages executed successfully");
        }
    }
}