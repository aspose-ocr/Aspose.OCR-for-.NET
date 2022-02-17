using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class OCROperationWithFolder
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Image Path
            string fullPath = dataDir + "OCR";

            // Recognize image           
            RecognitionResult[] result = api.RecognizeMultipleImages(fullPath, new RecognitionSettings
            {
                //default or custom
            });

            // Print result
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Image: {i}\n Result:\n {result[i].RecognitionText}");
            }

            // ExEnd:1
            Console.WriteLine("OCROperationWithFolder executed successfully");
        }
    }
}
