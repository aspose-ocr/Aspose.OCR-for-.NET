using System;
using System.Collections.Generic;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class SpecifyAllowedCharacters
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // The first case:
            // Initialize an instance of AsposeOcr with allowed symbols
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(dataDir + "0001460985.Jpeg");

            // Recognize image
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                RecognizeSingleLine = true,
                AllowedSymbols = "0123456789"
            });

            // Display the recognized text
            Console.WriteLine(result[0].RecognitionText);

            // The second case:

            // Recognize image            
            List<RecognitionResult> result2 = api.Recognize(input, 
                new RecognitionSettings { 
                    AllowedCharacters = CharactersAllowedType.DIGITS,
                    RecognizeSingleLine = true
                });

            // Display the recognized text
            Console.WriteLine(result2[0].RecognitionText);
            // ExEnd:1

            Console.WriteLine("SpecifyAllowedCharacters executed successfully");
        }
    }
}
