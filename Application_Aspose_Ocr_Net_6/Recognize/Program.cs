using Aspose.OCR;
using Aspose.OCR.Models.PreprocessingFilters;
using System;
using System.IO;

//recognize.exe --language rus --source scan.png > out.txt

namespace Aspose.OCR.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            InputParams inputParams =  ArgsReader.Run(args);
            if (inputParams == null)
                return;

            // Set the license file
            if(inputParams.licensePath != null)
            {
                License lic = new License();
                lic.SetLicense(inputParams.licensePath);
            }

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object to containerize images
            // Add filters as you need 
            // PreprocessingFilter filters = new PreprocessingFilter // we automaticaly preprocess your image, but if your recognition result still bad, you can set up the set of filters by your own
            // {
            //     PreprocessingFilter.Dilate()
            // },
            OcrInput input = new OcrInput(inputParams.fileType/*, filters*/);
            input.Add(inputParams.inputPath);

            var res = api.Recognize(input, new RecognitionSettings
            {
                //// allowed options
                // AllowedCharacters = CharactersAllowedType.LATIN_ALPHABET, // ignore not latin symbols
                 DetectAreasMode = DetectAreasMode.TABLE, // depends on the structure of your image
                // IgnoredSymbols = "*-!@#$%^&", // define the symbols you want to ignore in the recognition result
                   Language = inputParams.language, // we support 26 languages
                // LinesFiltration = false, // this works slowly, so choose it only if your picture has lines and it they bad detected in TABLE ar DOCUMENT DetectAreasMode              
                // RecognitionAreas = new System.Collections.Generic.List<Aspose.Drawing.Rectangle> // set this if you want to recognize only partiqular regions on the image
                // {
                //     new Aspose.Drawing.Rectangle(0,0,10,20)
                // },
                // RecognizeSingleLine = false, // set this true if your image has only one text line (without other objects)
                // ThreadsCount = 1, // by default our API use all you threads. But you can run it in one thread. Simply set up this here
            });

            if(inputParams.outputPath == null)
            {
                foreach (var item in res)
                {
                    Console.WriteLine(item.RecognitionText);
                    Console.WriteLine();
                }
            }
            else
            {
                AsposeOcr.SaveMultipageDocument(inputParams.outputPath, SaveFormat.Text, res);
            }
        }

        static void ConsoleLogRecognitionResult(RecognitionResult result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nText:");
            Console.ResetColor();

            Console.WriteLine(result.RecognitionText);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nSkew:");
            Console.ResetColor();

            Console.WriteLine($"{result.Skew}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAreas coordinates:");
            Console.ResetColor();

            result.RecognitionAreasRectangles.ForEach(a => Console.WriteLine($"x: {a.X} y: {a.Y} width: {a.Width} height: {a.Height}"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAreas text:");
            Console.ResetColor();

            result.RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nLines:");
            Console.ResetColor();

            result.RecognitionLinesResult.ForEach(a => Console.WriteLine($"x: {a.Line.X} y: {a.Line.Y} width: {a.Line.Width} height: {a.Line.Height}\n{a.TextInLine}"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWarnings:");
            Console.ResetColor();

            result.Warnings.ForEach(w => Console.WriteLine($"{w}"));
        }
    }
}
