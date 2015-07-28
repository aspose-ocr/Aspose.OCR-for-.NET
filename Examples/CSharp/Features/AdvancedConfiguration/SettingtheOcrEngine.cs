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
    public class SettingtheOcrEngine
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //Create an instance of OcrEngine class
            OcrEngine ocr = new OcrEngine();

            //Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Set the RemoveNonText to true
            ocr.Config.RemoveNonText = true;

            //Perform OCR operation
            if (ocr.Process())
            {
                //Display results
                Console.WriteLine(ocr.Text);
            }
            
        }
    }
}