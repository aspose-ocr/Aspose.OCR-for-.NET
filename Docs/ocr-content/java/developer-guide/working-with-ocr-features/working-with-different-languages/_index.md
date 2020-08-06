---
title: Working with Different Languages
type: docs
weight: 50
url: /java/working-with-different-languages/
---

## **Working with Different Languages**
{{% alert color="primary" %}} 

Aspose.OCR for Java API currently supports the following languages.

1. English
1. Spanish
1. French
1. Portuguese

{{% /alert %}} 
### **Working with Different Languages**
English is the default language, therefore, no extra settings are required, and a simple OCR operation can be performed for the English language.

All other languages require loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. The following code demonstrates the use of the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method to perform OCR for other languages.
#### **Programming Sample**
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-WorkingwithDifferentLanguages-WorkingwithDifferentLanguages.java" >}}
#### **Available Resources**
Currently available resources are as follow.

1. [Spanish Language Resources](https://downloads.aspose.com/ocr/net/resources/)
1. [French Language Resources](https://downloads.aspose.com/ocr/net/resources/)
1. [Portuguese Language Resources](https://downloads.aspose.com/ocr/net/resources/)
