---
title: Aspose.OCR for .NET 2.7.0 Release Notes
type: docs
weight: 60
url: /net/aspose-ocr-for-net-2-7-0-release-notes/
---

We are pleased to share a new version of Aspose.OCR for .NET with following improvements:
## **New Features**
OCR-34032 Add Aspose.BarCode support in Java mode of template editor

OCR-33660 Support BarCode element properties for defining barcode type and other settings

OCR-33150 Ability to load image from URL
## **Enhancements**
OCR-34062 Support mouse right click copy of several selected elements

OCR-33949 Improve handling of noisy and low-contrast images

OCR-33927 Incorrect result returned by the markers filled with pencil

OCR-33925 Ability to specify Threshold value from Template Editor

OCR-33895 OMR results for the Grid Element does not seem legit

OCR-33863 DetectTextRegions property is not working correctly

Exceptions
OCR-34083 Template Editor crashes with invalid format exception
# **Public API and Backwards Incompatible Changes**
The following is a list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.OCR for .NET. If you have concerns about any change listed, please raise it on the Aspose.OCR support forum.
Added APIs:

{{< highlight java >}}

 Class Aspose.OMR.Elements.BarCodeType

Field/Enum Aspose.OMR.Elements.BarCodeType.AustralianPosteParcel

Field/Enum Aspose.OMR.Elements.BarCodeType.AustraliaPost

Field/Enum Aspose.OMR.Elements.BarCodeType.Auto

Field/Enum Aspose.OMR.Elements.BarCodeType.Aztec

Field/Enum Aspose.OMR.Elements.BarCodeType.Codabar

Field/Enum Aspose.OMR.Elements.BarCodeType.Code11

Field/Enum Aspose.OMR.Elements.BarCodeType.Code128

Field/Enum Aspose.OMR.Elements.BarCodeType.Code16K

Field/Enum Aspose.OMR.Elements.BarCodeType.Code39Extended

Field/Enum Aspose.OMR.Elements.BarCodeType.Code39Standard

Field/Enum Aspose.OMR.Elements.BarCodeType.Code93Extended

Field/Enum Aspose.OMR.Elements.BarCodeType.Code93Standard

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarExpanded

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarExpandedStacked

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarLimited

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarOmniDirectional

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarStacked

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarStackedOmniDirectional

Field/Enum Aspose.OMR.Elements.BarCodeType.DatabarTruncated

Field/Enum Aspose.OMR.Elements.BarCodeType.DataMatrix

Field/Enum Aspose.OMR.Elements.BarCodeType.DeutschePostIdentcode

Field/Enum Aspose.OMR.Elements.BarCodeType.DeutschePostLeitcode

Field/Enum Aspose.OMR.Elements.BarCodeType.EAN13

Field/Enum Aspose.OMR.Elements.BarCodeType.EAN14

Field/Enum Aspose.OMR.Elements.BarCodeType.EAN8

Field/Enum Aspose.OMR.Elements.BarCodeType.GS1Code128

Field/Enum Aspose.OMR.Elements.BarCodeType.GS1DataMatrix

Field/Enum Aspose.OMR.Elements.BarCodeType.IATA2of5

Field/Enum Aspose.OMR.Elements.BarCodeType.Interleaved2of5

Field/Enum Aspose.OMR.Elements.BarCodeType.ISBN

Field/Enum Aspose.OMR.Elements.BarCodeType.ISMN

Field/Enum Aspose.OMR.Elements.BarCodeType.ISSN

Field/Enum Aspose.OMR.Elements.BarCodeType.ItalianPost25

Field/Enum Aspose.OMR.Elements.BarCodeType.ITF14

Field/Enum Aspose.OMR.Elements.BarCodeType.ITF6

Field/Enum Aspose.OMR.Elements.BarCodeType.MacroPdf417

Field/Enum Aspose.OMR.Elements.BarCodeType.Matrix2of5

Field/Enum Aspose.OMR.Elements.BarCodeType.MicroPdf417

Field/Enum Aspose.OMR.Elements.BarCodeType.MicroQR

Field/Enum Aspose.OMR.Elements.BarCodeType.MSI

Field/Enum Aspose.OMR.Elements.BarCodeType.OneCode

Field/Enum Aspose.OMR.Elements.BarCodeType.OPC

Field/Enum Aspose.OMR.Elements.BarCodeType.PatchCode

Field/Enum Aspose.OMR.Elements.BarCodeType.Pdf417

Field/Enum Aspose.OMR.Elements.BarCodeType.Pharmacode

Field/Enum Aspose.OMR.Elements.BarCodeType.Planet

Field/Enum Aspose.OMR.Elements.BarCodeType.Postnet

Field/Enum Aspose.OMR.Elements.BarCodeType.PZN

Field/Enum Aspose.OMR.Elements.BarCodeType.QR

Field/Enum Aspose.OMR.Elements.BarCodeType.RM4SCC

Field/Enum Aspose.OMR.Elements.BarCodeType.SCC14

Field/Enum Aspose.OMR.Elements.BarCodeType.SSCC18

Field/Enum Aspose.OMR.Elements.BarCodeType.Standard2of5

Field/Enum Aspose.OMR.Elements.BarCodeType.Supplement

Field/Enum Aspose.OMR.Elements.BarCodeType.SwissPostParcel

Field/Enum Aspose.OMR.Elements.BarCodeType.UPCA

Field/Enum Aspose.OMR.Elements.BarCodeType.UPCE

Field/Enum Aspose.OMR.Elements.BarCodeType.VIN

Method Aspose.OCR.ImageStream.FromStream(System.IO.Stream,Aspose.OCR.ImageStreamFormat)

Method Aspose.OCR.ImageStream.FromUrl(System.String)

Method Aspose.OMR.Elements.BarcodeElement.LoadProperties(System.Collections.Specialized.StringDictionary)

Method Aspose.OMR.Elements.BarcodeElement.SaveProperties

Property Aspose.OMR.Elements.BarcodeElement.BarCodeType

{{< /highlight >}}

Removed APIs:
Method Aspose.OCR.ImageStream.FromMemoryStream(System.IO.MemoryStream,Aspose.OCR.ImageStreamFormat)
Important Note
Aspose.OCR component uses resource files to perform OCR operations on specific languages. From 2.2.0 version resource file for default language (English) is embedded into Aspose.OCR.dll and there is no need to download it separately. Currently recognition of French, Spanish and Portuguese languages is also supported. You can download specific resource files from this page.
. 
