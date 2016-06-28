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

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOMR
{
    public class SkewImageCorrectionUsingAlgorithm
    {
        public static void Run()
        {
            // ExStart:SkewImageCorrectionUsingAlgorithm
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");

            // Load the image to be analyzed
            OmrImage image = OmrImage.Load(dataDir + "answers.jpg");


            // Area of the image to be processed
            Rectangle area = new Rectangle(0, 0, image.Width, image.Height);

            // Grayscale conversion
            GrayscaleAlgorithm gs = new GrayscaleAlgorithm();
            gs.Process(image, area);

            // Binarization
            AverageThresholdAlgorithm threshold = new AverageThresholdAlgorithm();
            threshold.Process(image, area);

            // Skew correction
            SkewCorrectionAlgorithm skewCorrection = new SkewCorrectionAlgorithm();
            skewCorrection.Process(ref image, area);

            // save image
            image.AsBitmap().Save(dataDir + "result_out.jpg");
            // ExEnd:SkewImageCorrectionUsingAlgorithm
        }
    }
}
