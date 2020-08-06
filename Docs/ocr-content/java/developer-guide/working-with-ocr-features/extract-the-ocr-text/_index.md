---
title: Extract the OCR Text
type: docs
weight: 10
url: /java/extract-the-ocr-text/
---

## **Read the Part Information of Recognized Text**
{{% alert color="primary" %}} 

Aspose.OCR for Java extracts the OCR text in 'parts'. You can read the extracted text either as a whole or by parts. Each part of the extracted text contains all the information about the text. The information held in the part includes the text, language, font, text size, text style (bold, italic or underlined), dimensions, and so on.

{{% /alert %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).

Information about a part can be read using the following steps:

1. Setup OCR operation as discussed in [Performing OCR on an Image](/ocr/java/performing-ocr-on-an-image-html/).
1. Load recognized text from the [OcrEngine.Text.PartsInfo](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognizedText#getPartsInfo\(\)) property into an array of [IRecognizedPartInfo](https://apireference.aspose.com/java/ocr/com.aspose.ocr/irecognizedpartinfo).
1. Loop through each item of the [IRecognizedText.PartsInfo](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognizedText#getPartsInfo\(\)) collection to read the part information.
### **Programming Sample**
This sample code shows how to read the part information from extracted text using the steps described above.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-ReadingPartInformation-ReadingPartInformation.java" >}}
## **Get Text Part Hierarchy of Recognized Text**
Aspose.OCR APIs allows extracting the text either as a whole or by parts whereas each part has its own Style, Font, Text Size and Location in the image, and all of this information can easily be extracted as discussed earlier in [Read the Part Information of Recognized Text](/ocr/java/extract-the-ocr-text/#extracttheocrtext-readthepartinformationofrecognizedtext). The API also allows retrieving the hierarchy of each recognized part on the image as TextBlock, Line, Word or Character. Hierarchy of the recognized part can be extracted using the [TextPartLevel](https://apireference.aspose.com/java/ocr/com.aspose.ocr/TextPartLevel) class.

{{% alert color="primary" %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).

{{% /alert %}} 

In addition to the [TextPartLevel](https://apireference.aspose.com/java/ocr/com.aspose.ocr/TextPartLevel) class, the API has exposed two useful properties for the [IRecognizedTextPartInfo](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognizedTextPartInfo) interface such as [Level](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognizedTextPartInfo#getLevel\(\)) and [Children](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognizedTextPartInfo#getChildren\(\)) that provide access to the hierarchical level and lower level textual parts respectively.
### **Programming Sample**
Below provided code snippet demonstrates the concept in a detailed manner.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-GetTextPartHierarchyofRecognizedText-GetTextPartHierarchyofRecognizedText.java" >}}
