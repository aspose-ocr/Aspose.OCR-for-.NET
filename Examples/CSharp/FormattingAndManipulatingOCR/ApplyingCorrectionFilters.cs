using System.IO;
using Aspose.OCR;
using Aspose.OCR.Filters;
using System;

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class ApplyingCorrectionFilters
    {
        public static void Run()
        {
            // ExStart:ApplyingCorrectionFilters
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();
            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            // Create CorrectionFilters collection
            CorrectionFilters filters = new CorrectionFilters();
            Filter filter = null;

            // Initialize Median filter
            filter = new MedianFilter(5);
            filters.Add(filter);

            // Create Gaussian Blur filter
            filter = new GaussBlurFilter();
            filters.Add(filter);

            // Assign collection to OcrEngine
            ocrEngine.Config.CorrectionFilters = filters;

            // Run recognition process
            if (ocrEngine.Process())
            {
                // Display results
                Console.WriteLine(ocrEngine.Text);
            }
            // ExEnd:ApplyingCorrectionFilters
        }
    }
}