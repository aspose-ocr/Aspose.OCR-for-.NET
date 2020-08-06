---
title: Applying Correction Filters
type: docs
weight: 10
url: /java/applying-correction-filters/
---

## **Applying Correction Filters**
{{% alert color="primary" %}} 

In image recognition, we often need to perform some kind of noise reduction & corrections processes on an image. Such noise reduction is a typical pre-processing step to improve the OCR results. Using Aspose.OCR we can apply the following correction filters for improving recognition accuracy:

- [BlurFilter](https://apireference.aspose.com/java/ocr/com.aspose.ocr.filters/BlurFilter) - applies a simple blur to the image.
- [GaussBlurFilter](https://apireference.aspose.com/java/ocr/com.aspose.ocr.filters/GaussBlurFilter) - applies a [Gaussian blur](https://en.wikipedia.org/wiki/Gaussian_blur) with a default radius of 3 pixels.
- [MedianFilter](https://apireference.aspose.com/java/ocr/com.aspose.ocr.filters/MedianFilter) - applies a [median filter](https://en.wikipedia.org/wiki/Median_filter) with a 3-pixel radius, by default. Median filters are good at keeping edges while removing noise.

{{% /alert %}} 

Languages other than English also requires loading the language-specific resource using the [LanguageFactory.load](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageFactory#load\(java.lang.String\)) method and adding it to the [LanguageContainer](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer) using the [addLanguage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/LanguageContainer#addLanguage\(com.aspose.ocr.ILanguage\)) method. Please check the detailed article on [Working with Different Languages](/ocr/java/working-with-different-languages-html/).
### **Programming Sample**
The sample code below shows how to use a correction filter before running the document recognition process.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-ApplyingCorrectionFilters-ApplyingCorrectionFilters.java" >}}
