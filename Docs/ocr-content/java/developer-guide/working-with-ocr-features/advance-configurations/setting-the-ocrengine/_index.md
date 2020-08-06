---
title: Setting the OcrEngine
type: docs
weight: 30
url: /java/setting-the-ocrengine/
---

## **Setting the OcrEngine to Automatically Detect the Reading Order**
{{% alert color="primary" %}} 

The [OcrConfig](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig) class exposes the [DetectReadingOrder](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectReadingOrder\(boolean\)) property to handle situations where an image contains another image with text in it. Setting this Boolean property to **true** instructs the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) to maintain the order of text regions for better recognition results.

{{% /alert %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.io.InputStream\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).
### **Setting the OcrEngine to Detect Reading Order**
Images that contain text can be divided into several text recognition areas. It is sometimes important to apply a special sorting so that the correct text block order is maintained.

{{% alert color="primary" %}} 

Performance degradation may be observed for images that have a large number of text blocks. In such cases, it is advised to turn this feature off by setting the [DetectReadingOrder](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectReadingOrder\(boolean\)) property to **false**.

{{% /alert %}} 
#### **Programming sample**
The code snippet below demonstrates how to use the [DetectReadingOrder](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectReadingOrder\(boolean\)) property to auto-detect the reading order.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-SettingOcrEnginetoAutomaticallyDetecttheReadingOrder-SettingOcrEnginetoAutomaticallyDetecttheReadingOrder.java" >}}
## **Setting the OcrEngine to Automatically Detect the Text Blocks**
The [OcrConfig](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig) class has exposed the [DetectTextRegions](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectTextRegions\(boolean\)) property. Setting this Boolean type property to **true** before performing OCR on an image lets the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) calculate the text blocks from the image itself.

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.io.InputStream\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).
### **Setting the OcrEngine to Automatically Detect the Text Blocks**
Images that contain text can be divided into many text recognition areas or blocks. When using the [DetectTextRegions](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectTextRegions\(boolean\)) property, the developers may direct the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) to calculate the text blocks.

{{% alert color="primary" %}} 

The default value of the [DetectTextRegions](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectTextRegions\(boolean\)) property is **true**, causing the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) to ignore user-defined recognition blocks. Setting the [DetectTextRegions](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectTextRegions\(boolean\)) property to **false** lets the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) process the complete image as one text block unless user-defined text blocks are set.

{{% /alert %}} 
#### **Programming Sample**
The code snippet below demonstrates the use of the [DetectTextRegions](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectTextRegions\(boolean\)) property to auto-detect text blocks.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-SettingOcrEnginetoAutomaticallyDetectTextBlocks-SettingOcrEnginetoAutomaticallyDetectTextBlocks.java" >}}
## **Setting the OcrEngine to Automatically Correct the Spellings**
The [OcrConfig](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig) class has exposed [DoSpellingCorrection](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDoSpellingCorrection\(boolean\)) property. Setting this Boolean type property to **true** before performing OCR on an image directs the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) to perform the spell check on the recognized text.

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.io.InputStream\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).
### **Setting the OcrEngine to Automatically Correct Spelling**
The [DoSpellingCorrection](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDoSpellingCorrection\(boolean\)) property gets or sets a value indicating whether automatic spelling correction should be applied to the recognized text.

{{% alert color="primary" %}} 

The default value of the [DoSpellingCorrection](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDoSpellingCorrection\(boolean\)) property is **false**. Setting the [DoSpellingCorrection](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDoSpellingCorrection\(boolean\)) property to **true** improves the OCR recognition results but the process may take more time to complete.

{{% /alert %}} 
#### **Programming Sample**
The code snippet below demonstrates how to use the [DoSpellingCorrection](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDoSpellingCorrection\(boolean\)) property to auto-correct spelling in recognized text.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-SettingtheOcrEnginetoAutomaticallyCorrecttheSpellings-SettingtheOcrEnginetoAutomaticallyCorrecttheSpellings.java" >}}
## **Setting the OcrEngine to Ignore Non-Textual Blocks**
The [OcrConfig](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig) class has exposed the getter/setter for [RemoveNonText](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setRemoveNonText\(boolean\)) property. Setting this property to **true** before performing OCR on an image directs the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) to detect and ignore the non-textual contents (graphics) from the operation.

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.io.InputStream\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).
### **Setting the OcrEngine to Ignore Non-Textual Blocks**
The [RemoveNonText](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setRemoveNonText\(boolean\)) property gets or sets a Boolean value indicating whether to ignore the non-textual contents from the OCR operation.
#### **Programming Sample**
The code snippet below provided code snippet demonstrates how to use the [RemoveNonText](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setRemoveNonText\(boolean\)) property.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-SettingtheOcrEnginetoIgnoreNonTextualBlocks-SettingtheOcrEnginetoIgnoreNonTextualBlocks.java" >}}
## **Setting OcrEngine to Recognize Only White Listed Characters**
The Aspose.OCR APIs allow to add a list of characters for recognition purposes, and while performing the OCR operation the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) recognizes only the specified characters. The API has exposed the [OcrConfig.Whitelist](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#getWhitelist\(\)) that can be used to get/set the list of characters.

{{% alert color="primary" %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.io.InputStream\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).

{{% /alert %}} 
### **Setting the White-list**
The [OcrConfig.Whitelist](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#getWhitelist\(\)) property allows to specify the recognition characters (in other words – restricted recognition characters). This feature is useful in scenarios where images may contain only digits and the process needs the guarantee that the recognition result will contain only the digits without any characters (e.g. digit ‘0’ may be recognized as char ‘O’, or ‘1’ as ‘I’).

The code snippet below demonstrates how [OcrConfig.Whitelist](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#getWhitelist\(\)) can be used to set the white-list for [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine).

If [OcrConfig.Whitelist](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#getWhitelist\(\)) property is not null and not empty, the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) recognizes only the white-listed characters.
#### **Programming Sample**
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-SettingOcrEnginetoRecognizeOnlyWhiteListedCharacters-SettingOcrEnginetoRecognizeOnlyWhiteListedCharacters.java" >}}
## **Setting the OcrEngine to Exclude saving preprocessed images**
The [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class exposes the [SavePreprocessedImages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setSavePreprocessedImages\(boolean\)) property to improve the OCR operation with respect to execution time. Setting this Boolean property to **false** instructs the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) not the save the preprocessed image during OCR operation.
### **Excluding Preprocessed Images from OCR operation**
It is sometimes required to optimize the OCR operation to reduce the OCR processing time. Aspose.OCR provides facility to optimize performance by excluding the preprocessed image from being saved during processing.

{{% alert color="primary" %}} 

Saving the preprocessed image can be done on demand by setting [SavePreprocessedImages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setSavePreprocessedImages\(boolean\)) property to **true**. This will cause performance degradation.

{{% /alert %}} 

The code snippet below demonstrates how to use the [SavePreprocessedImages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setSavePreprocessedImages\(boolean\)) property to exclude preprocessed images from being saved.
#### **Programming Sample**
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-SettingtheOcrEnginetoExcludesavingpreprocessedimages-SettingtheOcrEnginetoExcludesavingpreprocessedimages.java" >}}
