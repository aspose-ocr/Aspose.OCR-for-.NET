---
title: Aspose.OCR for CPP 20.4 Release Notes
type: docs
weight: 10
url: /cpp/aspose-ocr-for-cpp-20-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.OCR for C++ 20.4.

{{% /alert %}} 

Aspose.OCR for C++ is a cross-platform C++ library for optical character recognition and document scanning. It allows you to scan documents and recognize characters. Recognized text in English charset.
#### **Prerequisite**
Aspose OCR library required onnxruntime.dll in the system path.
#### **Recognize charset**
"EN"
#### **Input formats**
- bmp
- jpg
- png
#### **Aspose OCR API**
Note: all function in the 'aspose::ocr' namespace.

|**Method**|**Description**|
| :- | :- |
|void set_license(const char* licenseFullPath)|licenseFullPath - path to xml license file.|
|bool get_state()|Return license status.|
|const wchar_t* recognize_page(const char* image_path)|Support jpg, bmp, and png format files.|
|const wchar_t* recognize_line(const char* image_path)|Support jpg, bmp, and png format files.|
|double get_skew(const char* image_path)|Calculate the skew angle.|
#### **Supported Characters**

|space|!|"|#|$|%|&|'|(|)|
| :- | :- | :- | :- | :- | :- | :- | :- | :- | :- |
|*|+|,|-|.|/|0|1|2|3 |
|4|5|6|7|8|9|:|;|<|**=**|
|>|?|@|[|\|]|_|`|{|| |
|}|~|A|B|C|D|E|F|G|H |
|I|J|K|L|M|N|O|P|Q|R|
|S|T|U|V|W|X|Y|Z|a|b |
|c|d|e|f|g|h|i|j|k|l |
|m|n|o|p|q|r|s|t|u|v |
|w|x|y|z|Â|À|Á|Ã|Ä|Æ |
|Ç|È|É|Ê|Ë|Ì|Í|Î|Ï|Ñ |
|Ò|Ó|Ô|Õ|Ö|Ù|Ú|Û|Ü|ẞ |
|ß|à|á|â|ã|ä|æ|ç|è|é |
|ê|ë|ì|í|î|ï|ñ|ò|ó|ô |
|õ|ö|ù|ú|û|ü|ÿ|Œ|œ|Ÿ |
#### **Example (C++17 since filesystem)**
{{< highlight cpp >}}

 #include <iostream>

#include <filesystem>

#include "aspose_ocr.h"

using namespace std;

int main()

{

	//Current directory

    const filesystem::path path{ filesystem::current_path() };

	//Set license

    const string lic = "/Aspose.Total.lic";

    filesystem::path license = path.string() + lic;

    aspose::ocr::set_license(license.string().c_str());

	//Recognize image

    filesystem::path image = path.string() + "/image.png";

    const wchar_t* result = aspose::ocr::recognize_page(image.string().c_str());

	//Print result

    wcout << result;

}

{{< /highlight >}}
