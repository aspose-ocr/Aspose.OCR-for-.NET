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
            string fileName = args.Length > 0 ? args[0] : "images/test.pdf";
            int pageStart = args.Length > 1 ? Int32.Parse(args[1]) : 0;
            int pageCount = args.Length > 2 ? Int32.Parse(args[2]) : 2;
            PrintStart(fileName);
            // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();
            // Create OcrInput object to containerize images
            // Add filters as you need
            OcrInput input = new OcrInput(InputType.PDF);
            input.Add(fileName, pageStart, pageCount);

            // Set the options for recognition - start page and the pages number
            List<RecognitionResult> res = api.Recognize(input, new RecognitionSettings
            {
                //// allowed options
                // AllowedCharacters = CharactersAllowedType.LATIN_ALPHABET, // ignore not latin symbols
                // AutoSkew = true, // switch off if your image not rotated
                // DetectAreasMode = DetectAreasMode.DOCUMENT, // depends on the structure of your image
                // IgnoredCharacters = "*-!@#$%^&", // define the symbols you want to ignore in the recognition result
                // Language = Language.Eng, // we support 26 languages
                // LinesFiltration = false, // this works slowly, so choose it only if your picture has lines and it they bad detected in TABLE ar DOCUMENT DetectAreasMode   
                // ThreadsCount = 1, // by default our API use all you threads. But you can run it in one thread. Simply set up this here
                // ThresholdValue = 150 // if you want to binarize image with your own threashold value, you can set up this here (from 1 to 255)
            });            

            Console.WriteLine("RESULT");
            Console.ResetColor();
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine($"PAGE {i+1}\n------------------------------------------------------------");
                Console.WriteLine(res[i].RecognitionText); 
                // you can print here additional information and spell-check the result
                // also you can save each page result in your prefered file format
                // res[i].Save(...);
                // or convert your result to json or xml string
                // res[i].GetJson();
                // res[i].GetXml();
            }

            // save result as one multipage document
            AsposeOcr.SaveMultipageDocument("out/result.pdf", SaveFormat.Pdf, res);

            PrintEnd();
        }

        static void PrintStart(string fileName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This example will work without a license. The result will be reduced.\n");
            Console.WriteLine($"Recognition [{fileName}] has begun. Please, wait...\n\n");
        }

        static void PrintEnd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();
            Console.ReadKey();
            System.Threading.Thread.Sleep(1000);
        }
    }
}

