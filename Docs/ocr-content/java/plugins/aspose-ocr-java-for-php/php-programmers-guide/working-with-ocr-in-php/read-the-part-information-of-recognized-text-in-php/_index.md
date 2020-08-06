---
title: Read the Part Information of Recognized Text in PHP
type: docs
weight: 70
url: /java/read-the-part-information-of-recognized-text-in-php/
---

## **Aspose.OCR - Read the Part Information of Recognized Text**
To Read the Part Information of Recognized Text using **Aspose.OCR Java for PHP**, simply invoke **ReadPartInformationOfText** module. Here you can see example code.

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

print "Text: " . (string)$ocr_engine->getText();

\# Retrieve an array of recognized text by parts

$text = $ocr_engine->getText()->getPartsInfo();

\# Iterate over the text parts

$i = 0;

while ($i < sizeof($text)) {

$symbol = $text[$i];

\# Display part information

print "isItalic : " . (string)$symbol->getItalic().PHP_EOL;

print "isUnderline : " . (string)$symbol->getUnderline().PHP_EOL;

print "isBold : " . (string)$symbol->getBold().PHP_EOL;

print "Text Color : " . (string)$symbol->getTextColor().PHP_EOL;

print "Quality : " . (string)$symbol->getCharactersQuality().PHP_EOL;

$i += 1;

}

}

{{< /highlight >}}
## **Download Running Code**
Download **Read the Part Information of Recognized Text (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/ReadPartInformationOfText.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/ReadPartInformationOfText.php)
