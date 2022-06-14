The source images: test1.jpg test2.png test3.png
The source code:

			// Set the license file or try our product without license
            License lic = new License();
            lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();
			
			// You can put in parameters MemoryStream with image or path to the image
            // The result is the degree of skew
            var result = api.CalculateSkew("test1.jpg");
			
			// Print the result
            Console.WriteLine("RESULT");

            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE:");
            Console.WriteLine(result);
