---
title: Perform OCR Operation on a Multipage TIFF in PHP
type: docs
weight: 60
url: /java/perform-ocr-operation-on-a-multipage-tiff-in-php/
---

## **Aspose.OCR - Perform OCR Operation on a Multipage TIFF**
To Perform OCR Operation on a Multipage TIFF using **Aspose.OCR Java for PHP**, simply invoke **MultipageTiff** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream=new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'multipage.tiff'));

\# Set OcrEngine.ProcessAllPages to true in order to process all pages of TIFF in single run

$ocr_engine->setProcessAllPages(true);

\# Process the image

if ($ocr_engine->process()) {

\# Retrieve the list of Pages

$pages = $ocr_engine->getPages();

foreach($pages as $page) {

print "Text: " . (string)$page->getPageText().PHP_EOL;

}

}

{{< /highlight >}}
## **Download Running Code**
Download **Perform OCR Operation on a Multipage TIFF (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/MultipageTiff.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/MultipageTiff.php)
