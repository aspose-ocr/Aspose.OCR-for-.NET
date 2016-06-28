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
    Public Class DetectUsingElements
        Public Shared Sub Run()
            ' ExStart:DetectUsingElements
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load template file
            Dim template As OmrTemplate = OmrTemplate.Load(dataDir & Convert.ToString("questions.amr"))

            ' Iterate over the pages in template
            For Each page As OmrPage In template.Pages
                ' Get elements of each page
                Dim collection As OmrElementsCollection = page.Elements
                ' Iterate over the element collection
                For Each obj As [Object] In collection
                    ' Display element name
                    Console.WriteLine(obj.[GetType]().ToString())
                Next
            Next
            ' ExEnd:DetectUsingElements
         End Sub
    End Class
End Namespace