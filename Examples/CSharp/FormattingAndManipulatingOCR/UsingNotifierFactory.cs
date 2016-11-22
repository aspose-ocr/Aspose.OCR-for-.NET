using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class UsingNotifierFactory
    {
        public static void Run()
        {
            // ExStart:UsingNotifierFactory
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir + "answers.jpg");

            // Get an instance of WordNotifier, Write a delegate to handle the Elapsed event and Display the recognized text on screen
            INotifier processorBlock = NotifierFactory.BlockNotifier();
            processorBlock.Elapsed += delegate
            {
                Console.WriteLine(processorBlock.Text);                
            };

            // Add the word processor to the OcrEngine and Process the image
            ocrEngine.AddNotifier(processorBlock);
            ocrEngine.Process();
            // ExEnd:UsingNotifierFactory            
        }
    }
}