using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class PerformOCROnImageFromUrl
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Get image for recognize
            string uri = "https://qph.fs.quoracdn.net/main-qimg-0ff82d0dc3543dcd3b06028f5476c2e4";

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image           
            RecognitionResult result = api.RecognizeImageFromUri(uri, new RecognitionSettings
            {
                DetectAreas = true,
                RecognizeSingleLine = false,
                AutoSkew = true,
                RecognitionAreas = new List<Rectangle>()
                {
                    new Rectangle(1,3,400,70),
                    new Rectangle(1,72,400,70)
                }
            });

            // Print result
            Console.WriteLine($"Text:\n {result.RecognitionText}");
            Console.WriteLine("Areas:");
            result.RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));
            Console.WriteLine("Warnings:");
            result.Warnings.ForEach(w => Console.WriteLine($"{w}"));
            Console.WriteLine($"JSON: {result.GetJson()}");
            // ExEnd:1

            Console.WriteLine("PerformOCROnImageFromUrl executed successfully");
        }
    }
}
