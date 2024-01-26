using System;
using System.Collections.Generic;
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
            List<RecognitionResult> result = null;

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();         

            // Recognize image
            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(dataDir + "sample.png", FileMode.Open, FileAccess.Read))
            {
                file.CopyTo(ms);

                // Create OcrInput object and add stream
                OcrInput input = new OcrInput(InputType.SingleImage);
                input.Add(ms);
                result = api.Recognize(input);
            }

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("RecognizeImageFromStream executed successfully");
        }
    }
}
