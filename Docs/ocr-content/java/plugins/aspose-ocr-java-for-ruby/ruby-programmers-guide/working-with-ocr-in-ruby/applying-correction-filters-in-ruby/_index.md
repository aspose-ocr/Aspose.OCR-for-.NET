---
title: Applying Correction Filters in Ruby
type: docs
weight: 10
url: /java/applying-correction-filters-in-ruby/
---

## **Aspose.OCR - Applying Correction Filters**
To Apply Correction Filters using **Aspose.OCR Java for Ruby**, simply invoke **ApplyCorrectionFilters** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))

\# Set filters

\# Create CorrectionFilters collection

filters = Rjb::import('com.aspose.ocr.CorrectionFilters').new

\# Initialize Median filter

filter = Rjb::import('com.aspose.ocr.filters.MedianFilter').new(5)

filters.add(filter)

\# Create Gaussian Blur filter

filter = Rjb::import('com.aspose.ocr.filters.GaussBlurFilter').new

filters.add(filter)

\# Create Noise Removal filter

filter = Rjb::import('com.aspose.ocr.filters.RemoveNoiseFilter').new

filters.add(filter)

\# Assign collection to OcrEngine

ocr_engine.getConfig().setCorrectionFilters(filters)

\# Perform OCR operation

ocr_engine.process()

puts "Whole result is: "+ ocr_engine.getText().to_string

{{< /highlight >}}
## **Download Running Code**
Download **Applying Correction Filters (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/aspose-ocrjava/OCR/applycorrectionfilters.rb)
