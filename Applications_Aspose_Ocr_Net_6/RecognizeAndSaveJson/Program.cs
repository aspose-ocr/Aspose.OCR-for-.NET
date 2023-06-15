using Aspose.OCR;
using Aspose.OCR.Models.PreprocessingFilters;
using System;
using System.Collections.Generic;
using System.IO;

namespace RecognizePNG
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStart();
            // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();
            // Create OcrInput object to containerize images
            // Add filters as you need
            PreprocessingFilter filters = new PreprocessingFilter // we automaticaly preprocess your image, but if your recognition result still bad, you can set up the set of filters by your own
            {
                //PreprocessingFilter.Dilate()
            };
            OcrInput input = new OcrInput(InputType.SingleImage, filters);
            input.Add("test.png");

            List<RecognitionResult> res = api.Recognize(input, new RecognitionSettings 
            {
                //// allowed options
                // AllowedCharacters = CharactersAllowedType.LATIN_ALPHABET, // ignore not latin symbols
                // AutoSkew = true, // switch off if your image not rotated
                // DetectAreasMode = DetectAreasMode.DOCUMENT, // depends on the structure of your image
                // IgnoredCharacters = "*-!@#$%^&", // define the symbols you want to ignore in the recognition result
                // Language = Language.Eng, // we support 26 languages
                // LinesFiltration = false, // this works slowly, so choose it only if your picture has lines and it they bad detected in TABLE ar DOCUMENT DetectAreasMode
             
                // RecognitionAreas = new System.Collections.Generic.List<System.Drawing.Rectangle> // set this if you want to recognize only partiqular regions on the image
                // {
                //     new System.Drawing.Rectangle(0,0,10,20)
                // },
                // RecognizeSingleLine = false, // set this true if your image has only one text line (without other objects)
                // ThreadsCount = 1, // by default our API use all you threads. But you can run it in one thread. Simply set up this here
                // ThresholdValue = 150 // if you want to binarize image with your own threashold value, you can set up this here (from 1 to 255)
            });

            // Save the result
            // Set:
            // 1) path for new file
            // 2) File format
            // 3) set true if you want to correct the mistakes in the words
            // 4) set the language if you want to correct the mistakes
            // 5) you can set your own dictionary for spell-check
            res[0].Save("result.json", SaveFormat.Json, false);        

            PrintEnd();
        }

        static void PrintStart()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This example will work without a license. The result will be reduced.\n");
            Console.WriteLine("Recognition has begun. Please, wait...\n\n");
        }

        static void PrintEnd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The json file was saved by the name result.json. Check the folder.");

            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

