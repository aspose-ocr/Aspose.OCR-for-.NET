Imports System

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class UsingNotifierFactory
        Public Shared Sub Run()
            ' ExStart:UsingNotifierFactory
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            ' Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            ' Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir & Convert.ToString("answers.jpg"))

            ' Get an instance of WordNotifier, Write a delegate to handle the Elapsed event and Display the recognized text on screen

            Dim processorWord As INotifier = NotifierFactory.WordNotifier()
            AddHandler processorWord.Elapsed, AddressOf [Delegate]

            ' Add the word processor to the OcrEngine and Process the image
            ocrEngine.AddNotifier(processorWord)
            ocrEngine.Process()
            ' ExEnd:UsingNotifierFactory            
        End Sub

        Private Shared Sub [Delegate](sender As Object, recognizedText As IRecognizedText)
            Console.WriteLine("A word was recognized: " & recognizedText.ToString())
        End Sub

    End Class
End Namespace
