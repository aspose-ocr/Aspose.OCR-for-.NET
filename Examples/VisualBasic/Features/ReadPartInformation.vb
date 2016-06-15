Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.Features
    Public Class ReadPartInformationExample
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Run recognition process
            If ocrEngine.Process() Then
                Console.WriteLine(ocrEngine.Text)
                ' Retrieve an array of recognized text by parts
                Dim text() As IRecognizedPartInfo = ocrEngine.Text.PartsInfo
                ' Iterate over the text parts
                For Each symbol As IRecognizedTextPartInfo In text
                    ' Display part intomation
                    Console.WriteLine("Text : " & symbol.Text)
                    Console.WriteLine("isItalic : " & symbol.Italic)
                    Console.WriteLine("isUnderline : " & symbol.Underline)
                    Console.WriteLine("isBold : " & symbol.Bold)
                    Console.WriteLine("FontSize : " & symbol.FontSize)
                    Console.WriteLine("Language : " & symbol.Language)
                Next symbol
            End If

        End Sub
    End Class
End Namespace