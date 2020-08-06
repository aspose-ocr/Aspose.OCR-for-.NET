---
title: Getting Notification for Each Recognized Word
type: docs
weight: 40
url: /java/getting-notification-for-each-recognized-word/
---

## **Getting Notification for Each Recognized Word**
{{% alert color="primary" %}} 

In the article [Performing OCR on an Image](/ocr/java/performing-ocr-on-an-image-html/), we showed how to perform OCR on an image and get the whole recognized text after the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) completed the scan. Aspose.OCR for java also lets you get a notification as soon as a word is recognized during the scan.

{{% /alert %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.io.InputStream\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).
### **Getting Notified about Each Recognized Word**
1. Initialize an object of [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) with its default constructor.
1. Set the image file on which OCR is to be performed.
1. Call the [NotifierFactory.wordNotifier](https://apireference.aspose.com/java/ocr/com.aspose.ocr/NotifierFactory#wordNotifier\(\)) method to get an instance of [INotifier](https://apireference.aspose.com/java/ocr/com.aspose.ocr/INotifier) class.
1. Add a handler to the [INotifier](https://apireference.aspose.com/java/ocr/com.aspose.ocr/INotifier) and write the delegate to get the recognized word.
1. Call the [OcrEngine.addNotifier](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#addNotifier\(com.aspose.ocr.INotifier\)) method to add the word processor to [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine).
1. Call the [OcrEngine.process](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method to start the image scan.
#### **Programming Sample**
The sample code below follows the above steps to OCR an image and get notification of each recognized word.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-GettingNotificationforEachRecognizedWord-GettingNotificationforEachRecognizedWord.java" >}}
