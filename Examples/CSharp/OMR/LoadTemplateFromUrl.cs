//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.OCR. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections;
using Aspose.OMR;

namespace Aspose.OCR.Examples.OMR
{
    class LoadTemplateFromUrl
    {
        static void Main()
        {
            string templateUrl = "https://github.com/asposeocr/Aspose_OCR_NET/raw/master/Examples/Data/OMR/LoadTemplateFromUrl/questions.amr";
            string imageUrl = "https://github.com/asposeocr/Aspose_OCR_NET/raw/master/Examples/Data/OMR/LoadTemplateFromUrl/answers.jpg";

            // Initialize an instance of OmrTemplate by loading the OMR template from URL
            OmrTemplate template = OmrTemplate.LoadFromUrl(templateUrl);

            // image loading from url
            OmrImage image = OmrImage.LoadFromUrl(imageUrl);

            // continue working with template and image as usual
            OmrEngine engine = new OmrEngine(template);
            OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });

            // Get all page data into an instance of Hashtable
            Hashtable[] pages = result.PageData;
            // Loop over all the pages
            foreach (Hashtable page in pages)
            {
                // Display key and value
                foreach (string key in page.Keys)
                {
                    Console.WriteLine("[KEY] " + key + " => " + "[VALUE] " + page[key]);
                }
            }
        }
    }
}
