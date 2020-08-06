---
title: Public API Changes in Aspose.OCR 2.7.0
type: docs
weight: 50
url: /java/public-api-changes-in-aspose-ocr-2-7-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.4.0 to 2.7.0, that may be of interest to module and application developers. It includes not only new and updated public methods, [added classes etc.](/ocr/java/public-api-changes-in-aspose-ocr-2-7-0-html/), but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
## **Added Enumerations, Methods, Fields & Properties**
### **Enumeration BarCodeType Added**
The com.aspose.omr.elements.BarCodeType enumeration and com.aspose.omr.elements.BarcodeElement.BarCodeType property has been added to the public API in order to specify the barcode type that needs to be extracted from a scanned OMR form. com.aspose.omr.elements.BarCodeType enumeration has many fields as listed below whereas the following code snippet demonstrates the usage scenario.

**Java**

{{< highlight csharp >}}

 // Load the template for mapping of elements

OmrTemplate template = OmrTemplate.load(templateFile);

// Add the BarCode element while specifying the location and size of barcode

java.awt.Dimension objDimension = new java.awt.Dimension(205, 205);

// Create a new instance of BarcodeElement while specifying the position and size of the barcode rectange

BarcodeElement barcodeElement = new BarcodeElement("DataMatrix", new Point2D.Float(0, 0), objDimension);

// Set BarCodeType to DataMatrix

barcodeElement.setBarCodeType(BarCodeType.DataMatrix);

// Add the BarCode element to the template page

template.getPages().getItem(0).getElements().add(barcodeElement);

{{< /highlight >}}

|**Type** |**Fully Qualified Field Name** |
| :- | :- |
|Field/Enum |com.aspose.omr.elements.BarCodeType.AustralianPosteParcel |
|Field/Enum |com.aspose.omr.elements.BarCodeType.AustraliaPost |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Auto |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Aztec |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Codabar |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code11 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code128 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code16K |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code39Extended |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code39Standard |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code93Extended |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Code93Standard |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarExpanded |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarExpandedStacked |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarLimited |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarOmniDirectional |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarStacked |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarStackedOmniDirectional |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DatabarTruncated |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DataMatrix |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DeutschePostIdentcode |
|Field/Enum |com.aspose.omr.elements.BarCodeType.DeutschePostLeitcode |
|Field/Enum |com.aspose.omr.elements.BarCodeType.EAN13 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.EAN14 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.EAN8 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.GS1Code128 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.GS1DataMatrix |
|Field/Enum |com.aspose.omr.elements.BarCodeType.IATA2of5 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Interleaved2of5 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.ISBN |
|Field/Enum |com.aspose.omr.elements.BarCodeType.ISMN |
|Field/Enum |com.aspose.omr.elements.BarCodeType.ISSN |
|Field/Enum |com.aspose.omr.elements.BarCodeType.ItalianPost25 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.ITF14 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.ITF6 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.MacroPdf417 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Matrix2of5 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.MicroPdf417 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.MicroQR |
|Field/Enum |com.aspose.omr.elements.BarCodeType.MSI |
|Field/Enum |com.aspose.omr.elements.BarCodeType.OneCode |
|Field/Enum |com.aspose.omr.elements.BarCodeType.OPC |
|Field/Enum |com.aspose.omr.elements.BarCodeType.PatchCode |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Pdf417 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Pharmacode |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Planet |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Postnet |
|Field/Enum |com.aspose.omr.elements.BarCodeType.PZN |
|Field/Enum |com.aspose.omr.elements.BarCodeType.QR |
|Field/Enum |com.aspose.omr.elements.BarCodeType.RM4SCC |
|Field/Enum |com.aspose.omr.elements.BarCodeType.SCC14 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.SSCC18 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Standard2of5 |
|Field/Enum |com.aspose.omr.elements.BarCodeType.Supplement |
|Field/Enum |com.aspose.omr.elements.BarCodeType.SwissPostParcel |
|Field/Enum |com.aspose.omr.elements.BarCodeType.UPCA |
|Field/Enum |com.aspose.omr.elements.BarCodeType.UPCE |
|Field/Enum |com.aspose.omr.elements.BarCodeType.VIN |
### **Methods Added for ImageStream Class**
With this release, Aspose.OCR for Java API has exposed two new methods to load the OCR image. 

1. com.aspose.ocr.ImageStream.fromStream(InputStream, com.aspose.ocr.ImageStreamFormat): Specialized method to load the image from stream objects.
1. com.aspose.ocr.ImageStream.fromUrl(String): Specialized method to load image from remote location.
### **Property AutoDetectResolution Added**
The com.aspose.omr.OmrImage class exposed the AutoDetectResolution property that can be used to determine the resolution of the OMR scanned image at runtime. When calculating position of OMR elements on a scanned image, the OMR engine considers pixel size and resolution of the image to obtain image dimensions in millimeters. This calculation relies on value for image resolution set by scanning software. In case the scanning software did not set the image resolution or sets it to an invalid value, it is necessary to either set correct value for the resolution property manually or, if proportions of the image match proportions of the template, now it is possible to enable automatic detection of resolution by setting AutoDetectResolution property to true.

**Java**

{{< highlight csharp >}}

 // Create an instance of OmrImage and load the image file from disk

OmrImage omrImage = OmrImage.load(imageName);

// Set the AutoDetectResolution property to true

omrImage.setAutoDetectResolution(true);

{{< /highlight >}}

The property AutoDetectResolution controls automatic detection of image resolution. It is false by default and the detection is turned off.

Automatic detection requires proportions of image and template to match (discrepancy should be less than 5%). If ratio of height to width for the image differs from ratio of height to width for the template, then the engine raises IllegalArgumentException.

{{% alert color="primary" %}} 

If automatic resolution detection is turned off and size of image (in millimeters) exceeds size of the template, OMR only handles part of the image starting from the top-left corner.

{{% /alert %}}
