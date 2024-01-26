using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class GetChoiceForRecognizedCharacters
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Image Path
            string fullPath = dataDir + "sample.png";

            // Create OcrInput object and add image
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(fullPath);

            // Recognize image           
            List<RecognitionResult> result = api.Recognize(input, new RecognitionSettings
            {
                //default or custom
            });

            List<char[]> resultWithChoices = result[0].RecognitionCharactersList;
            // Print result
            Console.WriteLine($"Text:\n {result[0].RecognitionText}");
            Console.WriteLine("Choices:");
            resultWithChoices.ForEach(a => Console.WriteLine($"character: {a[0]} . Choices: {a[1]} {a[2]} {a[3]} {a[4]}"));
            // ExEnd:1

            Console.WriteLine("GetChoiceForRecognizedCharacters executed successfully");
        }
    }
}
