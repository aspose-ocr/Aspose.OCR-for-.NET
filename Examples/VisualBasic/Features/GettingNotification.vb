Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.Features
    Public Class GettingNotification
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            Dim processorWord As INotifier = NotifierFactory.WordNotifier()
            AddHandler processorWord.Elapsed, AddressOf [Delegate]


            ' Add the word processor to the OcrEngine
            ocrEngine.AddNotifier(processorWord)

            'Process the image
            ocrEngine.Process()


        End Sub

        Private Shared Sub [Delegate](sender As Object, recognizedText As IRecognizedText)
            Console.WriteLine("A word was recognized: " & recognizedText.ToString())
        End Sub

    End Class
End Namespace