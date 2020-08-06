---
title: Extracting Text from Part of an Image in PHP
type: docs
weight: 20
url: /java/extracting-text-from-part-of-an-image-in-php/
---

## **Aspose.OCR - Extracting Text from Part of an Image**
To Extract Text from Part of an Image using **Aspose.OCR Java for PHP**, simply invoke **ExtractTextFromPartOfImage** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Clear notifier list

$ocr_engine->clearNotifies();

\# Clear recognition blocks

$ocr_engine->getConfig()->clearRecognitionBlocks();

\# Add 2 rectangle blocks to user defined recognition blocks

$recognitionBlock = new RecognitionBlock();

$ocr_engine->getConfig()->addRecognitionBlock($recognitionBlock->createTextBlock(52, 48, 67, 74));

$ocr_engine->getConfig()->addRecognitionBlock($recognitionBlock->createTextBlock(100, 46, 38, 46));

\# Ignore everything else on the image other than the user defined recognition blocks

$ocr_engine->getConfig()->setDetectTextRegions(false);

\# Set Image property by loading an image from file path

$imageStream = new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Run recognition process

if ($ocr_engine->process()) {

\# Retrieve an array of recognized text by parts

$text = $ocr_engine->getText()->getPartsInfo();

\# Iterate over the text parts

$i=0;

while ($i < sizeof($text)){

$info = $text[$i];

\# Display part information

print "Block: " . (string)$info->getBox() . " Text: " . (string)$info->getText().PHP_EOL;

$i+= 1;

}

}

{{< /highlight >}}
## **Download Running Code**
Download **Extracting Text from Part of an Image (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/ExtractTextFromPartOfImage.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/ExtractTextFromPartOfImage.php)
