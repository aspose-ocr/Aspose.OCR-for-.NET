---
title: Adding User Defined Recognition Blocks
type: docs
weight: 20
url: /java/adding-user-defined-recognition-blocks/
---

## **Adding User Defined Recognition Blocks**
{{% alert color="primary" %}} 

The Aspose.OCR for Java API allows adding user-defined blocks or zones as rectangles in document images. User-defined blocks are added to the [RecognitionBlocks](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognitionBlock) collection and are processed with the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) while all other spaces in the image are skipped.

If user-defined blocks are not set, the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) will auto-detect the recognition blocks on the document image.

{{% /alert %}} {{% alert color="primary" %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).

{{% /alert %}} 
### **Getting Values to Define Recognition Block**
**Text Recognition Block** can be created using [CreateTextBlock](https://apireference.aspose.com/java/ocr/com.aspose.ocr/RecognitionBlock#createTextBlock\(int,%20int,%20int,%20int\)) method. It takes four parameters namely:

1. X – Coordinates
1. Y – Coordinates
1. The width of the Area
1. The height of the Area

There are different software that provides the information about the **X, Y** Coordinates, **Width and Height** of the area selected on the image. Microsoft Paint and TechSmith Snagit are examples of such software. If we consider MS Paint software then following are the steps are used to get the above-mentioned information:

- Open the image in MS Paint
- Pick the Selection Tool from Home tab on the top.

This tool will help you to select the part of the image.

- While using Selection Tool, look at the left down corner on the **Status Bar**. You will be able to find the **X, Y** Coordinates.
  The very next will be the **Width, Height** information of the selected area on the image.
#### **Programming Sample**
The code snippet given below demonstrates how user-defined blocks can be added.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-AddingUserDefinedRecognitionBlocks-AddingUserDefinedRecognitionBlocks.java" >}}
