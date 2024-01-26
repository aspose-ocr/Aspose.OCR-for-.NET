using System;
using System.Collections.Generic;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class OCRPassports
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
            input.Add(dataDir + "passport.jpg");

            // Recognize image
            List<RecognitionResult> result = api.RecognizePassport(input, new PassportRecognitionSettings
            {
                Country = Country.UNIVERSAL
            });

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("OCRPassports executed successfully");
        }
    }
}
