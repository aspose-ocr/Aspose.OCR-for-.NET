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
    public class SkewedImageSecondMethod
    {
        public static void Run()
        {
            // ExStart:SkewedImageSecondMethod
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load the image to be analyzed
            OmrImage image = OmrImage.Load(dataDir + "answers.jpg");

            OmrEngine engine = new OmrEngine(new OmrTemplate());

            // Get skew degree of the image
            double degree = engine.GetSkewDegree(image);

            // Rotate image to correct skew
            engine.RotateImage(ref image, degree);

            // Save image
            image.AsBitmap().Save(dataDir + "result_out.jpg");
            // ExEnd:SkewedImageSecondMethod
        }
    }
}
