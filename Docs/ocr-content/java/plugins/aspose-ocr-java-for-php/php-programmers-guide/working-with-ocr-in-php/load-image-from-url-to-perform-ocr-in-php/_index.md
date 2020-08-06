---
title: Load Image from URL to Perform OCR in PHP
type: docs
weight: 40
url: /java/load-image-from-url-to-perform-ocr-in-php/
---

## **Aspose.OCR - Load Image from URL to Perform OCR**
To Load Image from URL to Perform OCR using **Aspose.OCR Java for PHP**, simply invoke **LoadImageFromUrl** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from remote location

$imageStream=new ImageStream();

$ocr_engine->setImage($imageStream->fromUrl("http://cdn.aspose.com/tmp/ocr-sample.bmp"));

\# Process the image

if ($ocr_engine->process()) {

\# Display the recognized text

print "Text: " . (string)$ocr_engine->getText().PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Load Image from URL to Perform OCR (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/LoadImageFromUrl.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/LoadImageFromUrl.php)
