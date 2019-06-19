using System.IO;

using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class ExtractPreprocessedImage
    {
        public static void Run()
        {
            // ExStart:ExtractPreprocessedImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            // set SavePreprocessedImages to true to save preprocessed images
            ocrEngine.Config.SavePreprocessedImages = true;

            // Set the Image property by loading the image from file path location or an instance of Stream
            ocrEngine.Image = ImageStream.FromFile(dataDir + "Sample.jpg");

            if (ocrEngine.Process())
            {
                //Save binarized image on disc
                ocrEngine.PreprocessedImages.BinarizedImage.Save(dataDir + "Output\\BinarizedImage.png", System.Drawing.Imaging.ImageFormat.Png);

                //Save filtered image on disc
                ocrEngine.PreprocessedImages.FilteredImage.Save(dataDir + "Output\\FilteredImage.png", System.Drawing.Imaging.ImageFormat.Png);

                //Save image after removing non-textual fragments
                ocrEngine.PreprocessedImages.NonTextRemovedImage.Save(dataDir + "Output\\NonTextRemovedImage.png", System.Drawing.Imaging.ImageFormat.Png);

                //Save image after skew correction
                ocrEngine.PreprocessedImages.RotatedImage.Save(dataDir + "Output\\RotatedImage.png", System.Drawing.Imaging.ImageFormat.Png);

                //Save image after textual block detection
                ocrEngine.PreprocessedImages.TextBlocksImage.Save(dataDir + "Output\\TextBlocksImage.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            Console.WriteLine(ocrEngine.Text);
            // ExEnd:ExtractPreprocessedImage
        }
    }
}