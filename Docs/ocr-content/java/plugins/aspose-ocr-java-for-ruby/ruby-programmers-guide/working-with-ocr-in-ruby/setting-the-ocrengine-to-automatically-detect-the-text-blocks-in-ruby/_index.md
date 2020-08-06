---
title: Setting the OcrEngine to Automatically Detect the Text Blocks in Ruby
type: docs
weight: 110
url: /java/setting-the-ocrengine-to-automatically-detect-the-text-blocks-in-ruby/
---

## **Aspose.OCR - Setting the OcrEngine to Automatically Detect the Text Blocks**
To Set the OcrEngine to Automatically Detect the Text Blocks using **Aspose.OCR Java for Ruby**, simply invoke **DetectTextBlocks** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))

\# Set the DetectTextRegions to true

ocr_engine.getConfig().setDetectTextRegions(true)

\# Process the image

if ocr_engine.process()

    # Display the result

    puts "Text: " + ocr_engine.getText().to_string

end

{{< /highlight >}}
## **Download Running Code**
Download **Setting the OcrEngine to Automatically Detect the Text Blocks (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/detecttextblocks.rb)
