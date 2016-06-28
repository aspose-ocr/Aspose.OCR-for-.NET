using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR;
using Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOMR;
using Aspose.OCR.Examples.CSharp.PerformingandManagingOCR;

namespace Aspose.OCR.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method Uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the example that you want to run.

            //// =====================================================
            //// =====================================================
            ////  Performing And Managing OCR
            //// =====================================================
            //// =====================================================

            //PerformOCROnImage.Run();
            //GettingNotification.Run();
            //ExtractingText.Run();
            //GetLocationAndSizeExample.Run();
            //ReadPartInformation.Run();
            //DetectingTextBlocks.Run();
            //GetTextPartHierarchy.Run();
            //WorkingWithDifferentLanguages.Run();
            //LoadTemplateFromUrl.Run();
            //OCROnMultipageTIFF.Run();
            //PreprocesImagesFromOCROperation.Run();
          
            //// =====================================================
            //// =====================================================
            //// Formatting And Manipulating OCR   
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
            //// Formatting And Manipulating OMR   
            //// =====================================================
            //// =====================================================

            //DetectImageResolutionAutomatically.Run();
            //DetectUsingElements.Run();
            //ExtractOMRDataUsingScannedImage.Run();
            //ExtractText.Run();
            //PerformOCROnImage.Run();
            //SetElementLevelThreshold.Run();
            //SetImageResolution.Run();
            //SetPageLevelThreshold.Run();
            //SettingMarkThreshold.Run();
            //SkewImageCorrectionUsingAlgorithm.Run();
            //SkewedImageSecondMethod.Run();
           
            // Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....");
            Console.ReadKey();
        }


        public static String GetDataDir_OMR()
        {
            return Path.GetFullPath(GetDataDir_Data() + "OMR/");
        }

        public static String GetDataDir_OCR()
        {
            return Path.GetFullPath(GetDataDir_Data() + "OCR/");
        }

        private static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return startDirectory != null ? Path.Combine(startDirectory, "Data\\") : null;
        }

    }
}