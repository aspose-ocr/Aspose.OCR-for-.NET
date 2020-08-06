---
title: Aspose.OCR for .NET 3.3.0 Release Notes
type: docs
weight: 80
url: /net/aspose-ocr-for-net-3-3-0-release-notes/
---

We are pleased to share a new version of Aspose.OCR for .NET with following improvements:
## **New Features**
OCR-34195 Automatic skew correction for scanned OMR answer sheets
## **Enhancements**
OCR-34267 Barcode 1D type cannot be detected 
OCR-34222 Detect type of Barcode elements automatically
# **Public API and Backwards Incompatible Changes**
The following is a list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.OCR for .NET. If you have concerns about any change listed, please raise it on the Aspose.OCR support forum.
Added APIs:

{{< highlight java >}}

 Class Aspose.OMR.ImageProcessing.SkewCorrectionAlgorithm Method Aspose.OMR.ImageProcessing.SkewCorrectionAlgorithm.#ctor Method Aspose.OMR.ImageProcessing.SkewCorrectionAlgorithm.GetSkewDegree(Aspose.OMR.OmrImage,System.Drawing.Rectangle) Method Aspose.OMR.ImageProcessing.SkewCorrectionAlgorithm.Process(Aspose.OMR.OmrImage@,System.Drawing.Rectangle) Method Aspose.OMR.OmrEngine.GetSkewDegree(Aspose.OMR.OmrImage) Method Aspose.OMR.OmrEngine.RotateImage(Aspose.OMR.OmrImage@,System.Int32) Method Aspose.OMR.OmrEngine.RunSkewCorrection(Aspose.OMR.OmrImage@) Property Aspose.OMR.OmrEngine.SkewCorrectionEnabled

Removed APIs:

Property Aspose.OCR.IRecognizedTextPartInfo.Bold

Property Aspose.OCR.IRecognizedTextPartInfo.Font

Property Aspose.OCR.IRecognizedTextPartInfo.FontSize

Property Aspose.OCR.IRecognizedTextPartInfo.Underline

{{< /highlight >}}

Important Note
Aspose.OCR component uses resource files to perform OCR operations on specific languages. From 2.2.0 version resource file for default language (English) is embedded into Aspose.OCR.dll and there is no need to download it separately. Currently recognition of French, Spanish and Portuguese languages is also supported.
Note
that resource files were updated since v3.2.0 release. You can download specific resource files from this page
. 
