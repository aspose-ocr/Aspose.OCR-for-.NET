---
title: Public API Changes in Aspose.OCR 2.0.0
type: docs
weight: 10
url: /net/public-api-changes-in-aspose-ocr-2-0-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 1.9.0 to 2.0.0, that may be of interest to module and application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
### **Added Properties**
#### **Added the DetectReadingOrder Property**
The OcrConfig class has exposed the DetectReadingOrder property which can be used to get or set a value that indicates whether special reading order detection operation be applied to text blocks. The default value is true, and in case the OCR process consumes too much time or does not respond, try to set this property to false.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Image = ImageStream.FromFile(@"image.tiff");

ocr.Languages.AddLanguage(Language.Load("english"));

ocr.Config.DetectReadingOrder = false;

using (ocr.Resource = new FileStream(resourceFileName, FileMode.Open))

{

    if (ocr.Process())

    {

        Console.WriteLine(ocr.Text);

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("image.tiff")

ocr.Languages.AddLanguage(Language.Load("english"))

ocr.Config.DetectReadingOrder = False

ocr.Resource = New FileStream(resourceFileName, FileMode.Open)

Using ocr.Resource

	If ocr.Process() Then

		Console.WriteLine(ocr.Text)

	End If

End Using

{{< /highlight >}}
#### **Added the DetectTextRegions Property**
The DetectTextRegions property has been added to the OcrConfig class. It specifies whether automatic text region detection will be used. If this property is set to true, manually set recognition blocks are ignored.

**C#**

{{< highlight csharp >}}

 OcrEngine engine = new OcrEngine();

engine.Languages.AddLanguage(Language.Load("english"));

engine.Config.DetectTextRegions = false;

engine.Image = ImageStream.FromFile(pictureFileName);

using (engine.Resource = new FileStream(resourceFileName, FileMode.Open))

{

    if (engine.Process())

    {

        //work with text

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim engine As New OcrEngine()

engine.Languages.AddLanguage(Language.Load("english"))

engine.Config.DetectTextRegions = False

engine.Image = ImageStream.FromFile(pictureFileName)

engine.Resource = New FileStream(resourceFileName, FileMode.Open)

Using engine.Resource

	If engine.Process() Then

		'work with text

	End If

End Using

{{< /highlight >}}

The above example demonstrates how to turn off automatic detection. Moreover, recognition blocks are not defined, so OcrEngine creates one recognition block for the entire image.
#### **Added the DoSpellingCorrection Property**
The DoSpellingCorrection property has been added to the OcrConfig class. Exposing the DoSpellingCorrection property enables developers to choose if automatic spelling correction has to be applied. 

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Image = ImageStream.FromFile(@"image.tiff");

ocr.Languages.AddLanguage(Language.Load("english"));

ocr.Config.DoSpellingCorrection = true;

using (ocr.Resource = new FileStream(resourceFileName, FileMode.Open))

{

    if (ocr.Process())

    {

        Console.WriteLine(ocr.Text);

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("image.tiff")

ocr.Languages.AddLanguage(Language.Load("english"))

ocr.Config.DoSpellingCorrection = True

ocr.Resource = New FileStream(resourceFileName, FileMode.Open)

Using ocr.Resource

	If ocr.Process() Then

		Console.WriteLine(ocr.Text)

	End If

End Using

{{< /highlight >}}

{{% alert color="primary" %}} 

Use this option to improve OCR results but be aware that increases the total processing time.

{{% /alert %}} 
#### **Added the RemoveNonText Property**
The RemoveNonText property has been added to the OcrConfig class. Set this parameter to true if animage contains non-text components, for example pictures, that should be ignored during the recognition process.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Image = ImageStream.FromFile(@"image.tiff");

ocr.Languages.AddLanguage(Language.Load("english"));

ocr.Config.RemoveNonText = true;

using (ocr.Resource = new FileStream(resourceFileName, FileMode.Open))

{

    if (ocr.Process())

    {

        Console.WriteLine(ocr.Text);

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("image.tiff")

ocr.Languages.AddLanguage(Language.Load("english"))

ocr.Config.RemoveNonText = True

ocr.Resource = New FileStream(resourceFileName, FileMode.Open)

Using ocr.Resource

	If ocr.Process() Then

		Console.WriteLine(ocr.Text)

	End If

End Using

{{< /highlight >}}
### **Removed Properties**
#### **Dropped the AdjustUpsideDownRotationMode.Automatic & OcrConfig.NeedRotationCorrection Properties**
The AdjustUpsideDownRotationMode.Automatic and OcrConfig.NeedRotationCorrection properties have been dropped. Now only the UserDefined option is available and can be set through the OcrConfig.AdjustRotation property. If it is not defined, the default value is None.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Image = ImageStream.FromFile(@"image.tiff");

ocr.Languages.AddLanguage(Language.Load("english"));

ocr.Config.AdjustRotation = AdjustRotationMode.UserDefined;

ocr.Config.AdjustRotationAngle = 10;

using (ocr.Resource = new FileStream(resourceFileName, FileMode.Open))

{

    if (ocr.Process())

    {

        Console.WriteLine(ocr.Text);

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("image.tiff")

ocr.Languages.AddLanguage(Language.Load("english"))

ocr.Config.AdjustRotation = AdjustRotationMode.UserDefined

ocr.Config.AdjustRotationAngle = 10

ocr.Resource = New FileStream(resourceFileName, FileMode.Open)

Using ocr.Resource

	If ocr.Process() Then

		Console.WriteLine(ocr.Text)

	End If

End Using

{{< /highlight >}}
#### **Removed the OcrEngine.Confidence & OcrEngine.ProbabilitySymbols Properties**
Starting from version 2.0.0, Aspose.OCR APIs do not contain the OcrEngine.Confidence and OcrEngine.ProbabilitySymbols properties because we feel they were useless due to incorrect results. Currently, there is no way to know the confidence, whereas the probability symbols are not possible to determine since the whole algorithm is totally rewritten and now we do not return the next probability symbols instead a single string result is returned.
#### **Removed IRecognitionBlock.Text Property**
Use the IRecognizedText.ToString() method to retrieve the same. Moreover, the class IRecognizedText also contains IRecognizedTextPartInfo[] PartsInfo with test on each block.

This is how IRecognizedText class can be used.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Languages.AddLanguage(Language.Load("english"));

ocrProcess = OcrProcessCreator.CreateBestOcrProcess(_lang, _context);

IRecognizedText results = ocrProcess.Process(bmp);

string text = results.ToString();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Languages.AddLanguage(Language.Load("english"))

ocrProcess = OcrProcessCreator.CreateBestOcrProcess(_lang, _context)

Dim results As IRecognizedText = ocrProcess.Process(bmp)

Dim text As String = CType(results, Object).ToString()

{{< /highlight >}}
#### **Removed OcrConfig.OcrAlgorithmMode Property**
The said property has been removed because starting from version 2.0.0, the Aspose.OCR API has only one universal algorithm mode.

This is how the IRecognizedText class can be used.

**C#**

{{< highlight csharp >}}

 _ocrEngine.Config.OcrAlgorithmMode = OcrAlgorithmModes.DFG_Mode; // you don't need this statement any more

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 _ocrEngine.Config.OcrAlgorithmMode = OcrAlgorithmModes.DFG_Mode ' you don't need this statement any more

{{< /highlight >}}
