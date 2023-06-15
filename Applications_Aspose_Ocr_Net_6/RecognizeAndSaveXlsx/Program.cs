using Aspose.OCR;
using System;
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
            // PreprocessingFilter filters = new PreprocessingFilter // we automaticaly preprocess your image, but if your recognition result still bad, you can set up the set of filters by your own
                // {
                //     PreprocessingFilter.Dilate()
                // }
            OcrInput input = new OcrInput(InputType.SingleImage/*, filters*/);
            input.Add("table.png");
            var result = api.Recognize(input, new RecognitionSettings 
            { 
                DetectAreasMode = DetectAreasMode.PHOTO
                //// allowed options
                // AllowedCharacters = CharactersAllowedType.LATIN_ALPHABET, // ignore not latin symbols
                // AutoContrast = false, // use Contrast correction filter before recognition - good for images with noice 
                // AutoSkew = true, // switch off if your image not rotated
                // DetectAreas = true, // switch off if your image has a simple document structure (one column text without pictures)
                // DetectAreasMode = DetectAreasMode.DOCUMENT, // depends on the structure of your image
                // IgnoredCharacters = "*-!@#$%^&", // define the symbols you want to ignore in the recognition result
                // Language = Language.Eng, // we support 26 languages
                // LinesFiltration = false, // this works slowly, so choose it only if your picture has lines and it they bad detected in TABLE ar DOCUMENT DetectAreasMode
               
                // RecognitionAreas = new System.Collections.Generic.List<System.Drawing.Rectangle> // set this if you want to recognize only partiqular regions on the image
                // {
                //     new System.Drawing.Rectangle(0,0,10,20)
                // },
                // RecognizeSingleLine = false, // set this true if your image has only one text line (without other objects)
                // SkewAngle = 5, // use this if your want to switch on out automatically skew correction and set up your own angle
                // ThreadsCount = 1, // by default our API use all you threads. But you can run it in one thread. Simply set up this here
                // ThresholdValue = 150 // if you want to binarize image with your own threashold value, you can set up this here (from 1 to 255)
            });
         
            Console.ResetColor();
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"\nText: {result[0].RecognitionText}");
            Console.WriteLine($"\nSkew: {result[0].Skew}");
            // you can print here additional information and spell-check the result
            // also you can save each page result in your prefered file format
            // res.Save(...);
            // or convert your result to json or xml string
            // result.GetJson();
            // result.GetXml();

            // Save the result
            // Set:
            // 1) path for new file
            // 2) File format
            // 3) set true if you want to correct the mistakes in the words
            // 4) set the language if you want to correct the mistakes
            // 5) you can set your own dictionary for spell-check
            result[0].Save("result.xlsx", SaveFormat.Xlsx);

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
            Console.ReadKey();
            System.Threading.Thread.Sleep(10000);
        }
    }
}

