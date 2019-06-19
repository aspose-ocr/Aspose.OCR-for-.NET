using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class PerformOCROnPDF
    {
        public static void Run()
        {
            // ExStart:PerformOCROnPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            //Create an instance of Document to load the PDF
            var pdfDocument = new Aspose.Pdf.Document(dataDir + "Sample.pdf");

            //Create an instance of OcrEngine for recognition
            var ocrEngine = new Aspose.OCR.OcrEngine();

            //Iterate over the pages of PDF
            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                //Creating a MemoryStream to hold the image temporarily
                using (var imageStream = new System.IO.MemoryStream())
                {
                    //Create Resolution object with DPI value
                    var resolution = new Aspose.Pdf.Devices.Resolution(300);

                    //Create JPEG device with specified attributes (Width, Height, Resolution, Quality)
                    //where Quality [0-100], 100 is Maximum
                    var jpegDevice = new Aspose.Pdf.Devices.JpegDevice(resolution, 100);

                    //Convert a particular page and save the image to stream
                    jpegDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                    imageStream.Position = 0;

                    //Set Image property of OcrEngine to the stream obtained from previous step
                    ocrEngine.Image = Aspose.OCR.ImageStream.FromStream(imageStream, Aspose.OCR.ImageStreamFormat.Jpg);

                    //Perform OCR operation on one page at a time
                    if (ocrEngine.Process())
                    {
                        Console.WriteLine(ocrEngine.Text);
                    }
                }
            }
            // ExStart:PerformOCROnPDF            
        }
    }
}