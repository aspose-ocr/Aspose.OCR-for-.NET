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

Namespace GettingNotificationExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
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