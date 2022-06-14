The source images: test.jpg
The source code:

			// Set the license file or try our product without license
            License lic = new License();
            lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();
			
			// Set:
            // 1) path to the image or MemruStream with the image.
            // 2) set of filters for preprocessing. You can call any number of filters.
            MemoryStream memoryStream = api.PreprocessImage("test.jpg", new PreprocessingFilter { PreprocessingFilter.ContrastCorrectionFilter()});

            // Use Stream for further recognition or simply save it on the disk
            using(FileStream fs = new FileStream("corrected.jpg", FileMode.OpenOrCreate))
			{
				memoryStream.WriteTo(fs);
				memoryStream.Close();       
			}			

