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
    public class SetElementLevelThreshold
    {
        public static void Run()
        {
            // ExStart:SetElementLevelThreshold
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");

            // Load the image to be analyzed
            OmrImage image = OmrImage.Load(dataDir + "answers.jpg");

            // Get the first page of the template
            OmrPage page = template.Pages[0];

            // Create an element by passing the name, location and size
            GridElement element = new GridElement("grid1", new PointF(10, 20), new SizeF(60, 30));

            // Add element to the page
            page.Elements.Add(element);

            // Create configuration for the element
            element.Configuration = new OmrConfig();

            // Set the TrimWhitePixels to false
            element.Configuration.TrimWhitePixels = false;

            // Create an instance of OmrEngine and pass object of OmrTemplate as parameter
            OmrEngine engine = new OmrEngine(template);

            // Extract the data
            OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });
            // ExEnd:SetElementLevelThreshold
        }
    }
}
