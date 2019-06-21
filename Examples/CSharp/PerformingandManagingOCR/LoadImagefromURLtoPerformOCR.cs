using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class LoadImagefromURLtoPerformOCR
    {
        public static void Run()
        {
            // ExStart:LoadImagefromURLtoPerformOCR  
            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set the Image property by loading the image from remote location
            ocrEngine.Image = ImageStream.FromUrl("https://blog.aspose.com/wp-content/uploads/sites/2/2019/03/SampleTextOnline.jpg");
            
            // Run recognition process
            if (ocrEngine.Process())
            {
                // Display the recognized text
                Console.WriteLine(ocrEngine.Text);
            }
            // ExEnd:LoadImagefromURLtoPerformOCR  
        }
    }
}