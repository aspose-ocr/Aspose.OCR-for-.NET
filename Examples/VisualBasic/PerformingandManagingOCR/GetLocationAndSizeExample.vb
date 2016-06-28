Imports System.IO
Imports Aspose.OCR
Imports System.Drawing

Namespace Aspose.OCR.Examples.VisualBasic.PerformingandManagingOCR
    Public Class GetLocationAndSizeExample
        Public Shared Sub Run()
            ' ExStart:GetLocationAndSizeExample
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OMR()

            ' Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            ' Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & Convert.ToString("Sampleocr.bmp"))

            ' Run recognition process
            If ocrEngine.Process Then
                Console.WriteLine(ocrEngine.Text)
                ' Retrieve an array of recognized text by parts
                Dim text() As IRecognizedPartInfo = ocrEngine.Text.PartsInfo
                ' Iterate over the text parts
                For Each recognizedPartInfo In text
                    Dim symbol = CType(recognizedPartInfo, IRecognizedTextPartInfo)
                    ' Display the part information
                    Console.WriteLine(("Symbol:" + symbol.Text))
                    ' Get the rectangle sourronding the symbol
                    Dim box As Rectangle = symbol.Box
                    ' Display the rectangle location on the image canvas
                    Console.WriteLine("Box Location:")
                    Console.Write(box.Location)
                    ' Display the rectangle dimensions
                    Console.WriteLine("Box Size:")
                    Console.Write(box.Size)
                Next
            End If
            ' ExEnd:GetLocationAndSizeExample
        End Sub
    End Class
End Namespace