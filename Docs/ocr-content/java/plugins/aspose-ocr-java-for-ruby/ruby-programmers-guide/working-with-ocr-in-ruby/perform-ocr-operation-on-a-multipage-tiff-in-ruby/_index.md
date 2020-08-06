---
title: Perform OCR Operation on a Multipage TIFF in Ruby
type: docs
weight: 60
url: /java/perform-ocr-operation-on-a-multipage-tiff-in-ruby/
---

## **Aspose.OCR - Perform OCR Operation on a Multipage TIFF**
To Perform OCR Operation on a Multipage TIFF using **Aspose.OCR Java for Ruby**, simply invoke **MultipageTiff** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'

\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'multipage.tiff'))

\# Set OcrEngine.ProcessAllPages to true in order to process all pages of TIFF in single run

ocr_engine.setProcessAllPages(true)

\# Process the image

if ocr_engine.process()

    # Retrieve the list of Pages

    pages = ocr_engine.getPages()

    pages.each do |page|

        puts "Text: " + page.getPageText().to_string

    end

end

{{< /highlight >}}
## **Download Running Code**
Download **Perform OCR Operation on a Multipage TIFF (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/multipagetiff.rb)
