using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;
using Aspose.OCR.Models;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class OCROperationWithLanguageSelection
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Image Path
            string fullPath = dataDir + "sample.png";

            // Recognize image           
            RecognitionResult result = api.RecognizeImage(fullPath, new RecognitionSettings
            {
                DetectAreas = true,
                RecognizeSingleLine = false,
                AutoSkew = true,
                Skew = 0.2F,
                Language = Language.en,
            });

            // Print result
            Console.WriteLine($"Text:\n {result.RecognitionText}");
            Console.WriteLine("Areas:");
            result.RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));
            Console.WriteLine("Warnings:");
            result.Warnings.ForEach(w => Console.WriteLine($"{w}"));
            Console.WriteLine($"JSON: {result.GetJson()}");
            // ExEnd:1

            Console.WriteLine("OCROperationWithLanguageSelection executed successfully");
        }
    }
}
