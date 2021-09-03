using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class GetRecognitionResult
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

            // Recognize image           
            RecognitionResult result = api.RecognizeImage(fullPath, new RecognitionSettings
            {
                //default or custom
            });

            // Print result
            PrintRecognitionResult(result);
            // ExEnd:1

            Console.WriteLine("GetRecognitionResult executed successfully");
        }

        static void PrintRecognitionResult(RecognitionResult result)
        {
            Console.WriteLine($"Text: {result.RecognitionText}");
            Console.WriteLine($"skew: {result.Skew}");
            Console.WriteLine("Areas:");
            result.RecognitionAreasText.ForEach(a => Console.WriteLine($"{a}"));

            Console.WriteLine("Lines:");
            result.RecognitionLinesResult.ForEach(a => Console.WriteLine($"{a.TextInLine}"));
            result.RecognitionLinesResult.ForEach(a => Console.WriteLine($"X: {a.Line.X} Y: {a.Line.Y} Width: {a.Line.Width} Height: {a.Line.Height}"));

            Console.WriteLine("Choices:");
            result.RecognitionCharactersList.ForEach(a => Console.WriteLine($"{a[0]} {a[1]} {a[2]} {a[3]} {a[4]}"));

            Console.WriteLine($"JSON: {result.GetJson()}");

            Console.WriteLine("Paragraphes:");
            result.RecognitionAreasRectangles.ForEach(w => Console.WriteLine($"{w.X} {w.Y} {w.Width} {w.Height}"));

            Console.WriteLine("Warnings:");
            result.Warnings.ForEach(w => Console.WriteLine($"{w}"));

            Console.WriteLine("\n----------------------------------------");
        }
    }
}
