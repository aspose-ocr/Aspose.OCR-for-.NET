using System;
using System.Collections;
using System.Drawing;
using System.IO;
using Aspose.OCR;
using Aspose.OMR;
using Aspose.OMR.Elements;
using Aspose.OCR.Examples.CSharp;
using System.Threading;

namespace CSharp.FormattingAndManipulatingOMR
{
    class MeteredLicensingOMR
    {
        public static void Run()
        {
            // ExStart:ExtractText
            
            // Create an instance of Metered class
            Metered matered = new Metered();

            // Set public & private keys
            matered.SetMeteredKey("publicKeyValue", "privateKeyValue");
 
            // Get consumed quantity before calling any API method
            decimal amountBefore = Metered.GetConsumptionQuantity();
            
            // Display value
            Console.WriteLine(amountBefore.ToString());
 
            // DO PROCDESSING
            // The path to the documents directory
            //string dataDir = RunExamples.GetDataDir_OCR();

            // Create an instance of OmrEngine and load the template using file path
            //OmrEngine omr = new OmrEngine(new OmrTemplate());

            //string path = dataDir + "sampleimage.png";
            //OmrImage omrImage = OmrImage.Load(path);
 
            ////Since upload data is running on another thread, so we need wait some time
            //Thread.Sleep(10000);

            // Get consumed quantity after calling any API method
            decimal amountAfter = Metered.GetConsumptionQuantity();

            // Display value
            Console.WriteLine(amountAfter.ToString());

            // ExEnd:ExtractText
        }
    }
}
