Imports System.Collections
Imports System.Drawing
Imports System.IO
Imports Aspose.OCR
Imports Aspose.OMR
Imports Aspose.OMR.Elements
Imports Aspose.OMR.ImageProcessing

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOMR
    Public Class SkewedImageSecondMethod
        Public Shared Sub Run()
            ' ExStart:SkewedImageSecondMethod
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load the image to be analyzed
            Dim image As OmrImage = OmrImage.Load(dataDir & Convert.ToString("answers.jpg"))

            Dim engine As New OmrEngine(New OmrTemplate())

            ' Get skew degree of the image
            Dim degree As Double = engine.GetSkewDegree(image)

            ' Rotate image to correct skew
            engine.RotateImage(image, degree)

            ' Save image
            image.AsBitmap().Save(dataDir & Convert.ToString("result_out.jpg"))
            ' ExEnd:SkewedImageSecondMethod
        End Sub
    End Class
End Namespace
