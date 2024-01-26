using System;
using System.Collections.Generic;
using System.Drawing;
using Aspose.OCR.Models.PreprocessingFilters;

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

            // Set preprocessing filters
            PreprocessingFilter filters = new PreprocessingFilter
            {
                PreprocessingFilter.AutoSkew()
            };

            // Create OcrInput object and add URL
            OcrInput input = new OcrInput(InputType.URL, filters);
            input.Add(uri);

            // Recognize image           
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                RecognizeSingleLine = false,
                RecognitionAreas = new List<Aspose.Drawing.Rectangle>()
                {
                    new Aspose.Drawing.Rectangle(1,3,390,70),
                    new Aspose.Drawing.Rectangle(1,72,390,70)
                }
            });

            // Print result
            Console.WriteLine($"Text:\n {result[0].RecognitionText}");
            Console.WriteLine("Areas:");
            result[0].RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));
            Console.WriteLine("Warnings:");
            result[0].Warnings.ForEach(w => Console.WriteLine($"{w}"));
            Console.WriteLine($"JSON: {result[0].GetJson()}");
            // ExEnd:1

            Console.WriteLine("PerformOCROnImageFromUrl executed successfully");
        }
    }
}
