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

Namespace ReadPartInformationExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Initialize an instance of OcrEngine
			Dim ocrEngine As New OcrEngine()

			'Set Image property by loading an image from file path
			ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

			'Run recognition process
			If ocrEngine.Process() Then
				Console.WriteLine(ocrEngine.Text)
				' Retrieve an array of recognized text by parts
				Dim text() As IRecognizedPartInfo = ocrEngine.Text.PartsInfo
				' Iterate over the text parts
				For Each symbol As IRecognizedTextPartInfo In text
					' Display part intomation
					Console.WriteLine("Text : " & symbol.Text)
					Console.WriteLine("isItalic : " & symbol.Italic)
					Console.WriteLine("isUnderline : " & symbol.Underline)
					Console.WriteLine("isBold : " & symbol.Bold)
					Console.WriteLine("FontSize : " & symbol.FontSize)
					Console.WriteLine("Language : " & symbol.Language)
				Next symbol
			End If

		End Sub
	End Class
End Namespace