---
title: Perform OCR on an image
type: docs
weight: 10
url: /cpp/perform-ocr-on-an-image/
---

## **Perform OCR on an Image**
{{% alert color="primary" %}} 

Aspose.OCR for C++ supports the English language only

{{% /alert %}} 

Aspose.OCR for C++ provides the following methods to perform OCR operation on images.

- recognize_page: Recognizing text on some page, It detects where is the paragraph or header and recognizes each of the text segments.
- recognize_line: Perform OCR operation on the image containing a single line.
### **Performing OCR on an image of a page**
Aspose.OCR provides the *recognize_page* method* *that detects where the header or paragraph is and recognizes each text segment. The *recognize_page* method takes the image path as a parameter and returns the recognized text. The following code snippet demonstrates the use of the *recognize_page* method to perform OCR on an image.

{{< gist "aspose-com-gists" "0a96b16b37da1f556e7081063782ec02" "Aspose.OCR-for-C-main-PerformOcrOnImage.cpp" >}}
### **Performing OCR on an image of a line**
The following code snippet demonstrates the use of the *recognize_line* method to perform OCR operation on the image containing a single line.

{{< gist "aspose-com-gists" "0a96b16b37da1f556e7081063782ec02" "Aspose.OCR-for-C-main-RecognizeLine.cpp" >}}
