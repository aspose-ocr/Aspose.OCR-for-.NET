---
title: Working with Different Languages in Ruby
type: docs
weight: 130
url: /java/working-with-different-languages-in-ruby/
---

## **Aspose.OCR - Working with Different Languages**
To work with Different Languages using **Aspose.OCR Java for Ruby**, simply invoke **WorkWithDifferentLanguages** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'spanish.png'))

\# Clear the default language (English)

ocr_engine.getLanguageContainer().clear()

\# Load the resources of the language from file path location or an instance of InputStream

ocr_engine.getLanguageContainer().addLanguage(Rjb::import('com.aspose.ocr.LanguageFactory').load(data_dir + "SpanishLanguageResources.zip"))

\# Process the image

if ocr_engine.process()

    # Display the recognized text

    puts "Text: " + ocr_engine.getText().to_string

end

{{< /highlight >}}
## **Download Running Code**
Download **Working with Different Languages (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/workwithdifferentlanguages.rb)
