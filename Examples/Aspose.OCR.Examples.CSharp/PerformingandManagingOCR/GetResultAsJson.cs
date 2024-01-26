using System;
using System.Collections.Generic;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class GetResultAsJson
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

            // Display the recognition result in JSON format
            Console.WriteLine(result[0].GetJson());
            // ExEnd:1

            Console.WriteLine("GetResultAsJson executed successfully");
        }
    }
}
