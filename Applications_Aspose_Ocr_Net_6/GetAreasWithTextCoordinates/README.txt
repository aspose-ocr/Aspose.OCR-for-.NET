The source image: test.png
The source code:


			// Set the license file or try our product without license
            License lic = new License();
            lic.SetLicense("Aspose.Total.lic");

            // Create AsposeOcr instance.
            // You can use the overloaded constructor to set characters restriction.
            AsposeOcr api = new AsposeOcr();

            // set
            // 1) the full path to the image
            // 2) type of areas to search
            // 3) set this to true for AreasType.LINES if you want to split lines after defining paragraphs     
            List<Rectangle> result = api.GetRectangles("test.png", AreasType.PARAGRAPHS, detectAreas: true);

		// Print the result
            Console.WriteLine("AREAS RECTANGLES COORDINATES:");
            Console.WriteLine("RESULT");

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"X: {result[i].X} Y: {result[i].Y} Width: {result[i].Width} Height: {result[i].Height}");    
            }

