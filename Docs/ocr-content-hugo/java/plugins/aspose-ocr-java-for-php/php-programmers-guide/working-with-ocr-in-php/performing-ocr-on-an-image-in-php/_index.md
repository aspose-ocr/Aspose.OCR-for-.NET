---
title: Performing OCR on an Image in PHP
type: docs
weight: 50
url: /java/performing-ocr-on-an-image-in-php/
---

## **Aspose.OCR - Performing OCR on an Image**
To Perform OCR on an Image using **Aspose.OCR Java for PHP**, simply invoke **RecognizeText** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream=new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Process the image

if ($ocr_engine->process()) {

\# Display the recognized text

print "Text: " . (string)$ocr_engine->getText() . PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Performing OCR on an Image (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/PerformingOCROnAnImage.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/PerformingOCROnAnImage.php)
