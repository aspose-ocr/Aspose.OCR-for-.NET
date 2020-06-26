# Aspose.OCR for .NET

[Aspose.OCR for .NET](https://products.aspose.com/ocr/net) is a character and optical mark recognition API that allows developers to add OCR functionality in their ASP.NET web applications, web services, and Windows applications without requiring any additional tool or API. It provides a simple set of classes for controlling character recognition.

<p align="center">
  <a href="https://github.com/aspose-ocr/Aspose.OCR-for-.NET/archive/master.zip">
    <img src="http://i.imgur.com/hwNhrGZ.png" />
  </a>
</p>

This repository contains [Demos](Demos), [Examples](Examples) and Showcase projects for [Aspose.OCR for .NET](https://products.aspose.com/ocr/net) to help you learn and write your applications.

Directory | Description
--------- | -----------
[Demos](Demos)  | Aspose.OCR for .NET Live Demos Source Code
[Examples](Examples)  | A collection of .NET examples that help you learn the product features

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

# Optical Character Recognition (OCR) .NET API

It is a standalone OCR API that enhances your .NET apps to perform the [OCR operation on JPEG, PNG, GIF, BMP & TIFF images](https://docs.aspose.com/display/ocrnet/Supported+File+Formats) for extraction of English, French, Spanish & Portuguese content.

[Aspose.OCR for .NET](https://products.aspose.com/ocr/net) not only provides the Optical Character Recognition engine but more. You can also apply Blur, Gaussian Blur, and Median filter to reduce noise before document recognition and can set the OcrEngine to ignore non-textual blocks, maintain correct text order during document text recognition & automatically correct spellings of the document text.

## Image OCR API Features

- Programmatically [detect, identify and read characters](https://docs.aspose.com/display/ocrnet/Performing+OCR+on+an+Image) from images.
- Support English, French, Spanish and Portuguese text.
- Detect and read popular font faces such as Arial, Times New Roman, Courier New, Tahoma, Calibri & Verdana.
- Supports regular, bold and italic font styles.
- Scan whole image or only a specific portion of the image.
- Scan rotated images.
- Application of various noise removal filters to assist image recognition.

## Read Image Formats for OCR

**Raster Formats:** JPEG, PNG, GIF, BMP, TIFF

## Platform Independence

You can use Aspose.OCR for .NET to develop applications in any development environment that targets the .NET Framework 2.0 and higher. This includes support for Mono and Client Profiles.

## Getting Started with Aspose.OCR for .NET

Are you ready to give Aspose.OCR for .NET a try? Simply execute `Install-Package Aspose.OCR` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.OCR for .NET and want to upgrade the version, please execute `Update-Package Aspose.OCR` to get the latest version.

Execute the following code snippet to see how Aspose.OCR API performs with your own samples or check the [GitHub Repository](https://github.com/aspose-ocr/Aspose.OCR-for-.NET) for other common usage scenarios.

## Perform OCR on PNG Image via C# Code

```csharp
// The path to the documents directory.
string dataDir = RunExamples.GetDataDir_OCR();

// Initialize an instance of AsposeOcr
AsposeOcr api = new AsposeOcr();

// Recognize image
string result = api.RecognizeImage(dataDir + "sample.png");

// Display the recognized text
Console.WriteLine(result);
```

[Product Page](https://products.aspose.com/ocr/net) | [Docs](https://docs.aspose.com/display/ocrnet/Home) | [Demos](https://products.aspose.app/ocr/family) | [API Reference](https://apireference.aspose.com/ocr/net) | [Examples](https://github.com/aspose-ocr/Aspose.OCR-for-.NET) | [Blog](https://blog.aspose.com/category/ocr/) | [Free Support](https://forum.aspose.com/c/ocr) |  [Temporary License](https://purchase.aspose.com/temporary-license)
