'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
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

Namespace Aspose.OCR.Examples.Features
    Public Class ExtractingText
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Clear notifier list
            ocrEngine.ClearNotifies()

            'Clear recognition blocks
            ocrEngine.Config.ClearRecognitionBlocks()

            'Add 2 rectangles to user defined recognition blocks
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(27, 63, 34, 38)) 'Detecting A
            ocrEngine.Config.AddRecognitionBlock(RecognitionBlock.CreateTextBlock(209, 111, 28, 34)) 'Detecting 6

            'Ignore everything else on the image other than the user defined recognition blocks
            ocrEngine.Config.DetectTextRegions = False

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "sampleocr.bmp")

            'Run recognition process
            If ocrEngine.Process() Then
                Console.WriteLine(ocrEngine.Text)
            End If

        End Sub
    End Class
End Namespace