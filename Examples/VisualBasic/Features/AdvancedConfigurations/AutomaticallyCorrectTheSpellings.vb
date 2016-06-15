Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.AdvancedConfigurations
    Public Class AutomaticallyCorrectTheSpellings
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Create an instance of OcrEngine class
            Dim ocr As New OcrEngine()

            'Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir & "sampleocr_spell.bmp")

            'Set the DoSpellingCorrection to true
            ocr.Config.DoSpellingCorrection = True

            'Perform OCR operation
            If ocr.Process() Then
                'Display results
                Console.WriteLine(ocr.Text)
            End If

        End Sub
    End Class
End Namespace