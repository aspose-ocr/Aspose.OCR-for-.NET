using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.Features
{
    public class GetTextPartHierarchy
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExample.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Process the image
            if (ocrEngine.Process())
            {
                //Retrieve the first block of the recognized text part
                IRecognizedTextPartInfo firstBlock = (ocrEngine.Text.PartsInfo[0] as IRecognizedTextPartInfo);

                //Get the children of the first block that will the the lines in the block
                IRecognizedPartInfo[] linesOfFirstBlock = firstBlock.Children;

                //Retrieve the fist line from the collection of lines
                IRecognizedTextPartInfo firstLine = (linesOfFirstBlock[0] as IRecognizedTextPartInfo);

                //Display the level of line
                Console.WriteLine(firstLine.Level);

                //Retrieve the fist word from the collection of words
                IRecognizedTextPartInfo firstWord = (firstLine.Children[0] as IRecognizedTextPartInfo);

                //Display the level of word
                Console.WriteLine(firstWord.Level);

                //Retrieve the fist character from the collection of characters
                IRecognizedTextPartInfo firstCharacter = (firstWord.Children[0] as IRecognizedTextPartInfo);

                //Display the level of character
                Console.WriteLine(firstCharacter.Level);
            }


        }
    }
}