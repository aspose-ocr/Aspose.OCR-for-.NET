using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOCR;
using Aspose.OCR.Examples.CSharp.PerformingandManagingOCR;

namespace Aspose.OCR.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Aspose.OCR.License ocrLicense = new Aspose.OCR.License();
            ocrLicense.SetLicense("D:\\DotNet Projects\\Aspose\\2019\\Aspose.Total.NET.lic");
            Aspose.Pdf.License pdfLicense = new Aspose.Pdf.License();
            pdfLicense.SetLicense("D:\\DotNet Projects\\Aspose\\2019\\Aspose.Total.NET.lic");


            Console.WriteLine("Open RunExamples.cs. \nIn Main() method Uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the example that you want to run.

            //// =====================================================
            //// =====================================================
            ////  Performing And Managing OCR
            //// =====================================================
            //// =====================================================

            //PerformOCROnImage.Run();
            //GettingWordNotification.Run();
            //ExtractingText.Run();
            //GetLocationAndSizeExample.Run();
            //ReadPartInformation.Run();
            //DetectingTextBlocks.Run();
            //GetTextPartHierarchy.Run();
            //WorkingWithDifferentLanguages.Run();
            //OCROnMultipageTIFF.Run();
            //PreprocesImagesFromOCROperation.Run();
            //ExtractPreprocessedImage.Run();
            //PerformOCROnPDF.Run();

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
            //GettingBlockNotification.Run();

            // Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....");
            Console.ReadKey();
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