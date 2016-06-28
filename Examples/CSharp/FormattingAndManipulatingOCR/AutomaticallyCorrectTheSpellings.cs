using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class AutomaticallyCorrectTheSpellings
    {
        public static void Run()
        {
            // ExStart:AutomaticallyCorrectTheSpellings
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();
            // Create an instance of OcrEngine class
            OcrEngine ocr = new OcrEngine();

            // Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir + "sampleocr_spell.bmp");

            // Set the DoSpellingCorrection to true
            ocr.Config.DoSpellingCorrection = true;

            // Perform OCR operation
            if (ocr.Process())
            {
                // Display results
                Console.WriteLine(ocr.Text);
            }
            // ExEnd:AutomaticallyCorrectTheSpellings            
        }
    }
}