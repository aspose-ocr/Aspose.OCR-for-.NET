---
title: Setting Mark Threshold in PHP
type: docs
weight: 30
url: /java/setting-mark-threshold-in-php/
---

## **Aspose.OCR - Setting Global Threshold**
To Set Global Threshold using **Aspose.OCR Java for PHP**, call **set_global_threshold** method of **SetMarkThreshold** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 public static function set_global_threshold($dataDir=null){

\# Initialize a string with template file location

$template_file = $dataDir . "template.amr";

\# Initialize a string with scanned image file location

$image_file = $dataDir . "sample_omr.jpg";

\# Create an instance of OmrTemplate class and load the template using the factory method Load

$omrTemplate=new OmrTemplate();

$omrTemplate = $omrTemplate->load($template_file);

\# Create an instance of OmrImage class and load the template using the factory method Load

$omrImage=new OmrImage();

$omrImage = $omrImage->load($image_file);

\# Create an instance of OmrEngine class

$omrEngine=new OmrEngine();

$engine = new OmrEngine($omrTemplate);

\# Get the configurations of OmrEngine

$config = $engine->getConfiguration();

\# Set fill threshold

$config->setFillThreshold(0.12);

\# Extract the OMR data

$ary=array($omrImage);

$result = $engine->extractData($ary);

print "Set global threshold.".PHP_EOL;

}

{{< /highlight >}}
## **Aspose.OCR - Setting Page Level Threshold**
To Set Page Level Threshold using **Aspose.OCR Java for PHP**, call **set_page_level_threshold** method of **SetMarkThreshold** module. Here you can see example code.

**PHP Code**

{{< highlight php >}}

 public static function set_page_level_threshold($dataDir=null){

\# Initialize a string with template file location

$template_file = $dataDir . "template.amr";

\# Initialize a string with scanned image file location

$image_file = $dataDir . "sample_omr.jpg";

\# Create an instance of OmrTemplate class and load the template using the factory method Load

$omrTemplate=new OmrTemplate();

$omrTemplate = $omrTemplate->load($template_file);

\# Create an instance of OmrImage class and load the template using the factory method Load

$omrImage=new OmrImage();

$omrImage = $omrImage->load($image_file);

\# Get the first page of the template

$page = $omrTemplate->getPages()->getItem(0);

\# Create page configurations

$page->setConfiguration(new OmrConfig());

\# Set fill threshold

$page->getConfiguration()->setFillThreshold(0.21);

\# Create an instance of OmrEngine class

$engine = new OmrEngine($omrTemplate);

\# Extract the OMR data

$ary=array($omrImage);

$result = $engine->extractData($ary);

print "Set page level threshold.".PHP_EOL;

}

{{< /highlight >}}
## **Download Running Code**
Download **Setting Mark Threshold (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_PHP/src/aspose/ocr/WorkingWithOMR/SetMarkThreshold.php)
- [CodePlex](https://asposeocrjavaphp.codeplex.com/SourceControl/latest#src/aspose/ocr/WorkingWithOMR/SetMarkThreshold.php)
