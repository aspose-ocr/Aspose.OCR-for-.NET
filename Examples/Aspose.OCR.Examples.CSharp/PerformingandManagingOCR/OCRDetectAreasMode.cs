using System;
using System.Collections.Generic;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class OCRDetectAreasMode
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
            input.Add(dataDir + "table.png");

            // Recognize image
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                DetectAreasMode = DetectAreasMode.PHOTO
                // DetectAreasMode.NONE - faster but can recognize only simple text
                // DetectAreasMode.DOCUMENT - best for the multicolumn text, text with small images. Slowest one.
                // DetectAreasMode.PHOTO - best for the images with small text regions, some tables, receipts, invoices
                // DetectAreasMode.COMBINE - uses the union of DOCUMENT and PHOTO modes
            });

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("OCRDetectAreasMode executed successfully");
        }
    }
}
