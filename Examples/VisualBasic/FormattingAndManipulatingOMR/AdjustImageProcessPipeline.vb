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
    Public Class AdjustImageProcessPipeline
        Public Shared Sub Run()
            ' ExStart:DetectUsingElements
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Load template file and Instantiate the recognition engine for the template
            Dim template As OmrTemplate = OmrTemplate.Load(dataDir & Convert.ToString("questions.amr"))
            Dim engine As New OmrEngine(template)

            ' First, remove all default steps
            engine.ProcessingPipeline.Clear()

            ' Now add the grayscale convertor  It may not be necessary to add it if the scans are already in grayscale and              Adding the Otsu’s binarization algorithm 
            engine.ProcessingPipeline.Add(New GrayscaleAlgorithm())
            engine.ProcessingPipeline.Add(New OtsuBinarizationAlgorithm())
            ' ExEnd:DetectUsingElements
        End Sub
    End Class
End Namespace