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
    Public Class DynamicallyCreateOMRTemplates
        Public Shared Sub Run()
            ' ExStart:DynamicallyCreateOMRTemplates
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OMR()
            Dim template As New OmrTemplate()
            Dim page As OmrPage = template.Pages(0)
            page.Width = 215.9
            page.Height = 279.4
            Dim choiceBoxPosition As New PointF(20, 5)
            ' 20 mm to the right, 5 mm from the top
            Dim choiceBoxSize As New SizeF(12, 24)
            Dim choiceBox As New ChoiceBoxElement("AnotherElement", choiceBoxPosition, choiceBoxSize)
            choiceBox.IsHorizontal = False
            choiceBox.Cells.Add(New OmrCell("A"))
            ' Three marks: (A) (B) (C)
            choiceBox.Cells.Add(New OmrCell("B"))
            choiceBox.Cells.Add(New OmrCell("C"))
            page.Elements.Add(choiceBox)
            template.Save(dataDir & Convert.ToString("New_template_out.amr"))
            ' ExEnd:DynamicallyCreateOMRTemplates
        End Sub
    End Class
End Namespace