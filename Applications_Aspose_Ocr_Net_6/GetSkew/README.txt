The source images: test1.jpg test2.png test3.png
The source code:

		  // Set the license file
            //License lic = new License();
            //lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();

            // Create OcrInput object to containerize images
            OcrInput input = new OcrInput(InputType.SingleImage);
            input.Add(fileName);

            // You can put in parameters MemoryStream with image
            // The result is the degree of skew
            List<SkewOutput> result = api.CalculateSkew(input);
            Console.WriteLine("RESULT");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("SKEW IMAGE 1:");
            Console.WriteLine(result[0].Angle);

            input.Clear();
            input.Add("images/test2.png");
            result = api.CalculateSkew(input);
            Console.WriteLine("\nSKEW IMAGE 2:");
            Console.WriteLine(result[0].Angle);

            input.Clear();
            input.Add("images/test3.png");
            result = api.CalculateSkew(input);
            Console.WriteLine("\nSKEW IMAGE 3:");
            Console.WriteLine(result[0].Angle);
