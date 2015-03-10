'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.OCR. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Collections.Generic
Imports Aspose.OCR
Imports System

Namespace ExtractingTextExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
            Dim dataDir As String = Path.GetFullPath("../../../Data/")

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Clear notifier list
            ocrEngine.ClearNotifies()

            'Clear recognition blocks
            ocrEngine.Config.ClearRecognitionBlocks()

            'Add 2 rectangles to user defined recognition blocks
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(35, 21, 22, 26))
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(340, 63, 29, 37))

            'Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = False

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "sampleocr.bmp")

            'Run recognition process
            If ocrEngine.Process() Then
                'Retrieve user defined blocks that determines the page layout
                Dim blocks As IList(Of IRecognitionBlock) = ocrEngine.Config.RecognitionBlocks
                'Loop over the list of blocks
                For Each block As IRecognitionBlock In blocks
                    'Display if block is set to be recognized
                    Console.WriteLine(block.ToRecognize)
                    'Check if block has recognition data
                    If block.RecognitionData Is Nothing Then
                        Console.WriteLine("Null{0}", Environment.NewLine)
                        Continue For
                    End If
                    'Display dimension & size of rectangle that defines the recognition block
                    Console.WriteLine("Block: {0}", block.Rectangle)
                    If TypeOf block.RecognitionData Is IRecognizedTextPartInfo Then
                        'Display the recognition results
                        Dim textPartInfo As IRecognizedTextPartInfo = CType(block.RecognitionData, IRecognizedTextPartInfo)
                        Console.WriteLine("Text: {0}{1}", textPartInfo.Text, Environment.NewLine)
                    End If
                Next block
            End If

		End Sub
	End Class
End Namespace