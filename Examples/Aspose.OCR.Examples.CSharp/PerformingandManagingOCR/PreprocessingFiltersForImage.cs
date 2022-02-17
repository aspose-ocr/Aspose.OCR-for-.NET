using System;
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

            // Preprocess and save image
            MemoryStream img = api.PreprocessImage(fullPath, filters);
            using (FileStream fs = new FileStream(dataDir + "preprocessed.png", FileMode.OpenOrCreate))
            {
                img.WriteTo(fs);
            }
            img.Dispose();

            // Recognize image with custom preprocessing          
            RecognitionResult result = api.RecognizeImage(fullPath, new RecognitionSettings
            {
                PreprocessingFilters = filters
            });
           
            // Print result
            Console.WriteLine($"Text:\n {result.RecognitionText}");
            // ExEnd:1

            Console.WriteLine("PreprocessingFiltersForImage executed successfully");
        }
    }
}
