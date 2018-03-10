using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class SettingtheOcrEngine
    {
        public static void Run()
        {
            // ExStart:SettingtheOcrEngine
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();
            // Create an instance of OcrEngine class
            OcrEngine ocr = new OcrEngine();

            // Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            // Set the RemoveNonText to true
            ocr.Config.RemoveNonText = true;

            // Perform OCR operation
            if (ocr.Process())
            {
                // Display results
                Console.WriteLine(ocr.Text);
            }
            // ExEnd:SettingtheOcrEngine            
        }
    }
}