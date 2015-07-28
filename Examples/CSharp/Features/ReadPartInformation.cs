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

namespace Aspose.OCR.Examples.Features
{
    public class ReadPartInformation
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Run recognition process
            if (ocrEngine.Process())
            {
                Console.WriteLine(ocrEngine.Text);
                // Retrieve an array of recognized text by parts
                IRecognizedPartInfo[] text = ocrEngine.Text.PartsInfo;
                // Iterate over the text parts
                foreach (IRecognizedTextPartInfo symbol in text)
                {
                    // Display part intomation
                    Console.WriteLine("Text : " + symbol.Text);
                    Console.WriteLine("isItalic : " + symbol.Italic);
                    Console.WriteLine("isUnderline : " + symbol.Underline);
                    Console.WriteLine("isBold : " + symbol.Bold);
                    Console.WriteLine("FontSize : " + symbol.FontSize);
                    Console.WriteLine("Language : " + symbol.Language);
                }
            }
            
        }
    }
}