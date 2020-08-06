---
title: Aspose.OCR Java For Ruby
type: docs
weight: 10
url: /java/aspose-ocr-java-for-ruby/
---

## **Introduction**
### **Rjb - Ruby Java Bridge**
RJB is a bridge program that connect between Ruby and Java with Java Native Interface. Rake + Rjb is the more powerful and useful build tool than both Maven and Ant. You can test your Java business logic class itself with Rjb's mock. It helps to migrate Struts's Model Object into your RoR application. But beware to buildSwing application, Ruby (and Rjb) doesn't consider JVM's native threads handling.
### **Aspose.OCR for Java**
Aspose.OCR for Java is an optical character & marker recognition component allowing the programmers to add OCR & OMR technology into their Java applications quickly and easily.

OMR features can be used to process questionnaires, ballots, educational tests and ordering sheets, where the documents to be processed are filled in by hand, and scanned images of such forms are used for marker recognition.
### **Aspose.OCR Java for Ruby**
Project Aspose.OCR Java for Ruby shows how different tasks can be performed using Aspose.OCR Java APIs in Ruby. This project is aimed to provide useful examples for Ruby developers who want to utilize Aspose.OCR for Java in their Ruby Projects using Rjb (Ruby Java Bridge).
## **System Requirements and Supported Platforms**
### **System Requirements**
**Following are the system requirements to use Aspose.OCR Java for Ruby:**

- Rjb Gem is configured
- Downloaded Aspose.OCR component
### **Supported Platforms**
**Following are the supported platforms:**

- Ruby 2.2.x or above and respective DevKit.
- Java 1.5 or above
## **Downloads**
### **Download Required Libraries**
Download required libraries mentioned below. These are the required for executing Aspose.OCR Java for Ruby examples.

- [Aspose.OCR for Java Component](http://www.aspose.com/community/files/72/java-components/aspose.ocr-for-java/default.aspx)
### **Download Examples from Social Coding Sites**
Following releases of running examples are available to download on below mentioned social coding sites:

**GitHub**

- [Aspose.OCR Java for Ruby](https://github.com/aspose-ocr/Aspose.OCR-for-Java/tree/master/Plugins/Aspose_OCR_Java_for_Ruby)
## **Installation And Usage**
### **Installing**
It is very simple and easy to install Aspose.OCR Java for Ruby gem, please follow these simple steps:

1. Run following command. 

{{< highlight java >}}

 $ gem install aspose-ocrjava

{{< /highlight >}}

1. Download required Aspose.OCR for Java Component from following link.
   <http://www.aspose.com/community/files/72/java-components/aspose.ocr-for-java/default.aspx>
1. Create "jars" folder at root of the Aspose.OCR Java for Ruby gem and copy downloaded component into it.
### **Using**
Include the required files to recognize text.

{{< highlight java >}}

 require File.dirname(File.dirname(File.dirname(__FILE__))) + '/lib/aspose-ocrjava'

include Asposeocrjava

include Asposeocrjava::RecognizeText

initialize_aspose_ocr

{{< /highlight >}}

Let's understand the above code.

1. The first line makes sure that the Aspose.OCR is loaded and available.
1. Include the files that are required to access the Aspose.OCR.
1. Initialize the libraries. The aspose JAVA classes are loaded from the path provided in the aspose.yml file
## **Support, Extend and Contribute**
### **Support**
From the very first days of Aspose, we knew that just giving our customers good products would not be enough. We also needed to deliver good service. We are developers ourselves and understand how frustrating it is when a technical issue or a quirk in the software stops you from doing what you need to do. We're here to solve problems, not create them.

This is why we offer free support. Anyone who uses our product, whether they have bought them or are using an evaluation, deserves our full attention and respect.

You can log any issues or suggestions related to Aspose.OCR Java for Ruby using any of the following platforms:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/issues)
### **Extend and Contribute**
Aspose.OCR Java for Ruby is open source and its source code is available on the major social coding websites listed below. Developers are encouraged to download the source code and contribute by suggesting or adding new feature or improving the existing ones, so that others could also benefit from it.
### **Source Code**
You can get the latest source code from one of the following locations:

- [GitHub](https://github.com/aspose-ocr/Aspose.OCR-for-Java/tree/master/Plugins/Aspose_OCR_Java_for_Ruby)
## **Sample Code Examples**
**This section includes the following topics:**

- [Download and Configure Aspose.OCR in Ruby](/ocr/java/download-and-configure-aspose-ocr-in-ruby-html/)
- [Ruby Programmers Guide](/ocr/java/ruby-programmers-guide-html/)
  - [Working with OCR in Ruby](/ocr/java/working-with-ocr-in-ruby-html/)
    - [Applying Correction Filters in Ruby](/ocr/java/applying-correction-filters-in-ruby-html/)
    - [Extracting Text from Part of an Image in Ruby](/ocr/java/extracting-text-from-part-of-an-image-in-ruby-html/)
    - [Get Text Part Hierarchy of Recognized Text in Ruby](/ocr/java/get-text-part-hierarchy-of-recognized-text-in-ruby-html/)
    - [Load Image from URL to Perform OCR in Ruby](/ocr/java/load-image-from-url-to-perform-ocr-in-ruby-html/)
    - [Performing OCR on an Image in Ruby](/ocr/java/performing-ocr-on-an-image-in-ruby-html/)
    - [Perform OCR Operation on a Multipage TIFF in Ruby](/ocr/java/perform-ocr-operation-on-a-multipage-tiff-in-ruby-html/)
    - [Read the Part Information of Recognized Text in Ruby](/ocr/java/read-the-part-information-of-recognized-text-in-ruby-html/)
    - [Setting OcrEngine to Recognize Only White Listed Characters in Ruby](/ocr/java/setting-ocrengine-to-recognize-only-white-listed-characters-in-ruby-html/)
    - [Setting the OcrEngine to Automatically Correct the Spellings in Ruby](/ocr/java/setting-the-ocrengine-to-automatically-correct-the-spellings-in-ruby-html/)
    - [Setting the OcrEngine to Automatically Detect the Reading Order in Ruby](/ocr/java/setting-the-ocrengine-to-automatically-detect-the-reading-order-in-ruby-html/)
    - [Setting the OcrEngine to Automatically Detect the Text Blocks in Ruby](/ocr/java/setting-the-ocrengine-to-automatically-detect-the-text-blocks-in-ruby-html/)
    - [Setting the OcrEngine to Ignore Non-Textual Blocks in Ruby](/ocr/java/setting-the-ocrengine-to-ignore-non-textual-blocks-in-ruby-html/)
    - [Working with Different Languages in Ruby](/ocr/java/working-with-different-languages-in-ruby-html/)
  - [Working with OMR in Ruby](/ocr/java/working-with-omr-in-ruby-html/)
    - [Detecting the Image Resolution in Ruby](/ocr/java/detecting-the-image-resolution-in-ruby-html/)
    - [Extracting OMR Data from an Image in Ruby](/ocr/java/extracting-omr-data-from-an-image-in-ruby-html/)
    - [Setting Mark Threshold in Ruby](/ocr/java/setting-mark-threshold-in-ruby-html/)
    - [Setting the Resolution for OMR Image in Ruby](/ocr/java/setting-the-resolution-for-omr-image-in-ruby-html/)
- [Support, Extend and Contribute to Aspose.OCR in Ruby](/ocr/java/support-2c-extend-and-contribute-to-aspose-ocr-in-ruby-html/)
