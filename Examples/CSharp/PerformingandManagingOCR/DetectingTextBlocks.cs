using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class DetectingTextBlocks
    {
        public static void Run()
        {
            // ExStart:DetectingTextBlocks  
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OMR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            // Remove non-textual blocks
            ocrEngine.Config.RemoveNonText = true;

            // Run recognition process
            if (ocrEngine.Process())
            {
                // Display text block locations
                foreach (IRecognizedPartInfo part in ocrEngine.Text.PartsInfo)
                {
                    Console.WriteLine(part.Box);
                }
            }
            // ExEnd:DetectingTextBlocks  
        }
    }
}