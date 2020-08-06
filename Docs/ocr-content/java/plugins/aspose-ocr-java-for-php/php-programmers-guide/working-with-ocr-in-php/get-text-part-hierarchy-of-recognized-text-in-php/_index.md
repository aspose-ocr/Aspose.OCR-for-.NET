---
title: Get Text Part Hierarchy of Recognized Text in PHP
type: docs
weight: 30
url: /java/get-text-part-hierarchy-of-recognized-text-in-php/
---

## **Aspose.OCR - Get Text Part Hierarchy of Recognized Text**
To Get Text Part Hierarchy of Recognized Text using **Aspose.OCR Java for PHP**, simply invoke **GetTextPartHierarchyOfText** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize an instance of OcrEngine

$ocr_engine = new OcrEngine();

\# Set the Image property by loading the image from file path location

$imageStream=new ImageStream();

$ocr_engine->setImage($imageStream->fromFile($dataDir . 'ocr.png'));

\# Process the image

if ($ocr_engine->process()) {

\# Retrieve the first block of the recognized text part

$first_block = $ocr_engine->getText()->getPartsInfo()[0];

\# Get the children of the first block that will the the lines in the block

$lines_of_first_block = $first_block->getChildren();

\# Retrieve the fist line from the collection of lines

$first_line = $lines_of_first_block[0];

\# Display the level of line

print $first_line->getLevel();

\# Retrieve the fist word from the collection of words

$first_word = $first_line->getChildren()[0];

\# Display the level of word

print $first_word->getLevel();

\# Retrieve the fist character from the collection of characters

print $first_character = $first_word->getChildren()[0];

\# Display the level of character

print $first_character->getLevel().PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Get Text Part Hierarchy of Recognized Text (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOCR/GetTextPartHierarchyOfText.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOCR/GetTextPartHierarchyOfText.php)
