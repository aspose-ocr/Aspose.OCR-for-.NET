Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.PerformingandManagingOCR
    Public Class WorkingWithDifferentLanguages
        Public Shared Sub Run()
            ' ExStart:WorkingWithDifferentLanguages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set the Image property by loading the image from file path location or an instance of Stream
            ocrEngine.Image = ImageStream.FromFile(dataDir & "SpanishOCR.bmp")

            'Clear the default language (English)
            ocrEngine.LanguageContainer.Clear()

            'Load the resources of the language from file path location or an instance of Stream
            ocrEngine.LanguageContainer.AddLanguage(LanguageFactory.Load(dataDir & "Aspose.OCR.Spanish.Resources.zip"))

            'Process the image
            If ocrEngine.Process() Then
                'Display the recognized text
                Console.WriteLine(ocrEngine.Text)
            End If
            ' ExEnd:WorkingWithDifferentLanguages
        End Sub
    End Class
End Namespace