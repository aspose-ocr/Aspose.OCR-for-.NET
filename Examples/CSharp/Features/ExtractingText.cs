using System;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.Features
{
    public class ExtractingText
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir =  RunExample.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Clear notifier list
            ocrEngine.ClearNotifies();

            //Clear recognition blocks
            ocrEngine.Config.ClearRecognitionBlocks();

            //Add 2 rectangles to user defined recognition blocks
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(27, 63, 34, 38)); //Detecting A
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(209, 111, 28, 34)); //Detecting 6
            
            //Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = false;

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir + "sampleocr.bmp"); 

            //Run recognition process
            if (ocrEngine.Process())
            {
                Console.WriteLine(ocrEngine.Text);
            }

        }
    }
}