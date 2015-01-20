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

namespace DetectingTextBlocksExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Remove non-textual blocks
            ocrEngine.Config.RemoveNonText = true;

            //Run recognition process
            if (ocrEngine.Process())
            {
                //Display text block locations
                Console.WriteLine(ocrEngine.Text.PartsInfo[0].Box);
                Console.WriteLine(ocrEngine.Text.PartsInfo[1].Box);
            }
        }
    }
}