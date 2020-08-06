---
title: Load Image from URL to Perform OCR in Ruby
type: docs
weight: 40
url: /java/load-image-from-url-to-perform-ocr-in-ruby/
---

## **Aspose.OCR - Load Image from URL to Perform OCR**
To Load Image from URL to Perform OCR using **Aspose.OCR Java for Ruby**, simply invoke **LoadImageFromUrl** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 # Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from remote location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromUrl("http://cdn.aspose.com/tmp/ocr-sample.bmp"))

\# Process the image

if ocr_engine.process()

    # Display the recognized text

    puts "Text: " + ocr_engine.getText().to_string

end

{{< /highlight >}}
## **Download Running Code**
Download **Load Image from URL to Perform OCR (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/loadimagefromurl.rb)
