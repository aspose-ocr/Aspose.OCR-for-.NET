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
    public class DetectUsingElements
    {
        public static void Run()
        {
            // ExStart:DetectUsingElements
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");

            // Iterate over the pages in template
            foreach (OmrPage page in template.Pages)
            {
                // Get elements of each page
                OmrElementsCollection collection = page.Elements;
                // Iterate over the element collection
                foreach (Object obj in collection)
                {
                    // Display element name
                    Console.WriteLine(obj.GetType().ToString());
                }
            }
            // ExEnd:DetectUsingElements
        }
    }
}
