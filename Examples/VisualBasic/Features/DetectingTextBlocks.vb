Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.Features
    Public Class DetectingTextBlocks
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Remove non-textual blocks
            ocrEngine.Config.RemoveNonText = True

            'Run recognition process
            If ocrEngine.Process() Then
                'Display text block locations
                For Each part As IRecognizedPartInfo In ocrEngine.Text.PartsInfo
                    Console.WriteLine(part.Box)
                Next part
            End If
        End Sub
    End Class
End Namespace