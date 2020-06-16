using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class RecognizeImageFromStream
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();
            string result = "";

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image
            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(dataDir + "sample.png", FileMode.Open, FileAccess.Read))
            {
                file.CopyTo(ms);
                result = api.RecognizeImage(ms);
            }

            // Display the recognized text
            Console.WriteLine(result);
            // ExEnd:1

            Console.WriteLine("RecognizeImageFromStream executed successfully");
        }
    }
}
