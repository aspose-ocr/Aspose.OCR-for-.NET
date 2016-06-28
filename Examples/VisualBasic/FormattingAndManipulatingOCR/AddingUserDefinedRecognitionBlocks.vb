Imports System.IO
Imports Aspose.OCR

Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOCR
    Public Class AddingUserDefinedRecognitionBlocks
        Public Shared Sub Run()
            ' ExStart:AddingUserDefinedRecognitionBlocks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OMR()

            ' Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            ' Clear notifier list
            ocrEngine.ClearNotifies()

            ' Clear recognition blocks
            ocrEngine.Config.ClearRecognitionBlocks()

            ' Add 3 rectangle blocks to user defined recognition blocks
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 10, 20, 40))
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 4, 5, 6))
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(0, 5, 5, 6))

            ' Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = False

            ' Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & Convert.ToString("sample1.jpg"))

            ' Run recognition process
            If ocrEngine.Process() Then
                ' Retrieve user defined blocks that determines the paye layout
                Dim blocks = ocrEngine.Config.RecognitionBlocks
                ' Loop over the list of blocks
                For Each block In blocks
                    ' Display if block is set to be recognized
                    Console.WriteLine(block.ToRecognize)
                    ' Check if block has recognition data
                    If block.RecognitionData Is Nothing Then
                        Console.WriteLine("Null{0}", Environment.NewLine)
                        Continue For
                    End If
                    ' Display dimension & size of rectangle that defines the recognition block
                    Console.WriteLine("Block: {0}", block.Rectangle)
                    If TypeOf block.RecognitionData Is IRecognizedTextPartInfo Then
                        ' Display the recognition results
                        Dim textPartInfo As IRecognizedTextPartInfo = DirectCast(block.RecognitionData, IRecognizedTextPartInfo)
                        Console.WriteLine("Text: {0}{1}", textPartInfo.Text, Environment.NewLine)
                    End If
                Next
            End If
            ' ExEnd:AddingUserDefinedRecognitionBlocks
        End Sub
    End Class
End Namespace