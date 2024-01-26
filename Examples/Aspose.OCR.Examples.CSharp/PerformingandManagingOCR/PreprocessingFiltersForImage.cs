using System;
using System.Collections.Generic;
using System.IO;
using Aspose.OCR.Models.PreprocessingFilters;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class PreprocessingFiltersForImage
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Image Path
            string fullPath = dataDir + "black.png";

            // Initialize filters
            PreprocessingFilter filters = new PreprocessingFilter
            {
                //PreprocessingFilter.Binarize(),
                //PreprocessingFilter.ContrastCorrectionFilter(),
                //PreprocessingFilter.Median(),
                //PreprocessingFilter.Resize(500,100),
                //PreprocessingFilter.Rotate(10),
                //PreprocessingFilter.Scale(0.3f),
                //PreprocessingFilter.Threshold(200),
                //PreprocessingFilter.ToGrayscale(),
                PreprocessingFilter.Invert(),
                PreprocessingFilter.Dilate()
            };

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage, filters);
            input.Add(fullPath);

          

            // Preprocess and save image
            OcrInput output = ImageProcessing.Render(input);
            using (FileStream fs = new FileStream(dataDir + "preprocessed.png", FileMode.OpenOrCreate))
            {
                output[0].Stream.WriteTo(fs);
            }

            // Recognize image after preprocessing          
            List<RecognitionResult> resultAfterPreprocessing = api.Recognize(output, new RecognitionSettings
            {
            });

            // Print result
            Console.WriteLine($"After preprocessing Text:\n {resultAfterPreprocessing[0].RecognitionText}");

            output.Dispose();

            // Recognize image with custom preprocessing          
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
            });
           
            // Print result
            Console.WriteLine($"Result with preprocessing Text:\n {result[0].RecognitionText}");
            // ExEnd:1

            Console.WriteLine("PreprocessingFiltersForImage executed successfully");
        }
    }
}
