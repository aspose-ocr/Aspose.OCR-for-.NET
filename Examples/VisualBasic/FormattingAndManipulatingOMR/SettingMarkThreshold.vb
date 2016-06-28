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
    Public Class SettingMarkThreshold
        Public Shared Sub Run()
            ' ExStart:SettingMarkThreshold
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load template file
            Dim template As OmrTemplate = OmrTemplate.Load(dataDir & Convert.ToString("questions.amr"))

            ' Load the image to be analyzed
            Dim image As OmrImage = OmrImage.Load(dataDir & Convert.ToString("answers.jpg"))

            ' Create an instance of OmrEngine and pass object of OmrTemplate as parameter
            Dim engine As New OmrEngine(template)

            ' Get the configurations of OmrEngine
            Dim config As OmrConfig = engine.Configuration

            ' Set fill threshold
            config.FillThreshold = 0.12

            ' Extract the data
            Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() {image})
            ' ExEnd:SettingMarkThreshold
        End Sub
    End Class
End Namespace