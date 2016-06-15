using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.Features.AdvancedConfiguration
{
    public class SettingOcrEngineAutomaticallyDetect
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExample.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Create an instance of OcrEngine class
            OcrEngine ocr = new OcrEngine();

            //Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Set the DetectReadingOrder to true
            ocr.Config.DetectReadingOrder = true;

            //Perform OCR operation
            if (ocr.Process())
            {
                //Display results
                Console.WriteLine(ocr.Text);
            }
        }
    }
}