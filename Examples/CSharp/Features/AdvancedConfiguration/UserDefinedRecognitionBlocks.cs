//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.OCR. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.Features.AdvancedConfiguration
{
    public class UserDefinedRecognitionBlocks
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Clear notifier list
            ocrEngine.ClearNotifies();

            //Clear recognition blocks
            ocrEngine.Config.ClearRecognitionBlocks();

            //Add 3 rectangle blocks to user defined recognition blocks
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 60, 700, 50));
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 10, 700, 50));
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreatePictureBlock(0, 10, 700, 50));

            //Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = false;

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Run recognition process
            if (ocrEngine.Process())
            {
                //Retrieve user defined blocks that determines the paye layout
                var blocks = ocrEngine.Config.RecognitionBlocks;
                //Loop over the list of blocks
                foreach (var block in blocks)
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