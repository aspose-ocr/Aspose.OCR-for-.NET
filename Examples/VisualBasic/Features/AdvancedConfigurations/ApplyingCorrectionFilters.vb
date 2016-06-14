Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports Aspose.OCR.Filters
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.AdvancedConfigurations
    Public Class ApplyingCorrectionFilters
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
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