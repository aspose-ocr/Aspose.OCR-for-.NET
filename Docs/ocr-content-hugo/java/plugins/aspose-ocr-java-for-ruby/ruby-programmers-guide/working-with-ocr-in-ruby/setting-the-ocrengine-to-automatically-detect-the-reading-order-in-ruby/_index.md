---
title: Setting the OcrEngine to Automatically Detect the Reading Order in Ruby
type: docs
weight: 100
url: /java/setting-the-ocrengine-to-automatically-detect-the-reading-order-in-ruby/
---

## **Aspose.OCR - Setting the OcrEngine to Automatically Detect the Reading Order**
To Set the OcrEngine to Automatically Detect the Reading Order using **Aspose.OCR Java for Ruby**, simply invoke **DetectReading** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))

\# Set the DetectReadingOrder to true

ocr_engine.getConfig().setDetectReadingOrder(true)

\# Process the image

if ocr_engine.process()

    # Display the result

    puts "Text: " + ocr_engine.getText().to_string

end

{{< /highlight >}}
## **Download Running Code**
Download **Setting the OcrEngine to Automatically Detect the Reading Order (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/detectreading.rb)
