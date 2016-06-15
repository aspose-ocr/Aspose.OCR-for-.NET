Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO
Imports Aspose.OCR.Examples.VisualBasic.AdvancedConfigurations
Imports Aspose.OCR.Examples.VisualBasic.Features

Namespace Aspose.OCR.Examples.VisualBasic
    Class RunExamples
        Public Shared Sub Main()
            Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method uncomment the example that you want to run.")
            Console.WriteLine("=====================================================")

            ' Uncomment the example that you want to run.

            ' =====================================================
            ' =====================================================
            ' Feature - AdvanceConfigration 
            ' =====================================================
            ' =====================================================

            'AddingUserDefinedRecognitionBlocks.Run()
            'ApplyingCorrectionFilters.Run()
            'AutomaticallyCorrectTheSpellings.Run()
            'RecognizeWhiteListedCharacters.Run()
            'SettingOcrEngineAutomaticallyDetect.Run()
            'SettingtheOcrEngine.Run()
            'AutomaticallyDetectTextBlocks.Run()
            'AddingUserDefinedRecognitionBlocks.Run()

            ' =====================================================
            ' =====================================================
            ' Feature   
            ' =====================================================
            ' =====================================================

            'DetectingTextBlocks.Run()
            'ExtractingText.Run()
            'GetLocationAndSize.Run()
            'GetTextPartHierarchy.Run()
            'GettingNotification.Run()
            'PerformOCROnImage.Run()
            'ReadPartInformationExample.Run()
            'WorkingWithDifferentLanguagesExample.Run()

            ' =====================================================
            ' =====================================================
            ' Working With OCR   
            ' =====================================================
            ' =====================================================

            'PerformOCROnImage.Run()

            ' Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....")
            Console.ReadKey()
        End Sub
        Public Shared Function GetDataDir(t As Type) As String
            Dim c As String = t.FullName
            c = c.Replace("Aspose.OCR.Examples.", "")
            c = c.Replace("."c, Path.DirectorySeparatorChar)
            Dim p As String = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", c))
            p += Path.DirectorySeparatorChar
            Console.WriteLine("Using Data Dir {0}", p)
            Return p
        End Function

    End Class
End Namespace