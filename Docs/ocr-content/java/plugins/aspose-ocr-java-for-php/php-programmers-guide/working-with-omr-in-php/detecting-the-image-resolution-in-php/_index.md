---
title: Detecting the Image Resolution in PHP
type: docs
weight: 10
url: /java/detecting-the-image-resolution-in-php/
---

## **Aspose.OCR - Detecting the Image Resolution**
To Detect the Image Resolution using **Aspose.OCR Java for PHP**, simply invoke **DetectImageResolution** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 # Initialize a string with template file location

$template_file=$dataDir."template.amr";

\# Initialize a string with scanned image file location

$image_file=$dataDir."sample_omr.jpg";

\# Create an instance of OmrTemplate class and load the template using the factory method Load

$omrTemplate=new OmrTemplate();

$omrTemplate=$omrTemplate->load($template_file);

\# Create an instance of OmrImage class and load the template using the factory method Load

$omrImage=new OmrImage();

$omrImage = $omrImage->load($image_file);

\# Set the auto image resolution detection property

$omrImage->setAutoDetectResolution(true);

\# Create an instance of OmrEngine class

$engine = new OmrEngine($omrTemplate);

\# Extract the OMR data

$ary=array($omrImage);

$result = $engine->extractData($ary);

\# Get page data of extracted data

$pages = $result->getPageData();

$index = 0;

\# Iterate over the pages and display the data

foreach($pages as $page) {

$index += 1;

print "------Page: " . (string)$index;

$keys = $page->keySet();

$keys = (string)$keys;

// $keys = $keys(1, sizeof($keys) - 2);

$keys = split(",",$keys);

foreach ($keys as $key) {

$value = $page->get($key);

print "key: ".(string)$key.PHP_EOL;

print "value: ".(string)$value.PHP_EOL;

}

}

{{< /highlight >}}
## **Download Running Code**
Download **Detecting the Image Resolution (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOMR/DetectImageResolution.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOMR/DetectImageResolution.php)
