---
title: Public API Changes in Aspose.OCR 2.3.0
type: docs
weight: 40
url: /net/public-api-changes-in-aspose-ocr-2-3-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.2.0 to 2.3.0, that may be of interest to module and application developers. It includes not only new and updated public methods, [added classes etc.](/ocr/net/public-api-changes-in-aspose-ocr-2-3-0-html/) and [removed classes etc.](/ocr/net/public-api-changes-in-aspose-ocr-2-3-0-html/), but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
## **Added Classes, Methods**
### **Class NotifierFactory Added**
The Aspose.OCR.NotifierFactory class allows to add notifiers for the OcrEngine. Aspose.OCR.NotifierFactory class can be used to get notifications about any recognized symbol, word, block, line or page.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Image = ImageStream.FromFile("sample document.png");

INotifier processorWord = NotifierFactory.WordNotifier();

processorWord.Elapsed += delegate

{

    Console.WriteLine("A word was recognized: " + processorWord.Text);

};

ocr.AddNotifier(processorWord);

ocr.Process();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Private ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("sample document.png")

Dim processorWord As INotifier = NotifierFactory.WordNotifier()

AddHandler processorWord.Elapsed, AddressOf [delegate]

	Console.WriteLine("A word was recognized: " & processorWord.Text)

ocr.AddNotifier(processorWord)

ocr.Process()

{{< /highlight >}}
### **Method SymbolNotifier Added**
The Aspose.OCR.NotifierFactory.SymbolNotifier method can be used to create the notifier that causes an event on each recognized symbol.
### **Method WordNotifier Added**
The Aspose.OCR.NotifierFactory.WordNotifier method can be used to create the notifier that causes an event on each recognized word.
### **Method LineNotifier Added**
The Aspose.OCR.NotifierFactory.LineNotifier method can be used to create the notifier that causes an event on each recognized line.
### **Method BlockNotifier Added**
The Aspose.OCR.NotifierFactory.BlockNotifier method can be used to create the notifier that causes an event on each recognized text block.
### **Method PageNotifier Added**
The Aspose.OCR.NotifierFactory.PageNotifier method can be used to create the notifier that causes an event when a page from a multipage document is recognized.
## **Removed Classes, Properties, Methods**
### **Class Notifier Removed**
The Aspose.OCR.Notifier class has been replaced by the Aspose.OCR.NotifierFactory class that can now be used to add notifiers for the OcrEngine.
### **Class DictionaryReaderCreator Removed**
The Aspose.OCR.DictionaryReaderCreator class has been removed because it was not in use.
### **Class IDictionaryReader Removed**
The Aspose.OCR.IDictionaryReader class has been removed because it was not in use.
### **Method Notifier.Symbol Removed**
The Aspose.OCR.Notifier.Symbol method has been replaced by the Aspose.OCR.NotifierFactory.SymbolNotifier method.
### **Method Notifier.Word Removed**
The Aspose.OCR.Notifier.Word method has been replaced by the Aspose.OCR.NotifierFactory.WordNotifier method.
### **Method Notifier.Block Removed**
The Aspose.OCR.Notifier.Block method has been replaced by the Aspose.OCR.NotifierFactory.BlockNotifier method.
### **Method Notifier.Page Removed**
The Aspose.OCR.Notifier.Page method has been replaced by the Aspose.OCR.NotifierFactory.PageNotifier method.
### **Method DictionaryReaderCreator.GetOpenOfficeDictionaryReader Removed**
The Aspose.OCR.DictionaryReaderCreator.GetOpenOfficeDictionaryReader method has been removed because it was not in use.
