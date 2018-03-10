using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class PerformOCROnImage
    {
        public static void Run()
        {
            // ExStart:PerformOCROnImage   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir + "Sampleocr.bmp");

            // Process the image
            if (ocrEngine.Process())
            {
                // Display the recognized text
                Console.WriteLine(ocrEngine.Text);
            }
            // ExEnd:PerformOCROnImage   
        }
    }
}
