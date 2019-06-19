using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class RecognizeWhiteListedCharacters
    {
        public static void Run()
        {
            // ExStart:RecognizeWhiteListedCharacters
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Retrieve the OcrConfig of the OcrEngine object
            OCRConfig ocrConfig = ocrEngine.Config;

            // Set the Whitelist property to recognize numbers only
            ocrConfig.Whitelist = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            // Set the Image property of OcrEngine object
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "SampleNumbers.jpg");

            // Call the Process method to retrieve the results
            ocrEngine.Process();

            Console.WriteLine("Output: " + ocrEngine.Text);
            // ExEnd:RecognizeWhiteListedCharacters
        }
    }
}