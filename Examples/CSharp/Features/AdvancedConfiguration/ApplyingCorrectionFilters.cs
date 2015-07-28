//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.OCR. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.OCR;
using Aspose.OCR.Filters;
using System;

namespace Aspose.OCR.Examples.Features.AdvancedConfiguration
{
    public class ApplyingCorrectionFilters
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Create CorrectionFilters collection
            CorrectionFilters filters = new CorrectionFilters();
            Filter filter = null;

            //Initialize Median filter
            filter = new MedianFilter(5);
            filters.Add(filter);

            //Create Gaussian Blur filter
            filter = new GaussBlurFilter();
            filters.Add(filter);

            //Create Noise Removal filter
            filter = new RemoveNoiseFilter();
            filters.Add(filter);

            //Assign collection to OcrEngine
            ocrEngine.Config.CorrectionFilters = filters;

            //Run recognition process
            if (ocrEngine.Process())
            {
                //Display results
                Console.WriteLine(ocrEngine.Text);
            }
            
        }
    }
}