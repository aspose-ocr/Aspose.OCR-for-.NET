Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.Features
    Public Class GetTextPartHierarchy
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Process the image
            If ocrEngine.Process() Then
                'Retrieve the first block of the recognized text part
                Dim firstBlock As IRecognizedTextPartInfo = (TryCast(ocrEngine.Text.PartsInfo(0), IRecognizedTextPartInfo))

                'Get the children of the first block that will the the lines in the block
                Dim linesOfFirstBlock() As IRecognizedPartInfo = firstBlock.Children

                'Retrieve the fist line from the collection of lines
                Dim firstLine As IRecognizedTextPartInfo = (TryCast(linesOfFirstBlock(0), IRecognizedTextPartInfo))

                'Display the level of line
                Console.WriteLine(firstLine.Level.ToString())

                'Retrieve the fist word from the collection of words
                Dim firstWord As IRecognizedTextPartInfo = (TryCast(firstLine.Children(0), IRecognizedTextPartInfo))

                'Display the level of word
                Console.WriteLine(firstWord.Level.ToString())

                'Retrieve the fist character from the collection of characters
                Dim firstCharacter As IRecognizedTextPartInfo = (TryCast(firstWord.Children(0), IRecognizedTextPartInfo))

                'Display the level of character
                Console.WriteLine(firstCharacter.Level.ToString())
            End If


        End Sub
    End Class
End Namespace