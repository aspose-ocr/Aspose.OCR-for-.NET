using System.IO;

using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class WorkingWithDifferentLanguages
    {
        public static void Run()
        {
            // ExStart:WorkingWithDifferentLanguages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set the Image property by loading the image from file path location or an instance of Stream
            ocrEngine.Image = ImageStream.FromFile(dataDir + "SpanishOCR.bmp");

            // Clear the default language (English)
            ocrEngine.LanguageContainer.Clear();

            // Load the resources of the language from file path location or an instance of Stream
            ocrEngine.LanguageContainer.AddLanguage(LanguageFactory.Load(dataDir + "Aspose.OCR.Spanish.Resources.zip"));

            // Process the image
            if (ocrEngine.Process())
            {
                // Display the recognized text
                Console.WriteLine(ocrEngine.Text);
            }
            // ExEnd:WorkingWithDifferentLanguages
        }
    }
}