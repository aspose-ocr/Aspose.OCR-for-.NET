using System;
using System.Collections;
using Aspose.OMR;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class SupplyMultipleWhiteLists
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Create an initialize an instance of OcrEngine
            OcrEngine engine = new OcrEngine();

            // Set the OcrEngine.Image property by loading an image from disk, memory or URL
            engine.Image = ImageStream.FromFile(dataDir + "Sample.bmp");

            // Create text recognition block by supplying X,Y coordinates and Width,Height values
            IRecognitionBlock block = RecognitionBlock.CreateTextBlock(6, 9, 120, 129);

            // Set the Whitelist property by specifying a new block whitelist
            block.Whitelist = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // YOU CAN ADD MORE TEXT BLOCK AND SET WHITE LISTS.

            // Set different configurations and add recognition block(s)
            engine.Config.ClearRecognitionBlocks();
            engine.Config.AddRecognitionBlock(block);
            engine.Config.DetectTextRegions = false;

            // Call OcrEngine.Process method to perform OCR operation
            if (engine.Process())
            {
                // Display the recognized text from each Page
                Console.WriteLine(engine.Text);
            }
        }
    }
}