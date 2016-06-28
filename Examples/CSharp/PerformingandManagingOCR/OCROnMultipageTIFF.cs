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

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class OCROnMultipageTIFF
    {
        public static void Run()
        {
            // ExStart:OCROnMultipageTIFF   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR() + "SampleTiff.tiff";

            // Create an initialize an instance of OcrEngine
            OcrEngine engine = new OcrEngine();

            // Set the OcrEngine.Image property by loading a multipage TIFF from disk, memory or URL
            engine.Image = ImageStream.FromFile(dataDir);

            // Set OcrEngine.ProcessAllPages to true in order to process all pages of TIFF in single run
            engine.ProcessAllPages = true;

            // Call OcrEngine.Process method to perform OCR operation
            if (engine.Process())
            {
                // Retrieve the list of Pages
                Page[] pages = engine.Pages;

                // Iterate over the list of Pages
                foreach (Page page in pages)
                {
                    // Display the recognized text from each Page
                    Console.WriteLine(page.PageText);
                }
            }
            // ExStart:OCROnMultipageTIFF   
        }
    }
}
