using System;
using System.Collections.Generic;
using Aspose.OCR.Models.PreprocessingFilters;

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

            // Set preprocessing filters
            PreprocessingFilter filters = new PreprocessingFilter
            {
                PreprocessingFilter.AutoSkew(),
              //  PreprocessingFilter.Rotate(0.2f)
            };

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage, filters);
            input.Add(fullPath);

            // Recognize image           
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                RecognizeSingleLine = false,
                Language = Language.Eng,//none, eng, deu, por, spa, fra, ita, cze, dan, dum, est, fin, lav, lit, nor, pol, rum, srp_hrv, slk, slv, swe, chi
            });

            // Print result
            Console.WriteLine($"Text:\n {result[0].RecognitionText}");
            Console.WriteLine("Areas:");
            result[0].RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));
            Console.WriteLine("Warnings:");
            result[0].Warnings.ForEach(w => Console.WriteLine($"{w}"));
            Console.WriteLine($"JSON: {result[0].GetJson()}");
            // ExEnd:1

            Console.WriteLine("OCROperationWithLanguageSelection executed successfully");
        }
    }
}
