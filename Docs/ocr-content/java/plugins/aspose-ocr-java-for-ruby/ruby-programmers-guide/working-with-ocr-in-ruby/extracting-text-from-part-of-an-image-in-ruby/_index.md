---
title: Extracting Text from Part of an Image in Ruby
type: docs
weight: 20
url: /java/extracting-text-from-part-of-an-image-in-ruby/
---

## **Aspose.OCR - Extracting Text from Part of an Image**
To Extract Text from Part of an Image using **Aspose.OCR Java for Ruby**, simply invoke **ExtractTextFromPartOfImage** module. Here you can see example code.

**Ruby Code**

{{< highlight ruby >}}

 data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Initialize an instance of OcrEngine

ocr_engine = Rjb::import('com.aspose.ocr.OcrEngine').new

\# Clear notifier list

ocr_engine.clearNotifies()

\# Clear recognition blocks

ocr_engine.getConfig().clearRecognitionBlocks()

\# Add 2 rectangle blocks to user defined recognition blocks

ocr_engine.getConfig().addRecognitionBlock(Rjb::import('com.aspose.ocr.RecognitionBlock').createTextBlock(52, 48, 67, 74))

ocr_engine.getConfig().addRecognitionBlock(Rjb::import('com.aspose.ocr.RecognitionBlock').createTextBlock(100, 46, 38, 46))

\# Ignore everything else on the image other than the user defined recognition blocks

ocr_engine.getConfig().setDetectTextRegions(false)

\# Set Image property by loading an image from file path

ocr_engine.setImage(Rjb::import('com.aspose.ocr.ImageStream').fromFile(data_dir + 'ocr.png'))



\# Run recognition process

if ocr_engine.process()

    # Retrieve an array of recognized text by parts

    text = ocr_engine.getText().getPartsInfo()

    # Iterate over the text parts

    i = 0

    while i < text.length

        info = text[i]

        # Display part information

        puts "Block: " + info.getBox().to_string + " Text: " + info.getText().to_s

        i +=1

    end

end

{{< /highlight >}}
## **Download Running Code**
Download **Extracting Text from Part of an Image (Aspose.OCR)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/blob/master/Plugins/Aspose_OCR_Java_for_Ruby/lib/asposeocrjava/OCR/extracttextfrompartofimage.rb)
