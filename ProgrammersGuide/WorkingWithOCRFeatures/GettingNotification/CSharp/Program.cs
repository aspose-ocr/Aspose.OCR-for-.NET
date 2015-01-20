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

namespace GettingNotificationExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Get an instance of INotifier
            INotifier processorWord = Notifier.Word();

            //Write a delegate to handle the Elapsed event
            processorWord.Elapsed += delegate
            {
                //Display the recognized text on screen
                Console.WriteLine(processorWord.Text);
            };

            // Add the word processor to the OcrEngine
            ocrEngine.AddNotifier(processorWord);

            //Process the image
            ocrEngine.Process();
            
            
        }
    }
}