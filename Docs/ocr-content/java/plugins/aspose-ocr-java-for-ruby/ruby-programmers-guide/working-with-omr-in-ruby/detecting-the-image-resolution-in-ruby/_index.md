---
title: Detecting the Image Resolution in Ruby
type: docs
weight: 10
url: /java/detecting-the-image-resolution-in-ruby/
---

## **Aspose.OCR - Detecting the Image Resolution**
To Detect the Image Resolution using **Aspose.OCR Java for Ruby**, simply invoke **DetectImageResolution** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize a string with template file location

template_file = data_dir + "template.amr"

\# Initialize a string with scanned image file location

image_file = data_dir + "sample_omr.jpg"

\# Create an instance of OmrTemplate class and load the template using the factory method Load

template = Rjb::import('com.aspose.omr.OmrTemplate').load(template_file)

\# Create an instance of OmrImage class and load the template using the factory method Load

image = Rjb::import('com.aspose.omr.OmrImage').load(image_file)

\# Set the auto image resolution detection property

image.setAutoDetectResolution(true)

\# Create an instance of OmrEngine class

engine = Rjb::import('com.aspose.omr.OmrEngine').new(template)

\# Extract the OMR data

result = engine.extractData(Array[image])

\# Get page data of extracted data

pages = result.getPageData()

index = 0

\# Iterate over the pages and display the data

pages.each do |page|

    index +=1

    puts "------Page: " + index.to_s

    keys = page.keySet()

    keys = keys.to_string

    keys = keys[1, keys.length - 2]



    keys = keys.split(",")

    keys.each do |key|

        value = page.get(key)

        puts "key: " + key.to_s

        puts "value: " + value.to_s

    end

end

{{< /highlight >}}
## **Download Running Code**
Download **Detecting the Image Resolution (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OMR/detectimageresolution.rb)
