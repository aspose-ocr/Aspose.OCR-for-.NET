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

Namespace Aspose.OCR.Examples.Features.AdvancedConfigurations
    Public Class RecognizeWhiteListedCharacters
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.OCR.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Retrieve the OcrConfig of the OcrEngine object
            Dim ocrConfig As OCRConfig = ocrEngine.Config

            'Set the Whitelist property to recognize numbers only
            ocrConfig.Whitelist = New Char() {"1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "0"c}

            'Set the Image property of OcrEngine object
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Call the Process method to retrieve the results
            ocrEngine.Process()
        End Sub
    End Class
End Namespace