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
			string correctedResult = result.GetSpellCheckCorrectedText(SpellCheckLanguage.En);
			Console.WriteLine(correctedResult);

			//Get list of misspelled words with suggestions
			List<SpellCheckError> errorsList = result.GetSpellCheckErrorList(SpellCheckLanguage.En);
			foreach (var word in errorsList)
			{
				Console.Write(word.Word);
				Console.Write(word.StartPosition);
				Console.Write(word.Length);

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