Imports System.Collections
Imports System.Drawing
Imports System.IO
Imports Aspose.OCR
Imports Aspose.OMR
Imports Aspose.OMR.Elements

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOMR
    Public Class ExtractText
        Public Shared Sub Run()
            ' ExStart:ExtractText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load template file
            Dim template As OmrTemplate = OmrTemplate.Load(dataDir & Convert.ToString("questions.amr"))

            ' Load the image to be analyzed
            Dim image As OmrImage = OmrImage.Load(dataDir & Convert.ToString("answers.jpg"))

            ' Set resource for TextOcrElement
            TextOcrElement.Resource = dataDir & Convert.ToString("Aspose.OCR.Spanish.Resources.zip")
            ' Create an instance of TextOcrElement and initialize it by specifying the location of text and its size in mm
            Dim textElement As New TextOcrElement("OCR Text", New PointF(23.6F, 15.5F), New SizeF(14.6F, 4.7F))
            ' Add the TextOcrElement to the page element collection
            template.Pages(0).Elements.Add(textElement)

            ' Create an instance of OmrEngine and load the template using file path
            Dim engine As New OmrEngine(template)
            ' Extract OMR data and store the results in an instance of OmrProcessingResults
            Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() {image})
            ' Get all page data into an instance of Hashtable
            Dim pages As Hashtable() = result.PageData
            ' Loop over all the pages
            For Each page As Hashtable In pages
                ' Display key and value
                For Each key As String In page.Keys
                    Console.WriteLine((Convert.ToString("key: ") & key) + ": " + "value: " + page(key))
                Next
            Next
            ' ExEnd:ExtractText
        End Sub
    End Class
End Namespace
