using System.IO;

using Aspose.OCR;
using System;

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

            // Recognize image
            RecognitionResult result = api.RecognizeImage(dataDir + "SpanishOCR.bmp", new RecognitionSettings
            {
                IgnoredCharacters = "ab1"
            });

            // Display the recognized text
            Console.WriteLine(result.RecognitionText);
            // ExEnd:1

            Console.WriteLine("WorkingWithDifferentLanguages executed successfully");
        }
    }
}