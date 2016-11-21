Imports Aspose.OMR.ImageProcessing

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class ExtractPreprocessedImages
        Public Shared Sub Run()
            ' ExStart:ExtractPreprocessedImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            ' Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir & Convert.ToString("sample1.jpg"))
            ocrEngine.Config.SavePreprocessedImages = True

            ' Process the image
            If ocrEngine.Process() Then
                ' Save binarized,filtered image on disc
                ocrEngine.PreprocessedImages.BinarizedImage.Save(dataDir & Convert.ToString("BinarizedImage_out.png"), System.Drawing.Imaging.ImageFormat.Png)
                ocrEngine.PreprocessedImages.FilteredImage.Save(dataDir & Convert.ToString("FilteredImage_out.png"), System.Drawing.Imaging.ImageFormat.Png)

                ' Save image after removing non-textual fragments,  skew correction and textual block detection
                ocrEngine.PreprocessedImages.NonTextRemovedImage.Save(dataDir & Convert.ToString("NonTextRemovedImage_out.png"), System.Drawing.Imaging.ImageFormat.Png)
                ocrEngine.PreprocessedImages.RotatedImage.Save(dataDir & Convert.ToString("RotatedImage_out.png"), System.Drawing.Imaging.ImageFormat.Png)
                ocrEngine.PreprocessedImages.TextBlocksImage.Save(dataDir & Convert.ToString("TextBlocksImage_out.png"), System.Drawing.Imaging.ImageFormat.Png)
            End If
            ' ExEnd:ExtractPreprocessedImages
        End Sub
    End Class
End Namespace
