using System.IO;
using Aspose.OCR;
using System;
using System.Drawing;

namespace Aspose.OCR.Examples.CSharp.Features
{
    public class GetLocationAndSizeExample
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir =  RunExample.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Run recognition process
            if (ocrEngine.Process())
            {
                Console.WriteLine(ocrEngine.Text);
                //Retrieve an array of recognized text by parts
                IRecognizedPartInfo[] text = ocrEngine.Text.PartsInfo;
                //Iterate over the text parts
                foreach (IRecognizedTextPartInfo symbol in text)
                {
                    //Display the part information
                    Console.WriteLine("Symbol:" + symbol.Text);
                    //Get the rectangle sourronding the symbol
                    Rectangle box = symbol.Box;
                    //Display the rectangle location on the image canvas
                    Console.WriteLine("Box Location:" + box.Location);
                    //Display the rectangle dimensions
                    Console.WriteLine("Box Size:" + box.Size);

                }
            }
            
        }
    }
}