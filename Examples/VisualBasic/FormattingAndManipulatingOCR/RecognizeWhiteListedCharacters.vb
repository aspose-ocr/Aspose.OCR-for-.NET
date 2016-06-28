Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.OCR

Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class RecognizeWhiteListedCharacters
        Public Shared Sub Run()
            ' ExStart:RecognizeWhiteListedCharacters
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Retrieve the OcrConfig of the OcrEngine object
            Dim ocrConfig As OCRConfig = ocrEngine.Config

            'Set the Whitelist property to recognize numbers only
            ocrConfig.Whitelist = New Char() {"1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "0"c}

            'Set the Image property of OcrEngine object
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Call the Process method to retrieve the results
            ocrEngine.Process()
            ' ExEnd:RecognizeWhiteListedCharacters
        End Sub
    End Class
End Namespace