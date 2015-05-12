//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.OCR. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using Aspose.OCR;

namespace ExtractingText
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

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