---
title: Public API Changes in Aspose.OCR 2.8.0
type: docs
weight: 70
url: /net/public-api-changes-in-aspose-ocr-2-8-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.7.0 to 2.8.0, that may be of interest to module and application developers. It includes not only new and updated public methods, [added classes etc.](/ocr/net/public-api-changes-in-aspose-ocr-2-8-0-html/) but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
## **Added Classes, Methods**
### **Exception Handling for OmrEngine**
The Aspose.OMR.OmrException class allows to catch exceptions that are related to the OmrEngine. Along with the aforesaid class, this release has also exposed the Aspose.OMR.OmrException.#ctor(System.Exception) & Aspose.OMR.OmrException.#ctor(System.String,System.Exception) methods. 

Usage scenario of Aspose.OMR.OmrException class is as follow.

**C#**

{{< highlight csharp >}}

 try

{

   OmrTemplate template = OmrTemplate.Load("sample.amr");

   OmrImage image = OmrImage.Load("sample.jpg");

   OmrEngine engine = new OmrEngine(template);

   OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });

}

catch (OmrException e)

{

   Console.WriteLine(e.StackTrace);

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Try

   Dim template As OmrTemplate = OmrTemplate.Load("sample.amr")

   Dim image As OmrImage = OmrImage.Load("sample.jpg")

   Dim engine As New OmrEngine(template)

   Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() { image })

Catch e As OmrException

   Console.WriteLine(e.StackTrace)

End Try

{{< /highlight >}}
### **Property AutoDetectResolution Added**
The Aspose.OMR.OmrImage.AutoDetectResolution property can be used to detect the resolution of the image passed on to the OmrImage class by setting it to true. If AutoDetectResolution property is set to true, the OmrEngine attempts to determine resolution of the image automatically. However, if the resolutions of the OmrTemplate and the scanned image are different, an exception will be thrown.

Usage scenario of Aspose.OMR.OmrImage.AutoDetectResolution property is as follow.

**C#**

{{< highlight csharp >}}

 OmrImage image = OmrImage.Load("sample.jpg");

image.AutoDetectResolution = true;

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim image As OmrImage = OmrImage.Load("sample.jpg")

image.AutoDetectResolution = True

{{< /highlight >}}
