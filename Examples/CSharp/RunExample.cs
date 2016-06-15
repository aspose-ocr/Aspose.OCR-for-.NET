using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.OCR.Examples.CSharp.Features;
using Aspose.OCR.Examples.CSharp.Features.AdvancedConfiguration;
using Aspose.OCR.Examples.CSharp.OMR;

namespace Aspose.OCR.Examples.CSharp
{
    class RunExample
    {
         static void Main(string[] args)        
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method Uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the example that you want to run.

            //// =====================================================
            //// =====================================================
            //// Feature - AdvanceConfigration 
            //// =====================================================
            //// =====================================================

            //AddingUserDefinedRecognitionBlocks.Run();
            //ApplyingCorrectionFilters.Run();
            //AutomaticallyCorrectTheSpellings.Run();
            //RecognizeWhiteListedCharacters.Run();
            //SettingOcrEngineAutomaticallyDetect.Run();
            //SettingtheOcrEngine.Run();
            //SettingtheOcrEngineAutomaticallyDetectTextBlocks.Run();
            //UserDefinedRecognitionBlocks.Run();

             //// =====================================================
             //// =====================================================
             //// Feature   
             //// =====================================================
             //// =====================================================

             //DetectingTextBlocks.Run();
             //ExtractingText.Run();
             //GetLocationAndSizeExample.Run();
             //GetTextPartHierarchy.Run();
             //GettingNotification.Run();
             //PerformOCROnImage.Run();
             //ReadPartInformation.Run();
             //WorkingWithDifferentLanguages.Run();

             //// =====================================================
             //// =====================================================
             //// OMR   
             //// =====================================================
             //// =====================================================

             //LoadTemplateFromUrl.Run();

             //// =====================================================
             //// =====================================================
             //// Working With OCR   
             //// =====================================================
             //// =====================================================

             //PerformOCROnImage.Run();

            // Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....");
            Console.ReadKey();
        }
        public static string GetDataDir(Type t)
        {
            string c = t.FullName;
            c = c.Replace("Aspose.OCR.Examples.", "");
            c = c.Replace('.', Path.DirectorySeparatorChar);
            string p = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", c));
            p += Path.DirectorySeparatorChar;
            Console.WriteLine("Using Data Dir {0}", p);
            return p;
        }

       
    }
}
