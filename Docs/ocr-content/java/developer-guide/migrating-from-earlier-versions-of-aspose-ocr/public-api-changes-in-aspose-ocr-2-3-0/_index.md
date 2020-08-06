---
title: Public API Changes in Aspose.OCR 2.3.0
type: docs
weight: 30
url: /java/public-api-changes-in-aspose-ocr-2-3-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.2.0 to 2.3.0, that may be of interest to module and application developers. It includes not only new and updated public methods, [added classes etc.](/ocr/java/public-api-changes-in-aspose-ocr-2-3-0-html/) and [removed classes etc.](/ocr/java/public-api-changes-in-aspose-ocr-2-3-0-html/), but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
## **Added Classes, Methods**
### **Class NotifierFactory Added**
The com.aspose.ocr.NotifierFactory class allows to add notifiers for the OcrEngine. com.aspose.ocr.NotifierFactory class can be used to get notifications about any recognized symbol, word, block, line or page.

**Java**

{{< highlight csharp >}}

 OcrEngine ocrEngine = new OcrEngine();

ocrEngine.setImage(ImageStream.fromFile(imageFileName));

final int[] totalWords = { 0 };

INotifier processorWord = NotifierFactory.wordNotifier();

processorWord.Elapsed.add( new NotifierHandler() {

  public void invoke(Object sender, IRecognizedText recognizedText)

  {

    totalWords[0]++;

  }

});

ocrEngine.addNotifier(processorWord);

ocrEngine.process();

{{< /highlight >}}
### **Method SymbolNotifier Added**
The com.aspose.ocr.NotifierFactory.symbolNotifier method can be used to create the notifier that causes an event on each recognized symbol.
### **Method WordNotifier Added**
The com.aspose.ocr.NotifierFactory.wordNotifier method can be used to create the notifier that causes an event on each recognized word.
### **Method LineNotifier Added**
The com.aspose.ocr.NotifierFactory.lineNotifier method can be used to create the notifier that causes an event on each recognized line.
### **Method BlockNotifier Added**
The com.aspose.ocr.NotifierFactory.blockNotifier method can be used to create the notifier that causes an event on each recognized text block.
### **Method PageNotifier Added**
The com.aspose.ocr.NotifierFactory.pageNotifier method can be used to create the notifier that causes an event when a page from a multipage document is recognized.
## **Removed Classes, Properties, Methods**
### **Class Notifier Removed**
The com.aspose.ocr.Notifier class has been replaced by the com.aspose.ocr.NotifierFactory class that can now be used to add notifiers for the OcrEngine.
### **Class DictionaryReaderCreator Removed**
The com.aspose.ocr.DictionaryReaderCreator class has been removed because it was not in use.
### **Class IDictionaryReader Removed**
The com.aspose.ocr.IDictionaryReader class has been removed because it was not in use.
### **Method Notifier.symbol Removed**
The com.aspose.ocr.Notifier.symbol method has been replaced by the com.aspose.ocr.NotifierFactory.symbolNotifier method.
### **Method Notifier.word Removed**
The com.aspose.ocr.Notifier.word method has been replaced by the com.aspose.ocr.NotifierFactory.wordNotifier method.
### **Method Notifier.block Removed**
The com.aspose.ocr.Notifier.block method has been replaced by the com.aspose.ocr.NotifierFactory.blockNotifier method.
### **Method Notifier.page Removed**
The com.aspose.ocr.Notifier.page method has been replaced by the com.aspose.ocr.NotifierFactory.pageNotifier method.
### **Method DictionaryReaderCreator.getOpenOfficeDictionaryReader Removed**
The com.aspose.ocr.DictionaryReaderCreator.getOpenOfficeDictionaryReader method has been removed because it was not in use.
