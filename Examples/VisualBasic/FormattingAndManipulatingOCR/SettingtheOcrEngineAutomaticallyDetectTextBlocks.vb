Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class SettingtheOcrEngineAutomaticallyDetectTextBlocks
        Public Shared Sub Run()
            ' ExStart:SettingtheOcrEngineAutomaticallyDetectTextBlocks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            'Create an instance of OcrEngine class
            Dim ocr As New OcrEngine()

            'Set the DetectTextRegions to true
            ocr.Config.DetectTextRegions = True

            'Set the Image property of OcrEngine by reading an image file
            ocr.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Perform OCR operation on the image
            If ocr.Process() Then
                'Display results
                Console.WriteLine(ocr.Text)
            End If
        End Sub
        ' ExEnd:SettingtheOcrEngineAutomaticallyDetectTextBlocks
    End Class
End Namespace
