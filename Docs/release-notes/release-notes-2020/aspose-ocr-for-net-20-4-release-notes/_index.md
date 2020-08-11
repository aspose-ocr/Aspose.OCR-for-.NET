---
title: Aspose.OCR for .NET 20.4 - Release Notes
type: docs
weight: 10
url: /net/aspose-ocr-for-net-20-4-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.OCR for .NET 20.4

{{% /alert %}}

In this release, we are introducing a new recognition engine based on effective CPU calculations to increase the performance of text recognition. Machine Learning approaches allow using GPU to improve performance significantly,

## Enhancements

- Improved performance using CPU/GPU.
- New text search approach tuned for complex layouts.

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
|string RecognizeImage(string fullPath)|fullPath - path to the image. The possible format is png, jpg, gif, bmp.|
|string RecognizeLine(string fullPath)|fullPath - path to image line. The possible format is png, jpg, gif, bmp.|
|void SetLicense(string licenseName)|licenseName - path to XML license file.|

### Removed APIs

All methods of the previous release are not supported.

## Usage Example

{{< highlight csharp >}}

using System;

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

            // Recognize image

            string result = api.RecognizeImage(imgPath);

            // Print result

            Console.WriteLine(result);

            // Dispose

            api.Dispose();

        }

    }

}

{{< /highlight >}}
