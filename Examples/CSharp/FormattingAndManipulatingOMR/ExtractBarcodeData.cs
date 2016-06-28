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
    public class ExtractBarcodeData
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_OCR();

                // Load template file
                OmrTemplate template = OmrTemplate.Load(dataDir + "sample_1.amr");

                // Load the image to be analyzed
                OmrImage image = OmrImage.Load(dataDir + "sample1.jpg");

                // do not forget to set the license for BarCode in case BarCode elements are used
                //Aspose.BarCode.License licenseBarCode = new Aspose.BarCode.License();
                //licenseBarCode.SetLicense(dataDir + "Aspose.Total.lic");
                 
                //// do not forget to set the license for BarCode in case BarCode elements are used
                //var licenseOmr = new Aspose.OCR.License();
                //licenseOmr.SetLicense(dataDir + "Aspose.Total.lic");

                // Adding BarCode element requires creation of BarcodeElement object
                // While specifying the barcode display name, its position and size
                BarcodeElement barcodeElement = new BarcodeElement("Aztec BarCode", new PointF(0, 0), new SizeF(205, 205));
                // Add the BarCode element to the page element collection
                template.Pages[0].Elements.Add(barcodeElement);

                // Create an instance of OmrEngine and load the template using file path
                OmrEngine engine = new OmrEngine(template);
                // Extract OMR data and store the results in an instance of OmrProcessingResults
                OmrProcessingResult result = engine.ExtractData(new[] { image });
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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
