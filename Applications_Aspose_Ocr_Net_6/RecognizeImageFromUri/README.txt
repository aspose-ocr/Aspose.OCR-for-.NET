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
            OcrInput input = new OcrInput(InputType.URL/*, filters*/);
            input.Add(uri);

            Console.Write($"TEST URI:  ");
            Console.ResetColor();
            Console.WriteLine($" {input[0].Source}");
            List<RecognitionResult> res = api.Recognize(input, new RecognitionSettings 
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
                // PreprocessingFilters = new PreprocessingFilter // we automaticaly preprocess your image, but if your recognition result still bad, you can set up the set of filters by your own
                // {
                //     PreprocessingFilter.Dilate()
                // },
                // RecognitionAreas = new System.Collections.Generic.List<System.Drawing.Rectangle> // set this if you want to recognize only partiqular regions on the image
                // {
                //     new System.Drawing.Rectangle(0,0,10,20)
                // },
                // RecognizeSingleLine = false, // set this true if your image has only one text line (without other objects)
                // SkewAngle = 5, // use this if your want to switch on out automatically skew correction and set up your own angle
                // ThreadsCount = 1, // by default our API use all you threads. But you can run it in one thread. Simply set up this here
                // ThresholdValue = 150 // if you want to binarize image with your own threashold value, you can set up this here (from 1 to 255
            });
            Console.WriteLine("\nRESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            ConsoleLogRecognitionResult(res[0]);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Recognition is over.");
            Console.ResetColor();

            Console.WriteLine("\nNow you can enter your own link for recognition:");
            string ownUri = Console.ReadLine();
            input.Clear();
            input.Add(ownUri);
            res = api.Recognize(input, new RecognitionSettings());
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");
            ConsoleLogRecognitionResult(res[0]);