using System;
using System.Collections;
using System.Drawing;
using System.IO;
using Aspose.OCR;
using Aspose.OMR;
using Aspose.OMR.Elements;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOMR
{
    public class DetectImageResolutionAutomatically
    {
        public static void Run()
        {
            // ExStart:DetectImageResolutionAutomatically
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");

            // Load the image to be analyzed
            OmrImage image = OmrImage.Load(dataDir + "answers.jpg");

            // Instantiate the recognition engine for the template
            OmrEngine engine = new OmrEngine(template);

            // Extract data. This template has only one page.
            OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });

            // Load actual result from
            Hashtable OmrResult = result.PageData[0];

            // Get Collection of Keys
            ICollection key = OmrResult.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + OmrResult[k]);
            }
            // ExEnd:DetectImageResolutionAutomatically
        }
    }
}
