//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.OCR. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
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
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(35, 21, 22, 26));
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(340, 63, 29, 37));
            
            //Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = false;

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir + "sampleocr.bmp");

            //Run recognition process
            if (ocrEngine.Process())
            {
                //Retrieve user defined blocks that determines the page layout
                IList<IRecognitionBlock> blocks = ocrEngine.Config.RecognitionBlocks;
                //Loop over the list of blocks
                foreach (IRecognitionBlock block in blocks)
                {
                    //Display if block is set to be recognized
                    Console.WriteLine(block.ToRecognize);
                    //Check if block has recognition data
                    if (block.RecognitionData == null)
                    {
                        Console.WriteLine("Null{0}", Environment.NewLine);
                        continue;
                    }
                    //Display dimension & size of rectangle that defines the recognition block
                    Console.WriteLine("Block: {0}", block.Rectangle);
                    if (block.RecognitionData is IRecognizedTextPartInfo)
                    {
                        //Display the recognition results
                        IRecognizedTextPartInfo textPartInfo = (IRecognizedTextPartInfo)block.RecognitionData;
                        Console.WriteLine("Text: {0}{1}", textPartInfo.Text, Environment.NewLine);
                    }
                }
            }
            
        }
    }
}