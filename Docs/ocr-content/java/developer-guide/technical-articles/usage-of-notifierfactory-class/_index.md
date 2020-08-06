---
title: Usage of NotifierFactory Class
type: docs
weight: 30
url: /java/usage-of-notifierfactory-class/
---

{{% alert color="primary" %}} 

As the name suggests, the com.aspose.ocr.NotifierFactory class is the factory for creating objects of type INotifier that in turn can be used to enable the notifications during the OCR process.

{{% /alert %}} 
#### **Usage of NotifierFactory Class**
The time to perform the OCR operation mainly depends on the complexity of the input image. In cases when the input image is too complex, the OcrEngine may take some time to complete the task however, the process may seem to be stalled. Aspose.OCR for Java API has exposed the NotifierFactory class that can be used to enable the notification system that triggers upon completion of task depending upon the type of INotifier.

The com.aspose.ocr.NotifierFactory class provides the support for 5 types of different notifiers as detailed below.

1. com.aspose.ocr.NotifierFactory.symbolNotifier method can be used to create the notifier that causes an event on each recognized symbol.
1. com.aspose.ocr.NotifierFactory.wordNotifier method can be used to create the notifier that causes an event on each recognized word.
1. com.aspose.ocr.NotifierFactory.lineNotifier method can be used to create the notifier that causes an event on each recognized line.
1. com.aspose.ocr.NotifierFactory.blockNotifier method can be used to create the notifier that causes an event on each recognized text block.
1. com.aspose.ocr.NotifierFactory.pageNotifier method can be used to create the notifier that causes an event when a page from a multipage document is recognized.

Process to enable the notifications is same for each type of the INotifier as elaborated in below mentioned simple steps.

1. Setup OcrEngine to [perform OCR operation on an image](/ocr/java/performing-ocr-on-an-image-html/).
1. Before calling the OcrEngine.process, call the appropriate static method exposed by NotifierFactory class to get an instance of INotifier.
1. Handle the INotifier.Elapsed event and write the delegate to get the recognized symbol/word/line/block/page.
1. Use the OcrEngine.addNotifier method to add the word processor to OcrEngine.
1. Call the OcrEngine.process method to start the image scan.

Following code snippet enables the block level notifications for the OcrEngine.
#### **Java**
{{< gist "aspose-ocr" "c7aaffa2d16d4485b849" "Examples-src-main-java-com-aspose-ocr-examples-Articles-UsageOfNotifierFactoryClass-UsageOfNotifierFactoryClass.java" >}}
