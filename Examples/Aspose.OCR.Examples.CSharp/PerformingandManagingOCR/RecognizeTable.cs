using System;
using System.Collections.Generic;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class RecognizeTable
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

            // Recognize image (case 1)
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                LinesFiltration = true, // if all image is table
                DetectAreasMode = DetectAreasMode.NONE // don't use NN for areas detection
            });
            // Display the recognized text
            Console.WriteLine("with lines filtration:\n" + result[0].RecognitionText);


            // Recognize image (case 2)
            result = api.Recognize(input, new RecognitionSettings
            {
                DetectAreasMode = DetectAreasMode.TABLE // use NN for areas detection
            });
            // Display the recognized text
            Console.WriteLine("use TABLE detect areas mode:\n"+result[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("RecognizeTable executed successfully");
        }
    }
}
