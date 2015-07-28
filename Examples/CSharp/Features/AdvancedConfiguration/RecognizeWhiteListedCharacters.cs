//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.OCR. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.OCR;

namespace Aspose.OCR.Examples.Features.AdvancedConfiguration
{
    public class RecognizeWhiteListedCharacters
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Retrieve the OcrConfig of the OcrEngine object
            OCRConfig ocrConfig = ocrEngine.Config;

            //Set the Whitelist property to recognize numbers only
            ocrConfig.Whitelist = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            //Set the Image property of OcrEngine object
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Call the Process method to retrieve the results
            ocrEngine.Process();
        }
    }
}