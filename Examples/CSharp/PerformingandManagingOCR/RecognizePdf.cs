using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class RecognizePdf
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Image Path
            string fullPath = dataDir + "multi_page_1.pdf";

            // Recognize image           
            List<RecognitionResult> results = api.RecognizePdf(fullPath, new DocumentRecognitionSettings { StartPage = 2, PagesNumber = 2});

            // Print result
            int pageCounter = 0;
            foreach (var result in results)
            {
                PrintRecognitionResult(result, pageCounter++);
            }
            // ExEnd:1

            Console.WriteLine("RecognizePdf executed successfully");
        }

        static void PrintRecognitionResult(RecognitionResult result, int page)
        {
            Console.WriteLine($"Page: {page}");
            Console.WriteLine($"Text: {result.RecognitionText}");

            Console.WriteLine("\n----------------------------------------");
        }
    }
}
