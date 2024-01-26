using System;
using System.IO;
using Aspose.OCR;
using Aspose.OCR.Models.PreprocessingFilters;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class RecognizeImageWithTextAreaDetectionAndWithSkewCorrection
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Set preprocessing filters
            PreprocessingFilter filters = new PreprocessingFilter
            {
                PreprocessingFilter.AutoSkew()
            };

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage, filters);
            input.Add(dataDir + "sample.png");

            // Recognize image
            System.Collections.Generic.List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                DetectAreasMode = DetectAreasMode.COMBINE
            });

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("RecognizeImageWithTextAreaDetectionAndWithSkewCorrection executed successfully");
        }
    }
}
