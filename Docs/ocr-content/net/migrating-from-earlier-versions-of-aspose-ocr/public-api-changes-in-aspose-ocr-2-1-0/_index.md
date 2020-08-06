---
title: Public API Changes in Aspose.OCR 2.1.0
type: docs
weight: 20
url: /net/public-api-changes-in-aspose-ocr-2-1-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.0.0 to 2.1.0, that may be of interest to module and application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
### **Added Properties & Interfaces**
#### **Added the IRecognizedPartInfo Interface**
The IRecognizedPartInfo interface has been added to the Aspose.OCR namespace to provide information regarding the recognized text or image block. 

**C#**

{{< highlight csharp >}}

 using (engine.Resource = new FileStream(resourceFileName, FileMode.Open))

{

    if (engine.Process())

    {

        Console.WriteLine("\ranswer -> " + engine.Text);

        foreach (IRecognizedPartInfo recognizedPartInfo in engine.Text.PartsInfo)

        {

            if (recognizedPartInfo is IRecognizedTextPartInfo)

            {

                // Text part

                IRecognizedTextPartInfo textPartInfo = recognizedPartInfo as IRecognizedTextPartInfo;

                Console.WriteLine(textPartInfo.Language);

                Console.WriteLine(textPartInfo.Font);

                Console.WriteLine(textPartInfo.FontSize);

                Console.WriteLine(textPartInfo.TextColor);

                Console.WriteLine(textPartInfo.Bold);

                Console.WriteLine(textPartInfo.Italic);

            }

        }

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 engine.Resource = New FileStream(resourceFileName, FileMode.Open)

Using engine.Resource

	If engine.Process() Then

		Console.WriteLine(Constants.vbCr & "answer -> " & engine.Text)

		For Each recognizedPartInfo As IRecognizedPartInfo In engine.Text.PartsInfo

			If TypeOf recognizedPartInfo Is IRecognizedTextPartInfo Then

				' Text part

				Dim textPartInfo As IRecognizedTextPartInfo = TryCast(recognizedPartInfo, IRecognizedTextPartInfo)

				Console.WriteLine(textPartInfo.Language)

				Console.WriteLine(textPartInfo.Font)

				Console.WriteLine(textPartInfo.FontSize)

				Console.WriteLine(textPartInfo.TextColor)

				Console.WriteLine(textPartInfo.Bold)

				Console.WriteLine(textPartInfo.Italic)

			End If

		Next recognizedPartInfo

	End If

End Using

{{< /highlight >}}
#### **Added the IRecognizedPartInfo.Box Property**
The IRecognizedPartInfo.Box property can be used to get the rectangular area where the detected block (with text or picture) is shown on the image. The Box property returns the coordinates starting from the upper left corner of the image.

**C#**

{{< highlight csharp >}}

 using (engine.Resource = new FileStream(ResourceFileName, FileMode.Open))

{

    if (engine.Process())

    {

        Console.WriteLine("\ranswer -> " + engine.Text);

        foreach (IRecognizedPartInfo recognizedPartInfo in engine.Text.PartsInfo)

        {

            if (recognizedPartInfo is IRecognizedTextPartInfo)

            {

                // Text part

                IRecognizedTextPartInfo textPartInfo = recognizedPartInfo as IRecognizedTextPartInfo;

                Console.WriteLine(textPartInfo.Language);

            }

            else

            {

                // isnt text, only rectangle box, that determines region recognized as picture

                Console.WriteLine(recognizedPartInfo.Box);

            }

        }

    }

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 engine.Resource = New FileStream(ResourceFileName, FileMode.Open)

Using engine.Resource

	If engine.Process() Then

		Console.WriteLine(Constants.vbCr & "answer -> " & engine.Text)

		For Each recognizedPartInfo As IRecognizedPartInfo In engine.Text.PartsInfo

			If TypeOf recognizedPartInfo Is IRecognizedTextPartInfo Then

				' Text part

				Dim textPartInfo As IRecognizedTextPartInfo = TryCast(recognizedPartInfo, IRecognizedTextPartInfo)

				Console.WriteLine(textPartInfo.Language)

			Else

				' isnt text, only rectangle box, that determines region recognized as picture

				Console.WriteLine(recognizedPartInfo.Box)

			End If

		Next recognizedPartInfo

	End If

End Using

{{< /highlight >}}
### **Removed Properties**
#### **Removed IRecognizedTextPartInfo.Box Property**
The IRecognizedTextPartInfo.Box property has been moved to upper level interface IRecognizedPartInfo in order make is accessible for non-textual blocks. Please refer to the code snippet for the IRecognizedPartInfo.Box property.
