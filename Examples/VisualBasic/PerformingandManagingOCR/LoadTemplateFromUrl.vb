Imports System.IO
Imports System.Collections
Imports Aspose.OMR

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.OCR.Examples.VisualBasic.PerformingandManagingOCR

    Public Class LoadTemplateFromUrl

        Public Shared Sub Run()
            ' ExStart:LoadTemplateFromUrl
            Dim templateUrl As String = "https://Github.com/asposeocr/Aspose_OCR_NET/raw/master/Examples/Data/OCR/questions.amr"
            Dim imageUrl As String = "https://Github.com/asposeocr/Aspose_OCR_NET/raw/master/Examples/Data/OCR/answers.jpg"
            ' Initialize an instance of OmrTemplate by loading the OMR template from URL
            Dim template As OmrTemplate = OmrTemplate.LoadFromUrl(templateUrl)
            ' image loading from url
            Dim image As OmrImage = OmrImage.LoadFromUrl(imageUrl)
            ' continue working with template and image as usual
            Dim engine As OmrEngine = New OmrEngine(template)
            Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() {image})
            ' Get all page data into an instance of Hashtable
            Dim pages() As Hashtable = result.PageData
            ' Loop over all the pages
            For Each page As Hashtable In pages
                ' Display key and value
                For Each key As String In page.Keys
                    Console.WriteLine(("[KEY] " _
                                    + (key + (" => " + ("[VALUE] " + page(key))))))
                Next
            Next
            ' ExEnd:LoadTemplateFromUrl
        End Sub
    End Class
End Namespace

