Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO
Imports Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
Imports Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOMR
Imports Aspose.OCR.Examples.VisualBasic.PerformingandManagingOCR

Namespace Aspose.OCR.Examples.VisualBasic
    Class RunExamples
        Public Shared Sub Main(args As String())
            Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method Uncomment the example that you want to run.")
            Console.WriteLine("=====================================================")

            ' Uncomment the example that you want to run.

            ' =====================================================
            ' =====================================================
            '  Performing And Managing OCR
            ' =====================================================
            ' =====================================================

            'PerformOCROnImage.Run()
            'GettingNotification.Run()
            'ExtractingText.Run()
            'GetLocationAndSizeExample.Run()
            'ReadPartInformation.Run()
            'DetectingTextBlocks.Run()
            'GetTextPartHierarchy.Run()
            'LoadTemplateFromUrl.Run()
            'WorkingWithDifferentLanguages.Run()
            'OCROnMultipageTIFF.Run()
            'PreprocesImagesFromOCROperation.Run()
            'SupplyMultipleWhiteLists.Run()

            ' =====================================================
            ' =====================================================
            ' Formatting And Manipulating OCR   
            ' =====================================================
            ' =====================================================

            'AddingUserDefinedRecognitionBlocks.Run()
            'ApplyingCorrectionFilters.Run()
            'AutomaticallyCorrectTheSpellings.Run()
            'PreprocesImagesFromOCROperation.Run()
            'RecognizeWhiteListedCharacters.Run()
            'SettingOcrEngineAutomaticallyDetect.Run()
            'SettingtheOcrEngine.Run()
            'SettingtheOcrEngineAutomaticallyDetectTextBlocks.Run()
            'UserDefinedRecognitionBlocks.Run()
            'ExtractPreprocessedImages.Run()
            'UsingNotifierFactory.Run()

            ' =====================================================
            ' =====================================================
            ' Formatting And Manipulating OMR   
            ' =====================================================
            ' =====================================================

            'DetectImageResolutionAutomatically.Run()
            'DetectUsingElements.Run()
            'ExtractOMRDataUsingScannedImage.Run()
            'ExtractText.Run()
            'PerformOCROnImage.Run()
            'SetElementLevelThreshold.Run()
            'SetImageResolution.Run()
            'SetPageLevelThreshold.Run()
            'SettingMarkThreshold.Run()
            'SkewImageCorrectionUsingAlgorithm.Run()
            'SkewedImageSecondMethod.Run()
            'DynamicallyCreateOMRTemplates.Run()
            'AdjustImageProcessPipeline.Run()

            ' Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....")
            Console.ReadKey()
        End Sub


        Public Shared Function GetDataDir_OMR() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("OMR/"))
        End Function

        Public Shared Function GetDataDir_OCR() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("OCR/"))
        End Function

        Private Shared Function GetDataDir_Data() As String
            Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
            Dim startDirectory As String = Nothing
            If parent IsNot Nothing Then
                Dim directoryInfo = parent.Parent
                If directoryInfo IsNot Nothing Then
                    startDirectory = directoryInfo.FullName
                End If
            Else
                startDirectory = parent.FullName
            End If
            Return If(startDirectory IsNot Nothing, Path.Combine(startDirectory, "Data\"), Nothing)
        End Function

    End Class
End Namespace
