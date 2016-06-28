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
    Public Class SetElementLevelThreshold
        Public Shared Sub Run()
            ' ExStart:SetImageResolution
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load template file
            Dim template As OmrTemplate = OmrTemplate.Load(dataDir & Convert.ToString("questions.amr"))

            ' Load the image to be analyzed
            Dim image As OmrImage = OmrImage.Load(dataDir & Convert.ToString("answers.jpg"))

            ' Get the first page of the template
            Dim page As OmrPage = template.Pages(0)

            ' Create an element by passing the name, location and size
            Dim element As New GridElement("grid1", New PointF(10, 20), New SizeF(60, 30))

            ' Add element to the page
            page.Elements.Add(element)

            ' Create configuration for the element
            element.Configuration = New OmrConfig()

            ' Set the TrimWhitePixels to false
            element.Configuration.TrimWhitePixels = False

            ' Create an instance of OmrEngine and pass object of OmrTemplate as parameter
            Dim engine As New OmrEngine(template)

            ' Extract the data
            Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() {image})
            ' ExEnd:SetImageResolution
        End Sub
    End Class
End Namespace