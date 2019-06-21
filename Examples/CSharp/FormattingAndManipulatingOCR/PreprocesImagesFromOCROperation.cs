using System;
using System.IO;
using Aspose.OCR;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class PreprocesImagesFromOCROperation
    {
        public static void Run()
        {
            // ExStart:PreprocesImagesFromOCROperation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR() + "Sampleocr.bmp";

            // Initialize an instance of OcrEngine.
            OcrEngine ocr = new OcrEngine();

            // Set the Image property by loading the image from file path location.
            ocr.Image = ImageStream.FromFile(dataDir);

            // Set the SavePreprocessedImages property to false.
            ocr.Config.SavePreprocessedImages = false;

            if (ocr.Process())
            {
                // Do processing
                Console.WriteLine(ocr.Text);
            }
            // ExEnd:PreprocesImagesFromOCROperation
        }
    }
}
