'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.OCR. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System
Imports System.IO

Imports Aspose.OCR

Namespace PerformOCROnImage
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Resource file
			Dim resourceFilePath As String = Path.GetFullPath("../../../../../../../Resources/Aspose.OCR.Resources.zip")
			' Source file: the file on which OCR will be performed.
			Dim imageFile As String = dataDir & "Sampleocr.bmp"

			Console.WriteLine("Performing OCR on " & imageFile & "....")

			' Initialize OcrEngine.
			Dim ocr As New OcrEngine()
			' Set the image.
			ocr.Image = ImageStream.FromFile(dataDir & imageFile)
			' Add language.
			ocr.Languages.AddLanguage(Language.Load("english"))
			' Load the resource file.
			ocr.Resource = New FileStream(resourceFilePath, FileMode.Open)
			Using ocr.Resource
				Try
					' Process the whole image
					If ocr.Process() Then
						' Get the complete recognized text found from the image
						Console.WriteLine("Text recognized: " & ocr.Text)
						File.WriteAllText(dataDir & "Output.txt", ocr.Text.ToString())
					End If
				Catch ex As Exception
					Console.WriteLine("Exception: " & ex.ToString())
				End Try
			End Using
		End Sub
	End Class
End Namespace