Imports Aspose.OMR
Imports Aspose.OMR.Elements

Namespace Aspose.OCR.Examples.VisualBasic.FormattingAndManipulatingOMR

    Public Class MeteredLicensingOMR

        Public Shared Sub Run()

            ' ExStart:ExtractText

            ' Create an instance of Metered class
            Dim matered As New Metered()

            ' Set public & private keys
            matered.SetMeteredKey("publicKeyValue", "privateKeyValue")

            ' Get consumed quantity before calling any API method
            Dim amountBefore As Decimal = Metered.GetConsumptionQuantity()

            ' Display value
            Console.WriteLine(amountBefore.ToString())

            ' DO PROCDESSING
            ' The path to the documents directory
            'string dataDir = RunExamples.GetDataDir_OCR();

            ' Create an instance of OmrEngine and load the template using file path
            'OmrEngine omr = new OmrEngine(new OmrTemplate());

            'string path = dataDir + "sampleimage.png";
            'OmrImage omrImage = OmrImage.Load(path);

            ''Since upload data is running on another thread, so we need wait some time
            'Thread.Sleep(10000);

            ' Get consumed quantity after calling any API method
            Dim amountAfter As Decimal = Metered.GetConsumptionQuantity()

            ' Display value
            Console.WriteLine(amountAfter.ToString())

            ' ExEnd:ExtractText


        End Sub

    End Class

End Namespace
