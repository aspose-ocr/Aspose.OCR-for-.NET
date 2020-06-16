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

            //PerformOCROnImage.Run();
            //RecognizeLine.Run();
            //WorkingWithDifferentLanguages.Run();
            //RecognizeImageFromStream.Run();
            //RecognizeImageWithoutTextAreaDetection.Run();
            //RecognizeImageWithTextAreaDetectionAndWithoutSkewCorrection.Run();
            //PrepareRectangles.Run();
            //RecognizeTextFromSpecificRectangle.Run();
            //SpecifyAllowedCharacters.Run();
            //CalculateSkewAngle.Run();
            //CalculateSkewAngleFromStream.Run();

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