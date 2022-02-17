using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

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
                SkewAngle = 0.2F,
                Language = Language.Eng,//none, eng, deu, por, spa, fra, ita, cze, dan, dum, est, fin, lav, lit, nor, pol, rum, srp_hrv, slk, slv, swe, chi
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
