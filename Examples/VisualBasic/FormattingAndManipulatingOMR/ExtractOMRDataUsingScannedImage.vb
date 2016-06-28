
Imports System.Collections
Imports System.IO
Imports Aspose.OCR
Imports Aspose.OMR

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOMR
    Public Class ExtractOMRDataUsingScannedImage
        Public Shared Sub Run()
            ' ExStart:ExtractOMRDataUsingScannedImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load template file
            Dim template As OmrTemplate = OmrTemplate.Load(dataDir & Convert.ToString("questions.amr"))

            ' Load the image to be analyzed
            Dim image As OmrImage = OmrImage.Load(dataDir & Convert.ToString("answers.jpg"))

            ' Instantiate the recognition engine for the template
            Dim engine As New OmrEngine(template)

            ' Extract data. This template has only one page.
            Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() {image})

            ' Load actual result from
            Dim OmrResult As Hashtable = result.PageData(0)

            ' Get Collection of Keys
            Dim key As ICollection = OmrResult.Keys

            For Each k As String In key
                Console.WriteLine((k & Convert.ToString(": ")) + OmrResult(k))
            Next
            ' ExEnd:ExtractOMRDataUsingScannedImage
        End Sub
    End Class
End Namespace