---
title: Supplying Multiple White Lists
type: docs
weight: 60
url: /java/supplying-multiple-white-lists/
---

{{% alert color="primary" %}} 

Aspose.OCR APIs provide the functionality to perform the OCR operation with more than one white list for a single OCR operation. This article describes the usage of Aspose.OCR for Java API to accomplish this task. Sample code demonstration is given below.

{{% /alert %}} 
#### **Supply More Than One White List**
Aspose.OCR for Java API has introduced a new property Whitelist in [IRecognitionBlock](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognitionBlock) interface. With the help of this property developer can set whitelist for each [IRecognitionBlock](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognitionBlock) in a single OCR process. Below provided code snippet demonstrates how to process multiple [IRecognitionBlock](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognitionBlock) with their own whitelist in a single OCR operation.

#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-RecognizeMultipleWhiteLists-RecognizeMultipleWhiteLists.java" >}}
