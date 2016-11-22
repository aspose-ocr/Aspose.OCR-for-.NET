using System;
using System.Collections;
using System.Drawing;
using System.IO;
using Aspose.OCR;
using Aspose.OMR;
using Aspose.OMR.Elements;
using Aspose.OMR.ImageProcessing;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR
{
    public class ExtractPreprocessedImages
    {
        public static void Run()
        {
            // ExStart:ExtractPreprocessedImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir + "sample1.jpg");
            ocrEngine.Config.SavePreprocessedImages = true;

            // Process the image
            if (ocrEngine.Process())
            {
                // Save binarized,filtered image on disc
                ocrEngine.PreprocessedImages.BinarizedImage.Save(dataDir + "BinarizedImage_out.png", System.Drawing.Imaging.ImageFormat.Png);
                ocrEngine.PreprocessedImages.FilteredImage.Save(dataDir + "FilteredImage_out.png", System.Drawing.Imaging.ImageFormat.Png);

                // Save image after removing non-textual fragments,  skew correction and textual block detection
                ocrEngine.PreprocessedImages.NonTextRemovedImage.Save(dataDir + "NonTextRemovedImage_out.png", System.Drawing.Imaging.ImageFormat.Png);
                ocrEngine.PreprocessedImages.RotatedImage.Save(dataDir + "RotatedImage_out.png", System.Drawing.Imaging.ImageFormat.Png);
                ocrEngine.PreprocessedImages.TextBlocksImage.Save(dataDir + "TextBlocksImage_out.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            // ExEnd:ExtractPreprocessedImages
        }
    }
}
