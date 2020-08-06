---
title: Aspose.OCR for Java 3.4.0 Release Notes
type: docs
weight: 60
url: /java/aspose-ocr-for-java-3-4-0-release-notes/
---

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|OCR-34314|Exception while trying to save Preprocessed Binarized Image|Enhancement|
|OCR-34279|Exception occurs when using OCR for Java|Enhancement|
|OCR-34251|Unable to perform OCR operation on transparent images|Enhancement|
|OCR-34295|Verify Aspose.OCR namespaces conform to Microsoft guidelines|Enhancement|
# **Usage examples:**
**OCR-34295 Verify Aspose.OCR namespaces conform to Microsoft guidelines** 
Usage example for moved class TextPartLevel:

{{< highlight java >}}

  OcrEngine ocr = new OcrEngine();

 String pictureFileName = "realTextArial20pt01.bmp";

 ocr.setImage(ImageStream.fromFile(pictureFileName));

 if (ocr.process())

 {

   IRecognizedTextPartInfo firstLine = ((IRecognizedTextPartInfo)ocr.getText().getPartsInfo()[0]).getChildren()[0];

   System.out.println(firstLine.getLevel() == TextPartLevel.Line);

 }

{{< /highlight >}}
### **Public API and Backward Incompatible Changes**
## **Added APIs:**

|** |** |
| :- | :- |
|Class|com.aspose.ocr.TextPartLevel|
|Field/Enum|com.aspose.ocr.TextPartLevel.Character|
|Field/Enum|com.aspose.ocr.TextPartLevel.Line|
|Field/Enum|com.aspose.ocr.TextPartLevel.Textblock|
|Field/Enum|com.aspose.ocr.TextPartLevel.Word|
## **Removed APIs:**

|** |** |
| :- | :- |
|Class|com.aspose.ocr.recognizedtext.textpartinfo.TextPartLevel|
|Field/Enum|com.aspose.ocr.recognizedtext.textpartinfo.TextPartLevel.Character|
|Field/Enum|com.aspose.ocr.recognizedtext.textpartinfo.TextPartLevel.Line|
|Field/Enum|com.aspose.ocr.recognizedtext.textpartinfo.TextPartLevel.Textblock|
|Field/Enum|com.aspose.ocr.recognizedtext.textpartinfo.TextPartLevel.Word|

