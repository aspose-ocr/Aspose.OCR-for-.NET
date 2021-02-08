using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class SpecifyAllowedCharacters
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr with allowed symbols
            AsposeOcr api = new AsposeOcr("0123456789");

            // Recognize image
            string result = api.RecognizeLine(dataDir + "0001460985.Jpeg");

            // Display the recognized text
            Console.WriteLine(result);
            // ExEnd:1

            Console.WriteLine("SpecifyAllowedCharacters executed successfully");
        }
    }
}
