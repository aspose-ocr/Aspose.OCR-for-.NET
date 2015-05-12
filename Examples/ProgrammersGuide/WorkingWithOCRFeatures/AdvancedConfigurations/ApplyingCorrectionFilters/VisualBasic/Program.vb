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
Imports Aspose.OCR.Filters
Imports System

Namespace ApplyingCorrectionFiltersExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Initialize an instance of OcrEngine
			Dim ocrEngine As OcrEngine = New OcrEngine()

			'Set Image property by loading an image from file path
			ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

			'Create CorrectionFilters collection
			Dim filters As CorrectionFilters = New CorrectionFilters()
			Dim filter As Filter = Nothing

			'Initialize Median filter
			filter = New MedianFilter(5)
			filters.Add(filter)

			'Create Gaussian Blur filter
			filter = New GaussBlurFilter()
			filters.Add(filter)

			'Create Noise Removal filter
			filter = New RemoveNoiseFilter()
			filters.Add(filter)

			'Assign collection to OcrEngine
			ocrEngine.Config.CorrectionFilters = filters

			'Run recognition process
			If ocrEngine.Process() Then
				'Display results
				Console.WriteLine(ocrEngine.Text)
			End If

		End Sub
	End Class
End Namespace