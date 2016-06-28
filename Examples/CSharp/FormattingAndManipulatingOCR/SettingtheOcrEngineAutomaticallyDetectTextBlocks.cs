using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class SettingtheOcrEngineAutomaticallyDetectTextBlocks
    {
        public static void Run()
        {
            // ExStart:SettingtheOcrEngineAutomaticallyDetectTextBlocks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OMR();

            // Create an instance of OcrEngine class
            OcrEngine ocr = new OcrEngine();

            // Set the DetectTextRegions to true
            ocr.Config.DetectTextRegions = true;

            // Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir + "Sampleocr.bmp");

            // Perform OCR operation on the image
            if (ocr.Process())
            {
                // Display results
                Console.WriteLine(ocr.Text);
            }
            // ExEnd:SettingtheOcrEngineAutomaticallyDetectTextBlocks
        }
    }
}
