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
    public class SetPageLevelThreshold
    {
        public static void Run()
        {
            // ExStart:SetPageLevelThreshold
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");

            // Load the image to be analyzed
            OmrImage image = OmrImage.Load(dataDir + "answers.jpg");

            // Get the first page of the template
            OmrPage page = template.Pages[0];

            // Create page configurations
            page.Configuration = new OmrConfig();

            // Set fill threshold
            page.Configuration.FillThreshold = 0.21;

            // Create an instance of OmrEngine and pass object of OmrTemplate as parameter
            OmrEngine engine = new OmrEngine(template);

            // Extract the data
            OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });
            // ExEnd:SetPageLevelThreshold
        }
    }
}
