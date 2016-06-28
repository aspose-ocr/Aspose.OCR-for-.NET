Imports System.IO
Imports Aspose.OCR

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class PreprocesImagesFromOCROperation
        Public Shared Sub Run()
            ' ExStart:PreprocesImagesFromOCROperation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR() + "Sampleocr.bmp"

            ' Initialize an instance of OcrEngine.
            Dim ocr As New OcrEngine()

            ' Set the Image property by loading the image from file path location.
            ocr.Image = ImageStream.FromFile(dataDir)

            ' Set the SavePreprocessedImages property to false.
            ocr.Config.SavePreprocessedImages = True

            ' Do processing
            If ocr.Process() Then
            End If
            ' ExEnd:PreprocesImagesFromOCROperation
        End Sub
    End Class
End Namespace
