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

namespace Aspose.OCR.Examples.WorkingWithOcr
{
    public class PerformOCROnImage
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir + "Sampleocr.bmp");

            //Process the image
            if (ocrEngine.Process())
            {
                //Display the recognized text
                Console.WriteLine(ocrEngine.Text);
            }
        }
    }
}
