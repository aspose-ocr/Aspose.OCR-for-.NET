---
title: Aspose.OCR for .NET 2.8.0 Release Notes
type: docs
weight: 50
url: /net/aspose-ocr-for-net-2-8-0-release-notes/
---

We are pleased to share a new version of Aspose.OCR for .NET with following improvements:
## **New Features**
OCR-34108 OMR should detect image resolution automatically
## **Enhancements**
OCR-34092 Method OmrConfig.setFillThreshold() incorrect verifies input data

OCR-34091 Incorrect recognized text for specific file

OCR-34089 Multiselection for Grid element

OCR-34071 Invalid CopyRight symbol on NuGet page for Aspose.OCR

OCR-34110 Public methods related to Omr module have to throw OmrException
## **Exceptions**
OCR-34087 Possible invalid input crashes due to PreviewTextInput non-obvious behavior OCR-34122 Arithmetic operation resulted in an overflow
# **Public API and Backwards Incompatible Changes**
The following is a list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.OCR for .NET. If you have concerns about any change listed, please raise it on the Aspose.OCR support forum.
Added APIs:

{{< highlight java >}}

 Class Aspose.OMR.OmrException

Method Aspose.OMR.OmrException.#ctor(System.Exception)

Method Aspose.OMR.OmrException.#ctor(System.String,System.Exception)

Property Aspose.OMR.OmrImage.AutoDetectResolution

{{< /highlight >}}

Removed APIs:
None
Important Note
Aspose.OCR component uses resource files to perform OCR operations on specific languages. From 2.2.0 version resource file for default language (English) is embedded into Aspose.OCR.dll and there is no need to download it separately. Currently recognition of French, Spanish and Portuguese languages is also supported. You can download specific resource files from this page
.
