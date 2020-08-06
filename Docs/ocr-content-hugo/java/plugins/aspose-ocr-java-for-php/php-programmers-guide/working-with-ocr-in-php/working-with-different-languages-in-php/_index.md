---
title: Working with Different Languages in PHP
type: docs
weight: 130
url: /java/working-with-different-languages-in-php/
---

## **Aspose.OCR - Working with Different Languages**
To work with Different Languages using **Aspose.OCR Java for PHP**, simply invoke **WorkWithDifferentLanguages** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream = new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'spanish.png'));

\# Clear the default language (English)

$ocr_engine->getLanguageContainer()->clear();

\# Load the resources of the language from file path location or an instance of InputStream

$languageFactory = new LanguageFactory();

$ocr_engine->getLanguageContainer()->addLanguage($languageFactory->load($dataDir . "SpanishLanguageResources.zip"));

\# Process the image

if ($ocr_engine->process()) {

\# Display the recognized text

print "Text: " . (string)$ocr_engine->getText().PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Working with Different Languages (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/WorkWithDifferentLanguages.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/WorkWithDifferentLanguages.php)
