---
title: Setting OcrEngine to Recognize Only White Listed Characters in Ruby
type: docs
weight: 80
url: /java/setting-ocrengine-to-recognize-only-white-listed-characters-in-ruby/
---

## **Aspose.OCR - Setting OcrEngine to Recognize Only White Listed Characters**
To Set OcrEngine to Recognize Only White Listed Characters using **Aspose.OCR Java for Ruby**, simply invoke **RecognizeWhiteListedCharacters** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Retrieve the OcrConfig of the OcrEngine object

ocr_config = ocr_engine.getConfig()

\# Set the Whitelist property to recognize numbers only

#ocr_config.setWhitelist(['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'])

\# Set the Image property by loading the image from file path location

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))

\# Set the RemoveNonText to true

ocr_engine.getConfig().setRemoveNonText(true)

\# Process the image

if ocr_engine.process()

    text = ocr_engine.getText()

    puts "Text: " + text.to_string



    expression = "(\\d+)"

    # Create a Pattern object

    pattern = Rjb::import('java.util.regex.Pattern').compile(expression)

    # Now create matcher object

    matcher = pattern.matcher(text.toString())

    if matcher.find()

        puts "Found value: " + matcher.group(0).to_string

    end

end

{{< /highlight >}}
## **Download Running Code**
Download **Setting OcrEngine to Recognize Only White Listed Characters (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/recognizewhitelistedcharacters.rb)
