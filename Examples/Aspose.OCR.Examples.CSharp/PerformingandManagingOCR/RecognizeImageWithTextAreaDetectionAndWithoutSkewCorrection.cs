using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class RecognizeImageWithTextAreaDetectionAndWithoutSkewCorrection
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image
            string result = api.RecognizeImage(dataDir + "sample.png", true, false);

            // Display the recognized text
            Console.WriteLine(result);
            // ExEnd:1

            Console.WriteLine("RecognizeImageWithTextAreaDetectionAndWithoutSkewCorrection executed successfully");
        }
    }
}
