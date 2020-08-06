---
title: Performing OCR on an Image
type: docs
weight: 20
url: /java/performing-ocr-on-an-image/
---

## **Performing OCR on an Image**
{{% alert color="primary" %}} 

Aspose.OCR for Java provides the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class to perform OCR operation on images. The [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class only requires setting the [Image](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#setImage\(com.aspose.ocr.IImageStream\)) property for the English language as English is the default language. Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).

{{% /alert %}} 
### **Performing OCR on an Image steps**
Here are the simple steps to perform the OCR operation.

1. Create an instance of [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) and initialize it using the default constructor.
1. Set the image file on which OCR is to be performed using the [OcrEngine.Image](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#setImage\(com.aspose.ocr.IImageStream\)) property.
1. Call the [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method to perform OCR on the whole image.
1. If [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method returns **true**, get the recognized text with the [OcrEngine.Text](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#getText\(\)) property.
#### **Programming Sample**
Below provided code snippet demonstrates the usage of [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class as discussed in above-mentioned steps.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-PerformOCROnImage-PerformOCROnImage.java" >}}
## **Perform OCR Operation on a Multipage TIFF**
Aspose.OCR APIs provide the functionality to perform the OCR operation on a multipage TIFF containing several frames/pages in a single run. This article describes the usage of Aspose.OCR for Java API to accomplish this task with minimum source code statements as demonstrated below.
### **Performing OCR on a Multipage TIFF steps**
Performing the OCR operation on a multipage TIFF image is more or less the same as described in the article [Performing OCR on an Image](/ocr/java/performing-ocr-on-an-image-html/) with two main differences as detailed below.

1. Before calling the [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method, we need to tell the API to process all the available pages of the input TIFF image by using the [OcrEngine.ProcessAllPages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#setProcessAllPages\(boolean\)) property. Setting the aforesaid property to **true** directs the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) to process all pages when [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method is called.
1. After calling the [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method, retrieve the [Page](https://apireference.aspose.com/java/ocr/com.aspose.ocr/Page) collection using the [OcrEngine.Pages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#getPages\(\)) property, where each individual page contains the recognized text from an individual TIFF page/frame.

The [OcrEngine.Pages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#getPages\(\)) property has to be accessed after calling the [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method otherwise it will cause the [OcrException](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrException).

Below provided code snippet demonstrates how to process multipage TIFF using Aspose.OCR for Java API.
#### **Programming sample**
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-PerformingOCRonMultipageTIFF-PerformingOCRonMultipageTIFF.java" >}}
## **Extracting Text from Part of an Image**
Aspose.OCR for Java provides [OcrConfig](https://apireference.aspose.com/java/ocr/com.aspose.ocr/ocrconfig) class that can be used to extract the text from a specific part of the image document. The [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class requires setting the [OcrEngine.Image](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#setImage\(com.aspose.ocr.IImageStream\)) property and adding custom recognition blocks to the [OcrConfig](https://apireference.aspose.com/java/ocr/com.aspose.ocr/ocrconfig) class.

{{% alert color="primary" %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).

{{% /alert %}} 
### **Getting Values to Define Recognition Block**
**Text Recognition Block** can be created using [CreateTextBlock](https://apireference.aspose.com/java/ocr/com.aspose.ocr/RecognitionBlock#createTextBlock\(int,%20int,%20int,%20int\)) method. It takes four parameters namely:

1. X – Coordinates
1. Y – Coordinates
1. The width of the Area
1. The height of the Area

There are different software that provides the information about the **X, Y** Coordinates, **Width and Height** of the area selected on the image. Microsoft Paint and TechSmith Snagit are examples of such software. If we consider MS Paint software then following are the steps to get the above-mentioned information:

- Open the image in MS Paint
- Pick the Selection Tool from Home tab on the top.

This tool will help you to select the part of the image.

- While using Selection Tool, look at the left down corner on the **Status Bar**. You will be able to find the **X, Y** Coordinates.
  The very next will be the **Width, Height** information of the selected area on the image.
### **Extracting Text from Custom Recognition Block**
To run OCR on an image using the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class:

1. Create an instance of [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) and initialize it using the default constructor.
1. Set the image file using the [OcrEngine.Image](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#setImage\(com.aspose.ocr.IImageStream\)) property.
1. Set the start point, width and height of the recognition block using the [OcrConfig.addRecognitionBlock](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#addRecognitionBlock\(com.aspose.ocr.IRecognitionBlock\)) method.
1. Set the [OcrConfig.DetectTextRegions](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OCRConfig#setDetectTextRegions\(boolean\)) property to **false** so that [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) could ignore everything else on the image.
1. Call the [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method to perform OCR operation.
1. If [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) returns **true**, get the block information from the [OcrEngine.Text.PartsInfo](https://apireference.aspose.com/java/ocr/com.aspose.ocr/IRecognizedText#getPartsInfo\(\)) property.

The sample code given below shows how to use the steps discussed above to perform OCR operation on different parts of an image.
#### **Programming Sample**
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-ExtractingTextfromPartofanImage-ExtractingTextfromPartofanImage.java" >}}
## **Load Image from URL to Perform OCR**
Aspose.OCR for Java provides the [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) class to perform OCR operation on images that may be available locally or remotely. This article will provide information about how an image can be loaded using a URL.
### **Performing OCR on an Image from URL**
Here are the simple steps to perform the OCR operation.

1. Create an instance of [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) and initialize it using the default constructor.
1. Set the URL from which image is to be downloaded and OCR is to be performed using the [OcrEngine.Image](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#setImage\(com.aspose.ocr.IImageStream\)) property.
1. Call the [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method to perform OCR.
1. If [OcrEngine.process()](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method returns **true**, get the recognized text with the [OcrEngine.Text](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#getText\(\)) property.

Below provided code snippet demonstrates how an image can be loaded from a URL.
#### **Programming Sample**
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-LoadImagefromURLtoPerformOCR-LoadImagefromURLtoPerformOCR.java" >}}
