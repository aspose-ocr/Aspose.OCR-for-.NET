---
title: OCR Preprocessed Images
type: docs
weight: 20
url: /java/ocr-preprocessed-images/
---

{{% alert color="primary" %}} 

Since the release of Aspose.OCR for Java 2.2.0, the API provides the means to extract the preprocessed images for performance evaluation. Preprocessed images are the version of the input image that [OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) creates itself depending upon the configuration parameters set before calling the [OcrEngine.process](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine#process\(\)) method.

{{% /alert %}} 
#### **Preprocessing**
[OcrEngine](https://apireference.aspose.com/java/ocr/com.aspose.ocr/OcrEngine) performs a series of actions on the input image to make it more suitable for the OCR operation. Preprocessing steps may include all or a few of the below-mentioned steps depending upon the configurations set prior to the OCR operation.

1. Image preprocessing, e.g. noise attenuation, correction of the image orientation.
1. Image binarization, that is; converting an image of up to 256 gray levels to a black and white image.
1. Hierarchical Segmentation denotes to the recognition of page layout, detecting text areas then text paragraphs, individual lines, then segmenting lines into words, and finally words into characters.
#### **Extracting Preprocessed Images**
Aspose.OCR for Java API has exposed the [PreprocessedImages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages) class that allows the users to see how original input image changes during the OCR preprocessing. [PreprocessedImages](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages) class has the following useful properties that can retrieve the image at a particular stage of the preprocessing.

1. [BinarizedImage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages#getBinarizedImage\(\)) represents the source image after binarization and/or background correction.
1. [FilteredImage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages#getFilteredImage\(\)) represents the source image after applying user-specified [correction filters](https://docs.aspose.com/display/OCRJAVA/Applying+Correction+Filters).
1. [NonTextRemovedImage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages#getNonTextRemovedImage\(\)) represents the source image after detecting and removing the non-textual fragments such as graphics.
1. [RotatedImage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages#getRotatedImage\(\)) represents the source image after the skew correction has been applied.
1. [TextBlocksImage](https://apireference.aspose.com/java/ocr/com.aspose.ocr/PreprocessedImages#getTextBlocksImage\(\)) represents the source image after text block detection. This image contains the red rectangles around all the detected textual blocks on the source image.

All of the above-mentioned forms of the preprocessed images can be saved on the disc for performance evaluation of OCR configurations.
#### **Java**
{{< gist "aspose-com-gists" "3830491066e58e54903b3025d04e5b0c" "Examples-src-main-java-com-aspose-ocr-examples-OcrFeatures-AdvanceConfigurations-ExtractPreprocessedImages-ExtractPreprocessedImages.java" >}}

Preprocessed images can be helpful in analyzing how different configuration parameters influence the OCR performance.
