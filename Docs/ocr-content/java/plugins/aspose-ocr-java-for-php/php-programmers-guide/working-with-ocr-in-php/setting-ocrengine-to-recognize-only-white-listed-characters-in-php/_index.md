---
title: Setting OcrEngine to Recognize Only White Listed Characters in PHP
type: docs
weight: 80
url: /java/setting-ocrengine-to-recognize-only-white-listed-characters-in-php/
---

## **Aspose.OCR - Setting OcrEngine to Recognize Only White Listed Characters**
To Set OcrEngine to Recognize Only White Listed Characters using **Aspose.OCR Java for PHP**, simply invoke **RecognizeWhiteListedCharacters** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Retrieve the OcrConfig of the OcrEngine object

$ocr_config = $ocr_engine->getConfig();

\# Set the Whitelist property to recognize numbers only

#ocr_config.setWhitelist(['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'])

\# Set the Image property by loading the image from file path location

$imageStream = new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Set the RemoveNonText to true

$ocr_engine->getConfig()->setRemoveNonText(true);

\# Process the image

if ($ocr_engine->process()) {

$text = $ocr_engine->getText();

print "Text: " . (string)$text;

$expression = "(\\d+)";

\# Create a Pattern object

$pattern = new Pattern();

$pattern = $pattern->compile($expression);

\# Now create matcher object

$matcher = $pattern->matcher((string)$text);

if ($matcher->find()){

print "Found value: ". (string)$matcher.PHP_EOL;//->group(0);

}

}

{{< /highlight >}}
## **Download Running Code**
Download **Setting OcrEngine to Recognize Only White Listed Characters (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/RecognizeWhiteListedCharacters.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/RecognizeWhiteListedCharacters.php)
