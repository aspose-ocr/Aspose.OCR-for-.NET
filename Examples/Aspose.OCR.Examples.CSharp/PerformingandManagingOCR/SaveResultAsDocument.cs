using System;
using System.Collections.Generic;
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

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(dataDir + "sample.png");

            // Recognize image
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings { });

            // Save the result in your preferred format
            result[0].Save(RunExamples.GetDataDir_OCR()+"sample.docx", SaveFormat.Docx);
            result[0].Save(RunExamples.GetDataDir_OCR() + "sample.txt", SaveFormat.Text);
            result[0].Save(RunExamples.GetDataDir_OCR() + "sample.pdf", SaveFormat.Pdf);
            result[0].Save(RunExamples.GetDataDir_OCR() + "sample.xlsx", SaveFormat.Xlsx);
            // ExEnd:1

            Console.WriteLine("SaveResultAsDocument executed successfully");
        }
    }
}
