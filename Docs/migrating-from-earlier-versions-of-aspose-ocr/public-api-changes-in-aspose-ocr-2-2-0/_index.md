---
title: Public API Changes in Aspose.OCR 2.2.0
type: docs
weight: 30
url: /net/public-api-changes-in-aspose-ocr-2-2-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.1.0 to 2.2.0, that may be of interest to module and application developers. It includes not only new and updated public methods, [added classes etc.](/ocr/net/public-api-changes-in-aspose-ocr-2-2-0-html/) and [removed classes etc.](/ocr/net/public-api-changes-in-aspose-ocr-2-2-0-html/), but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
## **Added Classes, Enumerations and Methods**
### **Class PreprocessedImages Added**
The new Aspose.OCR.PreprocessedImages class to allow the users to see how original input image changes during OCR preprocessing. PreprocessedImages can be helpful in analyzing how different configuration parameters influence the OCR performance.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Image = ImageStream.FromFile(@"image.png");

ocr.Process();

System.Drawing.Bitmap binImg = ocr.PreprocessedImages.BinarizedImage;

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("image.png")

ocr.Process()

Dim binImg As System.Drawing.Bitmap = ocr.PreprocessedImages.BinarizedImage

{{< /highlight >}}
### **Class LanguageFactory Added**
The new Aspose.OCR.LanguageFactory class has replaced the obsolete Language class in order to provide the support for loading languages from resource files.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

// Add language from file

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load(@"engresources.zip")); 

// Add language from stream

Stream langStream = new FileStream(@"anotherlangresources.zip",FileMode.Open);

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load(langStream)); 

langStream.Close();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

' Add language from file

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load("engresources.zip"))

' Add language from stream

Dim langStream As Stream = New FileStream("anotherlangresources.zip",FileMode.Open)

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load(langStream))

langStream.Close()

{{< /highlight >}}
### **Method LanguageContainer.AddLanguages Added**
In order to provide the support for adding multiple languages the Aspose.OCR.LanguageContainer class has exposed the AddLanguages method.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage[] arr = new ILanguage[2];

arr[0] = LanguageFactory.Load(@"engresources.zip"); 

arr[1] = LanguageFactory.Load(@"anotherresourcefile.zip"); 

ocr.LanguageContainer.AddLanguages(arr);

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

Dim arr(1) As ILanguage

arr(0) = LanguageFactory.Load("engresources.zip")

arr(1) = LanguageFactory.Load("anotherresourcefile.zip")

ocr.LanguageContainer.AddLanguages(arr)

{{< /highlight >}}
### **Method LanguageContainer.RemoveLanguage Added**
The Aspose.OCR.LanguageContainer class has exposed the RemoveLanguage method that accepts a parameter of type ILanguage and removes it from the LanguageContainer.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage eng = ocr.LanguageContainer.Languages[0];

ocr.LanguageContainer.RemoveLanguage(eng);

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

Dim eng As ILanguage = ocr.LanguageContainer.Languages(0)

ocr.LanguageContainer.RemoveLanguage(eng)

{{< /highlight >}}
### **Method LanguageContainer.RemoveLanguages Added**
The Aspose.OCR.LanguageContainer class has exposed the RemoveLanguages method that accepts an array of type ILanguage and removes all the specified languages from the LanguageContainer.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage[] arr = new ILanguage[1];

arr[0] = ocr.LanguageContainer.Languages[0];

ocr.LanguageContainer.RemoveLanguages(arr);

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

Dim arr(0) As ILanguage

arr(0) = ocr.LanguageContainer.Languages(0)

ocr.LanguageContainer.RemoveLanguages(arr)

{{< /highlight >}}
### **Method LanguageContainer.ResetToDefaults Added**
The ResetToDefaults method removes all added languages from Aspose.OCR.LanguageContainer instance and loads the default language (English) to it.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.LanguageContainer.ResetToDefaults();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.LanguageContainer.ResetToDefaults()

{{< /highlight >}}
### **Method LanguageContainer.Clear Added**
The Aspose.OCR.LanguageContainer class has now exposed the Clear method with the release of Aspose.OCR for .NET 2.2.0 to clear the collection of languages from LanguageContainer.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.LanguageContainer.Clear();

Console.WriteLine(ocr.LanguageContainer.Languages.Length); // will be zero

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.LanguageContainer.Clear()

Console.WriteLine(ocr.LanguageContainer.Languages.Length) ' will be zero

{{< /highlight >}}
### **Method LanguageContainer.Dispose Added**
The class Aspose.OCR.LanguageContainer has exposed Dispose method to dispose off the LanguageContainer object.
### **Method LanguageFactory.Load Added**
The Aspose.OCR.LanguageFactory class has exposed two variations of the Load method that helps in loading the resource archives from an object of Stream or file path location.

**LanguageFactory.Load(System.IO.Stream)**

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

// Add language from stream

Stream langStream = new FileStream(@"langresources.zip",FileMode.Open);

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load(langStream));

