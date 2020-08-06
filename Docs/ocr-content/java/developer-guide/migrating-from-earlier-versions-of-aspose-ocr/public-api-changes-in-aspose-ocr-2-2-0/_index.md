---
title: Public API Changes in Aspose.OCR 2.2.0
type: docs
weight: 20
url: /java/public-api-changes-in-aspose-ocr-2-2-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.0.0 to 2.2.0, that may be of interest to module and application developers. It includes not only new and updated public methods, [added classes etc.](/ocr/java/public-api-changes-in-aspose-ocr-2-2-0-html/) and [removed classes etc.](/ocr/java/public-api-changes-in-aspose-ocr-2-2-0-html/), but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
## **Added Classes, Enumerations and Methods**
### **Class PreprocessedImages Added**
The new com.aspose.ocr.PreprocessedImages class to allow the users to see how original input image changes during OCR pre-processing. PreprocessedImages can be helpful in analyzing how different configuration parameters influence the OCR performance.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.setImage(ImageStream.fromFile("image.png"));

ocr.process();

BufferedImage binImg = ocr.getPreprocessedImages().getBinarizedImage();

{{< /highlight >}}
### **Class LanguageFactory Added**
The new com.aspose.ocr.LanguageFactory class has replaced the obsolete Language class in order to provide the support for loading languages from resource files.

**Java**

{{< highlight csharp >}}

 String resourceLocation = "engresources.zip";

OcrEngine ocr = new OcrEngine();

// Add language from file

ocr.getLanguageContainer().addLanguage(LanguageFactory.load(resourceLocation));

// Add language from InputStream

InputStream inputStream = new FileInputStream(resourceLocation);

ocr.getLanguageContainer().addLanguage(LanguageFactory.load(inputStream));

inputStream.close();

{{< /highlight >}}
### **Method LanguageContainer.addLanguages Added**
In order to provide the support for adding multiple languages the com.aspose.ocr.LanguageContainer class has exposed the addLanguages method.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage[] arr = new ILanguage[2];

arr[0] = LanguageFactory.load("engresources.zip");

arr[1] = LanguageFactory.load("anotherresourcefile.zip");

ocr.getLanguageContainer().addLanguages(arr);

{{< /highlight >}}
### **Method LanguageContainer.removeLanguage Added**
The com.aspose.ocr.LanguageContainer class has exposed the removeLanguage method that accepts a parameter of type ILanguage and removes it from the LanguageContainer.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage eng = ocr.getLanguageContainer().getLanguages()[0];

ocr.getLanguageContainer().removeLanguage(eng);

{{< /highlight >}}
### **Method LanguageContainer.removeLanguages Added**
The com.aspose.ocr.LanguageContainer class has exposed the removeLanguages method that accepts an array of type ILanguage and removes all the specified languages from the LanguageContainer.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ILanguage[] arr = new ILanguage[1];

arr[0] = ocr.getLanguageContainer().getLanguages()[0];

ocr.getLanguageContainer().removeLanguages(arr);

{{< /highlight >}}
### **Method LanguageContainer.resetToDefaults Added**
The resetToDefaults method removes all added languages from com.aspose.ocr.LanguageContainer instance and loads the default language (English) to it.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.getLanguageContainer().resetToDefaults();

{{< /highlight >}}
### **Method LanguageContainer.clear Added**
The com.aspose.ocr.LanguageContainer class has now exposed the clear method with the release of Aspose.OCR for Java 2.2.0 to clear the collection of languages from LanguageContainer.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.getLanguageContainer().clear();

System.out.println(ocr.getLanguageContainer().getLanguages().length); // will be zero

{{< /highlight >}}
### **Method LanguageContainer.dispose Added**
The class com.aspose.ocr.LanguageContainer has exposed dispose method to dispose off the LanguageContainer object.
### **Method LanguageFactory.load Added**
The com.aspose.ocr.LanguageFactory class has exposed two variations of the load method that helps in loading the resource archives from an object of InputStream or file path location.

**LanguageFactory.load(java.io.InputStream)**

**Java**

{{< highlight csharp >}}

 InputStream inputStream = new FileInputStream(resourceLocation);

ocr.getLanguageContainer().addLanguage(LanguageFactory.load(inputStream));

{{< /highlight >}}

**LanguageFactory.Load(java.lang.string)**

**Java**

{{< highlight csharp >}}

 ocr.getLanguageContainer().addLanguage(LanguageFactory.load(resourceLocation));

{{< /highlight >}}
### **Method OcrEngine.dispose Added**
The class com.aspose.ocr.OcrEngine has exposed dispose method to properly dispose off the OcrEngine object.
### **Property OcrEngine.LanguageContainer Added**
The new com.aspose.ocr.OcrEngine class has exposed the LanguageContainer property in order to contain all the languages loaded for recognition.

**Java**

{{< highlight csharp >}}

 ILanguage lang = ocr.getLanguageContainer().getLanguages()[0];

{{< /highlight >}}
### **Property ILanguage.Name Added**
The com.aspose.ocr.ILanguage class has now exposed the Name property that has replaced the ILanguage.Language property with the release of Aspose.OCR for Java 2.2.0. Now only ILanguage.Name property can be used to fetch the name of any loaded language.

**Java**

{{< highlight csharp >}}

 ILanguage lang = ocr.getLanguageContainer().getLanguages()[0];

System.out.println(lang.getName());

{{< /highlight >}}
### **Property LanguageContainer.Languages Added**
The com.aspose.ocr.LanguageContainer class has exposed the Languages property that has replaced the OcrEngine.Languages property with the release of Aspose.OCR for Java 2.2.0. The LanguageContainer.Languages property contains all the languages loaded to the LanguageContainer.

**Java**

{{< highlight csharp >}}

 ILanguage[] langs = ocr.getLanguageContainer().getLanguages();

{{< /highlight >}}
### **Property OCRConfig.Whitelist Added**
The com.aspose.ocr.OCRConfig class have exposed the Whitelist property that can be used to get/set a white list of characters. If Whitelist property is not null and not empty, OcrEngine will recognize only the white-listed characters.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.getConfig().setWhitelist(new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'});

ocr.setImage(ImageStream.fromFile("image.png"));

ocr.process();

{{< /highlight >}}
## **Removed Classes, Properties**
### **Class Language Removed**
The com.aspose.ocr.Language class has been replaced by the com.aspose.ocr.LanguageFactory class.
### **Method Language.load Removed**
The com.aspose.ocr.Language.load method has been replaced by the com.aspose.ocr.LanguageFactory.load method.
### **Method LanguageContainer.getEnumerator Removed**
The com.aspose.ocr.LanguageContainer.getEnumerato method has been replaced by the com.aspose.ocr.LanguageContainer.Languages property.
### **Property OcrEngine.Resource Removed**
Resource file with default language (English) is now embedded into Aspose.OCR for Java Jar, and English language is loaded into OcrEngine.LanguageContainer by default.

**Java**

{{< highlight csharp >}}

 OcrEngine ocr = new OcrEngine();

ocr.setImage(ImageStream.fromFile("image.png"));

ocr.process();

{{< /highlight >}}
### **Property OcrEngine.Languages Removed**
The com.aspose.ocr.OcrEngine.Languages property has been moved to com.aspose.ocr.LanguageContainer class for better understanding.
### **Property LanguageContainer.Item Removed**
Since v2.2.0 of Aspose.OCR for Java, all loaded languages can only be accessed via com.aspose.ocr.LanguageContainer.Languages property.
