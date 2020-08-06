---
title: Setting Mark Threshold in Ruby
type: docs
weight: 30
url: /java/setting-mark-threshold-in-ruby/
---

## **Aspose.OCR - Setting Global Threshold**
To Set Global Threshold using **Aspose.OCR Java for Ruby**, call **set_global_threshold** method of **SetMarkThreshold** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 def set_global_threshold()

    data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



    # Initialize a string with template file location

    template_file = data_dir + "template.amr"



    # Initialize a string with scanned image file location

    image_file = data_dir + "sample_omr.jpg"



    # Create an instance of OmrTemplate class and load the template using the factory method Load

    template = Rjb::import('com.aspose.omr.OmrTemplate').load(template_file)



    # Create an instance of OmrImage class and load the template using the factory method Load

    image = Rjb::import('com.aspose.omr.OmrImage').load(image_file)

    # Create an instance of OmrEngine class

    engine = Rjb::import('com.aspose.omr.OmrEngine').new(template)

    # Get the configurations of OmrEngine

    config = engine.getConfiguration()

    # Set fill threshold

    config.setFillThreshold(0.12)

    # Extract the OMR data

    result = engine.extractData(Array[image])

    puts "Set global threshold."

end

{{< /highlight >}}
## **Aspose.OCR - Setting Page Level Threshold**
To Set Page Level Threshold using **Aspose.OCR Java for Ruby**, call **set_page_level_threshold** method of **SetMarkThreshold** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 def set_page_level_threshold()

    data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



    # Initialize a string with template file location

    template_file = data_dir + "template.amr"



    # Initialize a string with scanned image file location

    image_file = data_dir + "sample_omr.jpg"



    # Create an instance of OmrTemplate class and load the template using the factory method Load

    template = Rjb::import('com.aspose.omr.OmrTemplate').load(template_file)



    # Create an instance of OmrImage class and load the template using the factory method Load

    image = Rjb::import('com.aspose.omr.OmrImage').load(image_file)

    # Get the first page of the template

    page = template.getPages().getItem(0)

    # Create page configurations

    page.setConfiguration(Rjb::import('com.aspose.omr.OmrConfig').new)

    # Set fill threshold

    page.getConfiguration().setFillThreshold(0.21)

    # Create an instance of OmrEngine class

    engine = Rjb::import('com.aspose.omr.OmrEngine').new(template)

    # Extract the OMR data

    result = engine.extractData(Array[image])

    puts "Set page level threshold."

end

{{< /highlight >}}
## **Download Running Code**
Download **Setting Mark Threshold (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OMR/setmarkthreshold.rb)
