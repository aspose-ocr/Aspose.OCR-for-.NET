---
title: Public API Changes in Aspose.OCR 2.9.0
type: docs
weight: 80
url: /net/public-api-changes-in-aspose-ocr-2-9-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.8.0 to 2.9.0, that may be of interest to module and application developers. 

{{% /alert %}} 
## **Added Methods**
### **Load OMR Template from Remote Location**
The Aspose.OMR.OmrTemplate class exposed the LoadFromUrl method to load the OMR template from a remote location using URL.

Usage scenario of LoadFromUrl method is as follow.

**C#**

{{< highlight csharp >}}



string templateUrl = "https://sampleurl.com/template.amr";

string imageUrl = "https://sampleurl.com/image.jpg";

OmrTemplate template = OmrTemplate.LoadFromUrl(templateUrl);

OmrImage image = OmrImage.LoadFromUrl(imageUrl);

OmrEngine engine = new OmrEngine(template);

OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });


{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim templateUrl As String = "https://sampleurl.com/template.amr"

Dim imageUrl As String = "https://sampleurl.com/image.jpg"

Dim template As OmrTemplate = OmrTemplate.LoadFromUrl(templateUrl)

Dim image As OmrImage = OmrImage.LoadFromUrl(imageUrl)

Dim engine As New OmrEngine(template)

Dim result As OmrProcessingResult = engine.ExtractData(New OmrImage() {image})

{{< /highlight >}}
