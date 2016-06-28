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
    public class ExtractText
    {
        public static void Run()
        {
            // ExStart:ExtractText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Load template file
            OmrTemplate template = OmrTemplate.Load(dataDir + "questions.amr");

            // Load the image to be analyzed
            OmrImage image = OmrImage.Load(dataDir + "answers.jpg");

            // Set resource for TextOcrElement
            TextOcrElement.Resource = dataDir + "Aspose.OCR.Spanish.Resources.zip";
            // Create an instance of TextOcrElement and initialize it by specifying the location of text and its size in mm
            TextOcrElement textElement = new TextOcrElement("OCR Text", new PointF(23.6f, 15.5f), new SizeF(14.6f, 4.7f));
            // Add the TextOcrElement to the page element collection
            template.Pages[0].Elements.Add(textElement);

            // Create an instance of OmrEngine and load the template using file path
            OmrEngine engine = new OmrEngine(template);
            // Extract OMR data and store the results in an instance of OmrProcessingResults
            OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });
            // Get all page data into an instance of Hashtable
            Hashtable[] pages = result.PageData;
            // Loop over all the pages
            foreach (Hashtable page in pages)
            {
                // Display key and value
                foreach (string key in page.Keys)
                {
                    Console.WriteLine("key: " + key + ": " + "value: " + page[key]);
                }
            }
            // ExEnd:ExtractText
        }
    }
}
