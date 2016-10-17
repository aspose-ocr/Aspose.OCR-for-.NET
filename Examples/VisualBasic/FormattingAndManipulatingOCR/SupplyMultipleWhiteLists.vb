Imports System.Collections
Imports Aspose.OMR

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class SupplyMultipleWhiteLists
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Create an initialize an instance of OcrEngine
            Dim engine As New OcrEngine()

            ' Set the OcrEngine.Image property by loading an image from disk, memory or URL
            engine.Image = ImageStream.FromFile(dataDir & Convert.ToString("Sample.bmp"))

            ' Create text recognition block by supplying X,Y coordinates and Width,Height values
            Dim block As IRecognitionBlock = RecognitionBlock.CreateTextBlock(6, 9, 120, 129)

            ' Set the Whitelist property by specifying a new block whitelist
            block.Whitelist = New Char() {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}

            ' YOU CAN ADD MORE TEXT BLOCK AND SET WHITE LISTS.

            ' Set different configurations and add recognition block(s)
            engine.Config.ClearRecognitionBlocks()
            engine.Config.AddRecognitionBlock(block)
            engine.Config.DetectTextRegions = False

            ' Call OcrEngine.Process method to perform OCR operation
            If engine.Process() Then
                ' Display the recognized text from each Page
                Console.WriteLine(engine.Text)
            End If
        End Sub
    End Class
End Namespace