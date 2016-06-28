
using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class ReadPartInformation
    {
        public static void Run()
        {
            // ExStart:ReadPartInformation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OMR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            // Run recognition process
            if (ocrEngine.Process())
            {
                Console.WriteLine(ocrEngine.Text);
                // Retrieve an array of recognized text by parts
                IRecognizedPartInfo[] text = ocrEngine.Text.PartsInfo;
                // Iterate over the text parts
                foreach (IRecognizedTextPartInfo symbol in text)
                {
                    // Display part intomation
                    Console.WriteLine("Text : " + symbol.Text);
                    Console.WriteLine("isItalic : " + symbol.Italic);                    
                    Console.WriteLine("Language : " + symbol.Language);
                }
            }
            // ExStart:ReadPartInformation            
        }
    }
}