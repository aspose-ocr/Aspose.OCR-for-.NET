using System;
using System.Collections.Generic;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class SpecifyIgnoredCharacters
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
            input.Add(dataDir + "SpanishOCR.bmp");

            // Recognize image
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                IgnoredSymbols = "ab1"
            });

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("SpecifyIgnoredCharacters executed successfully");
        }
    }
}