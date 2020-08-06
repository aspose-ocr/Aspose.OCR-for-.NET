---
title: Setting the OcrEngine to Automatically Detect the Text Blocks in PHP
type: docs
weight: 110
url: /java/setting-the-ocrengine-to-automatically-detect-the-text-blocks-in-php/
---

## **Aspose.OCR - Setting the OcrEngine to Automatically Detect the Text Blocks**
To Set the OcrEngine to Automatically Detect the Text Blocks using **Aspose.OCR Java for PHP**, simply invoke **DetectTextBlocks** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream=new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Set the DetectTextRegions to true

$ocr_engine->getConfig()->setDetectTextRegions(true);

\# Process the image

if ($ocr_engine->process()){

\# Display the result

print "Text: " . (string)$ocr_engine->getText().PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Setting the OcrEngine to Automatically Detect the Text Blocks (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/DetectTextBlocks.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/DetectTextBlocks.php)
