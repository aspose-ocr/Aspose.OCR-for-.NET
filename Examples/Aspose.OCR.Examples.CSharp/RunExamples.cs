using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.OCR.Examples.CSharp.PerformingandManagingOCR;

namespace Aspose.OCR.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            //License ocrLicense = new License();
            //ocrLicense.SetLicense("LicenseFilePath");


            Console.WriteLine("Open RunExamples.cs. \nIn Main() method Uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the example that you want to run.

            //// =====================================================
            //// =====================================================
            ////  Performing And Managing OCR
            //// =====================================================
            //// =====================================================

            //CalculateSkewAngle.Run();
            //CalculateSkewAngleFromStream.Run();
            //CalculateSkewAngleFromUri.Run();
            //GetChoiceForRecognizedCharacters.Run();
            //GetRecognitionResult.Run();
            //GetRectanglesLines.Run();
            //GetRectanglesParagraphs.Run();
            //GetResultAsJson.Run();
            //ImageTextFinder.Run();
            //OCRCarPlate.Run();
            //OCRDetectAreasMode.Run();
            //OCRHandwritten.Run();
            //OCROperationWithArchive.Run();
            //OCROperationWithFolder.Run();
            //OCROperationWithList.Run();
            //OCROperationWithLanguageSelection.Run();
            //OCRPassports.Run();
            //OCRStreetPhoto.Run();
            PerformOCROnImage.Run();
            //PerformOCROnImageFromUrl.Run();
            //PrepareRectangles.Run();
            //PreprocessingFiltersForImage.Run();
            //RecognizeImageFromStream.Run();
            //RecognizeImageWithoutTextAreaDetection.Run();
            //RecognizeImageWithTextAreaDetectionAndWithSkewCorrection.Run();
            //RecognizeLine.Run();
            //RecognizePdf.Run();
            //RecognizeTable.Run();
            //ResultCorrectionWithSpellChecking.Run();
            //SaveMultipageResultAsDocument.Run();
            //SaveResultAsDocument.Run();
            //SetThreadsCount.Run();
            //SetThresholdValue.Run();
            //SpecifyAllowedCharacters.Run();
            //SpecifyIgnoredCharacters.Run();
            //WorkingWithDifferentLanguages.Run();
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