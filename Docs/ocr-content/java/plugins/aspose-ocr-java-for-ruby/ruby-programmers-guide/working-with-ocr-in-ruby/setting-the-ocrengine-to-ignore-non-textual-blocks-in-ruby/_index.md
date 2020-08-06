---
title: Setting the OcrEngine to Ignore Non-Textual Blocks in Ruby
type: docs
weight: 120
url: /java/setting-the-ocrengine-to-ignore-non-textual-blocks-in-ruby/
---

## **Aspose.OCR - Setting the OcrEngine to Ignore Non-Textual Blocks**
To Set the OcrEngine to Ignore Non-Textual Blocks using **Aspose.OCR Java for Ruby**, simply invoke **IgnoreNonTextualBlocks** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))

\# Set the RemoveNonText to true

ocr_engine.getConfig().setRemoveNonText(true)

\# Process the image

if ocr_engine.process()

    # Display the result

    puts "Text: " + ocr_engine.getText().to_string

end

{{< /highlight >}}
## **Download Running Code**
Download **Setting the OcrEngine to Ignore Non-Textual Blocks (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/ignorenontextualblocks.rb)
