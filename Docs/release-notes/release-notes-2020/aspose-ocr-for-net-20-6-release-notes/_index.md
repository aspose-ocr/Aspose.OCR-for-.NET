---
title: Aspose.OCR for .NET 20.6 - Release Notes
type: docs
weight: 9
url: /net/aspose-ocr-for-net-20-6-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.OCR for .NET 20.6

{{% /alert %}}

## Enhancements

- API does not need to be disposed of.
- Recognition quality improved.
- Added API support for working with streams.
- Added API support for working with recognition areas.
- Added ability to specify characters for recognition.
- Added the ability to calculate skew of the image.
- Flag for text area detection.
- Optional flag for skew correction.

## Supported Characters

|   |   |   |   |   |   |   |   |   |   |
|---|---|---|---|---|---|---|---|---|---|
| space | ! | " | # | $ | % | & | ' | ( | ) |
| * | + | , | - | . | / | 0 | 1 | 2 | 3 |
| 4 | 5 | 6 | 7 | 8 | 9 | : | ; | < | = |
| > | ? | @ | [ | \ | ] | _ | ` | { | \| |
| } | ~ | A | B | C | D | E | F | G | H |
| I | J | K | L | M | N | O | P | Q | R |
| S | T | U | V | W | X | Y | Z | a | b |
| c | d | e | f | g | h | i | j | k | l |
| m | n | o | p | q | r | s | t | u | v |
| w | x | y | z | Â | À | Á | Ã | Ä | Æ |
| Ç | È | É | Ê | Ë | Ì | Í | Î | Ï | Ñ |
| Ò | Ó | Ô | Õ | Ö | Ù | Ú | Û | Ü | ẞ |
| ß | à | á | â | ã | ä | æ | ç | è | é |
| ê | ë | ì | í | î | ï | ñ | ò | ó | ô |
| õ | ö | ù | ú | û | ü | ÿ | Œ | œ | Ÿ |

## Public API and Backwards Incompatible Changes

### New API

|**Method**|**Description**|
| :- | :- |
|AsposeOCR()|Constructor. Create an API instance.|
|AsposeOcr(string alphabet)|Constructor. Create an API instance and set of allowed characters in the alphabet.|
|float CalculateSkew(MemoryStream image)|Calculates the skew angle in degrees of text in the image. image - MemoryStream of the image.|
|float CalculateSkew(string fullPath)|Calculates the skew angle in degrees of text in the image. fullPath - path to the image.|
|string RecognizeImage(MemoryStream stream)|Recognizing image with automatic detection of text areas and detecting, correcting skew of the text. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. stream - MemoryStream of the image.|
|string RecognizeImage(string fullPath)|Recognizing image with automatic detection of text areas and detecting, correcting skew of the text. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. fullPath - path to the image.|
|string RecognizeImage(MemoryStream stream, bool detectAreas, bool autoSkew = true)|Recognizing image with or without automatic detection of text areas and correct skew of the text according to parameters. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. stream - MemoryStream of the image. detectAreas - autodetecting areas with texts. If false, the image considers as one text block. autoSkew - remove the skew image. Default - true.|string RecognizeImage(string fullPath, bool detectAreas, bool autoSkew = true)|Recognizing image with or without automatic detection of text areas and correct skew of the text according to parameters. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. fullPath - path to the image. detectAreas - autodetecting areas with texts. If false, the image considers as one text block. autoSkew - remove the skew image. Default - true.|
|List RecognizeImage(MemoryStream stream, List rects)|Recognizing text in the specified rectangles. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. Skew alignment does not occur. stream - MemoryStream of the image. rects - list of rectangles in pixels for recognizing.|
|List RecognizeImage(string fullPath, List rects)|Recognizing text in the specified rectangles. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. Skew alignment does not occur. fullPath - path to the image. rects - list of rectangles in pixels for recognizing.|
|string RecognizeImage(MemoryStream stream, Rectangle rects)|Recognizing text in the specified rectangle. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. Skew alignment does not occur. stream - MemoryStream of the image. rects - rectangle in pixels for recognizing.|
|string RecognizeImage(string fullPath, Rectangle rects)|Recognizing text in the specified rectangle. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. Skew alignment does not occur. fullPath - path to the image. rects - rectangle in pixels for recognizing.|
|string RecognizeLine(MemoryStream stream)|Recognizing an image that contains only one line of text. Skew alignment does not occur. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. stream - MemoryStream of the image.|
|string RecognizeLine(string fullPath)|Recognizing an image that contains only one line of text. Skew alignment does not occur. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. fullPath - path to the image.|
|List GetRectangles(MemoryStream stream)|Get detected rectangles with text areas. Skew alignment does not occur. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. stream - MemoryStream of the image.|
|List GetRectangles(string fullPath)|Get detected rectangles with text areas. Skew alignment does not occur. Support for GIF, PNG, JPEG, BMP, TIFF, and WBMP. fullPath - path to the image|
|License()|Constructor. Create a License instance.|
|void SetLicense(string licenseName)|licenseName - path to xml license file.|

### Removed APIs

All methods of the previous release are not supported.

## Usage Example

{{< highlight csharp >}}

using System;

using System.Collections.Generic;

using System.Drawing;

using System.IO;

using Aspose.OCR;

namespace ProgramOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get API
            AsposeOcr api = new AsposeOcr();

            // Create license
            License lic = new License();
 
            // Set license 
            lic.SetLicense("Aspose.Total.lic");
 
            // Get image for recognize
            string imgPath = "test_ocr.png";
 
            /* Recognize image from file*/
 
            // Recognize image
            string result = api.RecognizeImage(imgPath);
 
            // Print result
            Console.WriteLine(result);
 
            /* Recognize image from stream*/
 
            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
            {
                file.CopyTo(ms);
                result = api.RecognizeImage(ms);
            }
            Console.WriteLine(result);
 
            /*Recognize image from file without detected texts areas and remove skew 
            (all image is a text area) */
 
            result = api.RecognizeImage(imgPath, false);
            Console.WriteLine(result);
 
            /*Recognize image from file with detected texts areas and without
            remove skew text*/
 
            result = api.RecognizeImage(imgPath, true, false);
            Console.WriteLine(result);
 
            /* Recognize image in the specified rectangles */
 
            List<Rectangle> rects = new List<Rectangle>()
            {
                new Rectangle(138, 352, 2033, 537),
                new Rectangle(147, 890, 2033, 1157),
                new Rectangle(923, 2045, 465, 102),
                new Rectangle(104, 2147, 2076, 819)
            };
 
            List<string> listResult = api.RecognizeImage(imgPath, rects);
 
            foreach (string s in listResult)
            {
                Console.WriteLine(s);
            }
 
            /* Recognize image in the specified rectangle */
 
            result = api.RecognizeImage(imgPath, rects[0]);
            Console.WriteLine(result);
 
            /* With allowed symbols*/
 
            // Create api instance with allowed symbols.
            api = new AsposeOcr("0123456789");
 
            // Get image line for recognize
            imgPath = "0002240177.Jpeg";
 
            // Recognize line
            result = api.RecognizeLine(imgPath);
 
            Console.WriteLine(result);
 
            /* Calculate skew image from stream */
 
            imgPath = "skew_image.png";
            float angle = 0;
 
            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
            {
                file.CopyTo(ms);
                angle = api.CalculateSkew(ms);
            }
            Console.WriteLine(angle);
 
            /* Calculate skew image from path to image */
 
            angle = api.CalculateSkew(imgPath);
            Console.WriteLine(angle);
        }
    }
}

{{< /highlight >}}
