The source images: test.jpg
The source code:

            string fileName = args.Length > 0 ? args[0] : "images/test.jpg";
            PrintStart(fileName);
            // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create OcrInput object to containerize images
            // Set:
            // 1) path to the image or MemruStream with the image.
            // 2) set of filters for preprocessing. You can call any number of filters.
            OcrInput input = new OcrInput(InputType.SingleImage, new PreprocessingFilter { PreprocessingFilter.ContrastCorrectionFilter() });
            input.Add(fileName);


            OcrInput result = ImageProcessing.Render(input);
            MemoryStream memoryStream = result[0].Stream;

            // Use Stream for further recognition or simply save it on the disk
            FileStream fs = new FileStream("out/corrected.jpg", FileMode.OpenOrCreate);
            memoryStream.WriteTo(fs);
            fs.Close();
            memoryStream.Close();
            result.Clear();   