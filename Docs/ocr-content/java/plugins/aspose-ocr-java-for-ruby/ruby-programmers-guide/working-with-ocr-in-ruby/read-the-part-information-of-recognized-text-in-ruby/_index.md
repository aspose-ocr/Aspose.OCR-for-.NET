---
title: Read the Part Information of Recognized Text in Ruby
type: docs
weight: 70
url: /java/read-the-part-information-of-recognized-text-in-ruby/
---

## **Aspose.OCR - Read the Part Information of Recognized Text**
To Read the Part Information of Recognized Text using **Aspose.OCR Java for Ruby**, simply invoke **ReadPartInformationOfText** module. Here you can see example code.

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

    # Retrieve an array of recognized text by parts

    text = ocr_engine.getText().getPartsInfo()

    # Iterate over the text parts

    i = 0

    while i < text.length

        symbol = text[i]

        # Display part information

        puts "isItalic : " + symbol.getItalic().to_s

        puts "isUnderline : " + symbol.getUnderline().to_s

        puts "isBold : " + symbol.getBold().to_s

        puts "Text Color : " + symbol.getTextColor().to_string

        puts "Quality : " + symbol.getCharactersQuality().to_s

        i +=1

    end

end

{{< /highlight >}}
## **Download Running Code**
Download **Read the Part Information of Recognized Text (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/readpartinformationoftext.rb)
