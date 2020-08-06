---
title: Setting the Resolution for OMR Image in Ruby
type: docs
weight: 40
url: /java/setting-the-resolution-for-omr-image-in-ruby/
---

## **Aspose.OCR - Setting the Resolution for OMR Image**
To Set the Resolution for OMR Image using **Aspose.OCR Java for Ruby**, simply invoke **SetImageResolution** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize a string with template file location

image_file = data_dir + "sample_omr.jpg"

\# Create an instance of OmrImage class and load the template using the factory method Load

image = Rjb::import('com.aspose.omr.OmrImage').load(image_file)

\# Define new value of image resolution in double format

image.setResolution(210.0) # overwrites the old DPI value

\# Do processing

puts "Set image resolution."

{{< /highlight >}}
## **Download Running Code**
Download **Setting the Resolution for OMR Image (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OMR/setimageresolution.rb)
