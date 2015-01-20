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

Namespace SettingtheOcrEngineAutomaticallyDetectTextBlocksExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create an instance of OcrEngine class
			Dim ocr As New OcrEngine()

			'Set the DetectTextRegions to true
			ocr.Config.DetectTextRegions = True

			'Set the Image property of OcrEngine by reading an image file
			ocr.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

			'Perform OCR operation on the image
			If ocr.Process() Then
				'Display results
			  Console.WriteLine(ocr.Text)
			End If
		End Sub
	End Class
End Namespace
