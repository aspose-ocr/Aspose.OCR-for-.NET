---
title: Applying Correction Filters in PHP
type: docs
weight: 10
url: /java/applying-correction-filters-in-php/
---

## **Aspose.OCR - Applying Correction Filters**
To Apply Correction Filters using **Aspose.OCR Java for PHP**, simply invoke **ApplyCorrectionFilters** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream = new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Set filters

\# Create CorrectionFilters collection

$filters = new CorrectionFilters();

\# Initialize Median filter

$filter = new MedianFilter(5);

$filters->add($filter);

\# Create Gaussian Blur filter

$filter = new GaussBlurFilter();

$filters->add($filter);

\# Create Noise Removal filter

$filter = new RemoveNoiseFilter();

$filters->add($filter);

\# Assign collection to OcrEngine

$ocr_engine->getConfig()->setCorrectionFilters($filters);

\# Perform OCR operation

$ocr_engine->process();

print "Whole result is: " . (string)$ocr_engine->getText().PHP_EOL;

{{< /highlight >}}
## **Download Running Code**
Download **Applying Correction Filters (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/ApplyCorrectionFilters.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/ApplyCorrectionFilters.php)
