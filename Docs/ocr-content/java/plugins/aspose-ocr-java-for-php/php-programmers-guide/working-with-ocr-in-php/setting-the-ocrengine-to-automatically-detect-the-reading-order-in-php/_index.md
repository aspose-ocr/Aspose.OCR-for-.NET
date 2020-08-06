---
title: Setting the OcrEngine to Automatically Detect the Reading Order in PHP
type: docs
weight: 100
url: /java/setting-the-ocrengine-to-automatically-detect-the-reading-order-in-php/
---

## **Aspose.OCR - Setting the OcrEngine to Automatically Detect the Reading Order**
To Set the OcrEngine to Automatically Detect the Reading Order using **Aspose.OCR Java for PHP**, simply invoke **DetectReading** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream=new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Set the DetectReadingOrder to true

$ocr_engine->getConfig()->setDetectReadingOrder(true);

\# Process the image

if ($ocr_engine->process()) {

\# Display the result

print "Text: " . (string)$ocr_engine->getText().PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Setting the OcrEngine to Automatically Detect the Reading Order (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/DetectReading.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/DetectReading.php)
