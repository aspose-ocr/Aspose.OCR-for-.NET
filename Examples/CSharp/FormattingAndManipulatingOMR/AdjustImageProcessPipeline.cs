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
    public class AdjustImageProcessPipeline
    {
        public static void Run()
        {
            // ExStart:DetectUsingElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file and Instantiate the recognition engine for the template
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");
            OmrEngine engine = new OmrEngine(template);

            // First, remove all default steps
            engine.ProcessingPipeline.Clear();

            // Now add the grayscale convertor  It may not be necessary to add it if the scans are already in grayscale and              Adding the Otsu’s binarization algorithm 
            engine.ProcessingPipeline.Add(new GrayscaleAlgorithm());
            engine.ProcessingPipeline.Add(new OtsuBinarizationAlgorithm());
            // ExEnd:DetectUsingElements
        }
    }
}
