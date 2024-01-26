using System;
using System.Collections.Generic;
using System.IO;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class ImageTextFinder
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            string imageName1 = "sample.png";
            string imageName2 = "sample.png";

            string imageName3 = "skew_image.png";


            // Recognize image
            bool isEqual = api.CompareImageTexts(dataDir + imageName1, dataDir + imageName2);

            if(isEqual)
            {
                Console.WriteLine($"{imageName1} and {imageName2} images has equal text.");
            }

            isEqual = api.CompareImageTexts(dataDir + imageName1, dataDir + imageName3);

            if (isEqual)
            {
                Console.WriteLine($"{imageName1} and {imageName3} images has equal text.");
            }
            else
            {
                float diff = api.ImageTextDiff(dataDir + imageName1, dataDir + imageName3);
                Console.WriteLine($"{imageName1} and {imageName3} has {diff} difference in texts.");
            }

            string text = "More than";
            bool isContain = api.ImageHasText(text,dataDir + imageName1);

            if (isContain)
            {
                Console.WriteLine($"{imageName1} contains {text}.");
            }


            // ExEnd:1

            Console.WriteLine("ImageTextFinder executed successfully");
        }
    }
}
