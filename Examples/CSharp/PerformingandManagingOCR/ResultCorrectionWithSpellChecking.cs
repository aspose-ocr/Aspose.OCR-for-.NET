using System;
using Aspose.OCR.SpellChecker;
using System.Collections.Generic;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class ResultCorrectionWithSpellChecking
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

			// Initialize an instance of AsposeOcr
			AsposeOcr api = new AsposeOcr();

			// Recognize image           
			RecognitionResult result = api.RecognizeImage(dataDir + "sample.png", new RecognitionSettings());

			// Get result
			Console.WriteLine(result.RecognitionText);

			// Get corrected result
			string correctedResult = result.GetSpellCheckCorrectedText(SpellCheckLanguage.Eng);
			Console.WriteLine(correctedResult);

			//Get list of misspelled words with suggestions
			List<SpellCheckError> errorsList = result.GetSpellCheckErrorList(SpellCheckLanguage.Eng);
			foreach (var word in errorsList)
			{
				Console.Write("Word:" + word.Word);
				Console.Write(" StartPosition:" + word.StartPosition);
				Console.WriteLine(" Length:" + word.Length);
				Console.WriteLine("SuggestedWords:");
				foreach (var suggest in word.SuggestedWords)
				{
					Console.Write(suggest.Word + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine(api.CorrectSpelling("recogniition"));
			// ExEnd:1

			Console.WriteLine("WorkingWithDifferentLanguages executed successfully");
        }
    }
}