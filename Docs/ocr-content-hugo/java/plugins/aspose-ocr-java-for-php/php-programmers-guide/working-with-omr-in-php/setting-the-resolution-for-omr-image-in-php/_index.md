---
title: Setting the Resolution for OMR Image in PHP
type: docs
weight: 40
url: /java/setting-the-resolution-for-omr-image-in-php/
---

## **Aspose.OCR - Setting the Resolution for OMR Image**
To Set the Resolution for OMR Image using **Aspose.OCR Java for PHP**, simply invoke **SetImageResolution** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize a string with template file location

$image_file = $dataDir . "sample_omr.jpg";

\# Create an instance of OmrImage class and load the template using the factory method Load

$omrImage=new OmrImage();

$image = $omrImage->load($image_file);

\# Define new value of image resolution in double format

$image->setResolution(210.0); # overwrites the old DPI value

\# Do processing

print "Set image resolution.".PHP_EOL;

{{< /highlight >}}
## **Download Running Code**
Download **Setting the Resolution for OMR Image (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOMR/SetImageResolution.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOMR/SetImageResolution.php)
