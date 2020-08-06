---
title: Download and Configure Aspose.OCR in Ruby
type: docs
weight: 10
url: /java/download-and-configure-aspose-ocr-in-ruby/
---

## **Download Required Libraries**
Download required libraries mentioned below. These are the required for executing Aspose.OCR Java for Ruby examples.

- [Aspose.OCR for Java Component](https://downloads.aspose.com/ocr/java)
## **Download Examples from Social Coding Sites**
Following releases of running examples are available to download on below mentioned social coding sites:

**GitHub**

- [Aspose.OCR Java for Ruby](https://github.com/aspose-ocr/Aspose.OCR-for-Java/tree/master/Plugins/Aspose_OCR_Java_for_Ruby)
## **Installing**
It is very simple and easy to install Aspose.OCR Java for Ruby gem, please follow these simple steps:

1. Run following command.

{{< highlight java >}}

 $ gem install aspose-ocrjava

{{< /highlight >}}

1. Download required Aspose.OCR for Java Component from following link.
   <https://downloads.aspose.com/ocr/java>
1. Create "jars" folder at root of the Aspose.OCR Java for Ruby gem and copy downloaded component into it.
## **Using**
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
