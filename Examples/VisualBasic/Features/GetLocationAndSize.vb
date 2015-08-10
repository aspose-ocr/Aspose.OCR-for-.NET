'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.OCR. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.OCR
Imports System
Imports System.Drawing

Namespace Aspose.OCR.Examples.Features
    Public Class GetLocationAndSize
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Run recognition process
            If ocrEngine.Process() Then
                Console.WriteLine(ocrEngine.Text)
                'Retrieve an array of recognized text by parts
                Dim text() As IRecognizedPartInfo = ocrEngine.Text.PartsInfo
                'Iterate over the text parts
                For Each symbol As IRecognizedTextPartInfo In text
                    'Display the part information
                    Console.WriteLine("Symbol:" & symbol.Text)
                    'Get the rectangle sourronding the symbol
                    Dim box As Rectangle = symbol.Box
                    'Display the rectangle location on the image canvas
                    Console.WriteLine("Box Location:" & box.Location.ToString())
                    'Display the rectangle dimensions
                    Console.WriteLine("Box Size:" & box.Size.ToString())

                Next symbol
            End If

        End Sub
    End Class
End Namespace