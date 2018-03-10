using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class AddingUserDefinedRecognitionBlocks
    {
        public static void Run()
        {
            // ExStart:AddingUserDefinedRecognitionBlocks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Clear notifier list
            ocrEngine.ClearNotifies();

            // Clear recognition blocks
            ocrEngine.Config.ClearRecognitionBlocks();

            // Add 3 rectangle blocks to user defined recognition blocks
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 10, 20, 40));
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 4, 5, 6));
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 5, 5, 6));
            
            // Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = false;

            // Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir + "sample1.jpg");

            // Run recognition process
            if (ocrEngine.Process())
            {
                // Retrieve user defined blocks that determines the paye layout
                var blocks = ocrEngine.Config.RecognitionBlocks;
                // Loop over the list of blocks
                foreach (var block in blocks)
                {
                    // Display if block is set to be recognized
                    Console.WriteLine(block.ToRecognize);
                    // Check if block has recognition data
                    if (block.RecognitionData == null)
                    {
                        Console.WriteLine("Null{0}", Environment.NewLine);
                        continue;
                    }
                    // Display dimension & size of rectangle that defines the recognition block
                    Console.WriteLine("Block: {0}", block.Rectangle);
                    if (block.RecognitionData is IRecognizedTextPartInfo)
                    {
                        // Display the recognition results
                        IRecognizedTextPartInfo textPartInfo = (IRecognizedTextPartInfo)block.RecognitionData;
                        Console.WriteLine("Text: {0}{1}", textPartInfo.Text, Environment.NewLine);
                    }
                }
            }
            // ExEnd:AddingUserDefinedRecognitionBlocks            
        }
    }
}