'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.OCR. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.OCR
Imports System

Namespace DetectingTextBlocksExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Initialize an instance of OcrEngine
			Dim ocrEngine As New OcrEngine()

			'Set Image property by loading an image from file path
			ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

			'Remove non-textual blocks
			ocrEngine.Config.RemoveNonText = True

			'Run recognition process
			If ocrEngine.Process() Then
				'Display text block locations
				Console.WriteLine(ocrEngine.Text.PartsInfo(0).Box)
				Console.WriteLine(ocrEngine.Text.PartsInfo(1).Box)
			End If
		End Sub
	End Class
End Namespace