langStream.Close();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

' Add language from stream

Dim langStream As Stream = New FileStream("langresources.zip",FileMode.Open)

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load(langStream))

langStream.Close()

{{< /highlight >}}

**LanguageFactory.Load(System.String)**

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

// Add language from file

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load(@"engresources.zip"));

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

' Add language from file

ocr.LanguageContainer.AddLanguage(LanguageFactory.Load("engresources.zip"))

{{< /highlight >}}
### **Method OcrEngine.Dispose Added**
The class Aspose.OCR.OcrEngine has exposed Dispose method to dispose off the OcrEngine object.
### **Property OcrEngine.LanguageContainer Added**
The new Aspose.OCR.OcrEngine class has exposed the LanguageContainer property in order to contain all languages loaded for recognition.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage lang = ocr.LanguageContainer.Languages[0];

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

Dim lang As ILanguage = ocr.LanguageContainer.Languages(0)

{{< /highlight >}}
### **Property ILanguage.Name Added**
The Aspose.OCR.ILanguage class has now exposed the Name property that has replaced the ILanguage.Language property with the release of Aspose.OCR for .NET 2.2.0. Now only ILanguage.Name property can be used to fetch the name of any loaded language. 

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage lang = ocr.LanguageContainer.Languages[0];

Console.WriteLine(lang.Name);

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

Dim lang As ILanguage = ocr.LanguageContainer.Languages(0)

Console.WriteLine(lang.Name)

{{< /highlight >}}
### **Property LanguageContainer.Languages Added**
The Aspose.OCR.LanguageContainer class has exposed the Languages property that has replaced the OcrEngine.Languages property with the release of Aspose.OCR for .NET 2.2.0. The LanguageContainer.Languages property contains all the languages loaded to LanguageContainer. 

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage[] langs = ocr.LanguageContainer.Languages;

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

Dim langs() As ILanguage = ocr.LanguageContainer.Languages

{{< /highlight >}}
### **Property License.IsLicensed Added**
The Aspose.OCR.License & Aspose.OMR.License classes have exposed the IsLicensed property that will return true if license has been properly set. 

**C#**

{{< highlight csharp >}}

 var ocrlicense = new Aspose.OCR.License();

ocrlicense.SetLicense(licensePath);

if (ocrlicense.IsLicensed)

{

    Console.WriteLine("License is Set for OMR Component!");

}

var omrlicense = new Aspose.OMR.License();

omrlicense.SetLicense(licensePath);

if (omrlicense.IsLicensed)

{

    Console.WriteLine("License is Set for OCR Component!");

}

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocrlicense = New Aspose.OCR.License()

ocrlicense.SetLicense(licensePath)

If ocrlicense.IsLicensed Then

	Console.WriteLine("License is Set for OMR Component!")

End If

Dim omrlicense = New Aspose.OMR.License()

omrlicense.SetLicense(licensePath)

If omrlicense.IsLicensed Then

	Console.WriteLine("License is Set for OCR Component!")

End If

{{< /highlight >}}
### **Property OCRConfig.Whitelist Added**
The Aspose.OCR.OCRConfig class have exposed the Whitelist property that can be used to get/set a white list of characters. If Whitelist property is not null and not empty, OcrEngine will recognize only the white-listed characters.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.Config.Whitelist = new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

ocr.Image = ImageStream.FromFile(@"image.png");

ocr.Process();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Config.Whitelist = New Char() {"1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "0"c}

ocr.Image = ImageStream.FromFile("image.png")

ocr.Process()

{{< /highlight >}}
## **Removed Classes, Properties**
### **Class Language Removed**
The Aspose.OCR.Language class has been replaced by the Aspose.OCR.LanguageFactory class.
### **Method Language.Load Removed**
The Aspose.OCR.Language.Load method has been replaced by the Aspose.OCR.LanguageFactory.Load method.
### **Method LanguageContainer.GetEnumerator Removed**
The Aspose.OCR.LanguageContainer.GetEnumerato method has been replaced by the Aspose.OCR.LanguageContainer.Languages property.
### **Property OcrEngine.Resource Removed**
Resource file with default language (English) is now embedded into Aspose.OCR assembly, and English language is loaded into OcrEngine.LanguageContainer by default.

**C#**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();            

ocr.Image = ImageStream.FromFile(@"image.png");

ocr.Process();

{{< /highlight >}}

**Visual Basic**

{{< highlight csharp >}}

 Dim ocr As New OcrEngine()

ocr.Image = ImageStream.FromFile("image.png")

ocr.Process()

{{< /highlight >}}
### **Property OcrEngine.Languages Removed**
The Aspose.OCR.OcrEngine.Languages property has been moved to Aspose.OCR.LanguageContainer class for better understanding.
### **Property LanguageContainer.Item Removed**
Since v2.2.0 of Aspose.OCR for .NET, all loaded languages can only be accessed via Aspose.OCR.LanguageContainer.Languages property.
