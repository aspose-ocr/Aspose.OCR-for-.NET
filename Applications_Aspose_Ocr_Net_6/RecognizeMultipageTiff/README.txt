The source images: three_page.tif
The source code:

        // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object to containerize images
            // Add filters as you need 
            // PreprocessingFilter filters = new PreprocessingFilter // we automaticaly preprocess your image, but if your recognition result still bad, you can set up the set of filters by your own
            // {
            //     PreprocessingFilter.Dilate()
            // },
            OcrInput input = new OcrInput(InputType.TIFF/*, filters*/);
            input.Add(fileName, pageStart, pageCount);

            // Set the options for recognition - start page and the pages number
            var res = api.Recognize(input, new RecognitionSettings 
            {
                //// allowed options
                // AllowedCharacters = CharactersAllowedType.LATIN_ALPHABET, // ignore not latin symbols
                // AutoContrast = false, // use Contrast correction filter before recognition - good for images with noice 
                // AutoSkew = true, // switch off if your image not rotated
                // DetectAreas = true, // switch off if your image has a simple document structure (one column text without pictures)
                // DetectAreasMode = DetectAreasMode.DOCUMENT, // depends on the structure of your image
                // IgnoredCharacters = "*-!@#$%^&", // define the symbols you want to ignore in the recognition result
                // Language = Language.Eng, // we support 26 languages
                // LinesFiltration = false, // this works slowly, so choose it only if your picture has lines and it they bad detected in TABLE ar DOCUMENT DetectAreasMode   
                // ThreadsCount = 1, // by default our API use all you threads. But you can run it in one thread. Simply set up this here
                // ThresholdValue = 150 // if you want to binarize image with your own threashold value, you can set up this here (from 1 to 255)
            });


            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine($"PAGE {i + 1}  skew {res[i].Skew}");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(res[i].RecognitionText);
                Console.WriteLine("------------------------------------------------------------------------------");

                // you can print here additional information and spell-check the result
                // also you can save each page result in your prefered file format
                // res[i].Save(...);
                // or convert your result to json or xml string
                // res[i].GetJson();
                // res[i].GetXml();
            }

            // you can also save result as one multipage document
            // AsposeOcr.SaveMultipageDocument("result.pdf", SaveFormat.Pdf, res);