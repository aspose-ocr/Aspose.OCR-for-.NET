---
title: Performing OCR on an Image in Ruby
type: docs
weight: 50
url: /java/performing-ocr-on-an-image-in-ruby/
---

## **Aspose.OCR - Performing OCR on an Image**
To Perform OCR on an Image using **Aspose.OCR Java for Ruby**, simply invoke **RecognizeText** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))

\# Process the image

if ocr_engine.process()

    # Display the recognized text

    puts "Text: " + ocr_engine.getText().to_string

end

{{< /highlight >}}
## **Download Running Code**
Download **Performing OCR on an Image (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/recognizetext.rb)
