using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class SaveResultAsDocument
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image
            RecognitionResult result = api.RecognizeImage(dataDir + "sample.png", new RecognitionSettings { });

            // Save the result in your preferred format
            result.Save(RunExamples.GetDataDir_OCR()+"sample.docx", SaveFormat.Docx);
            result.Save(RunExamples.GetDataDir_OCR() + "sample.txt", SaveFormat.Text);
            // ExEnd:1

            Console.WriteLine("SaveResultAsDocument executed successfully");
        }
    }
}
