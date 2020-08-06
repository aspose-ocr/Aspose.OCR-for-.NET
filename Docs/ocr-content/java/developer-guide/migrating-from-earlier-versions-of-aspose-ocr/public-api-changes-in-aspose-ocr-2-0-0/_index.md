---
title: Public API Changes in Aspose.OCR 2.0.0
type: docs
weight: 10
url: /java/public-api-changes-in-aspose-ocr-2-0-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 1.9.0 to 2.0.0, that may be of interest to module and application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.OCR.

{{% /alert %}} 
### **Added Properties**
#### **Added the DetectReadingOrder Property**
The OcrConfig class has exposed the getter/setter for the DetectReadingOrder property which can be used to get or set a value that indicates whether special reading order detection operation be applied to text blocks. The default value is true, and in case the OCR process consumes too much time or does not respond, try to set this property to false.

**Java**

{{< highlight csharp >}}

 //Create an instance of OcrEngine class

OcrEngine ocr = new OcrEngine();

//Set the Image property of OcrEngine by reading an image file

ocr.setImage(ImageStream.fromFile("image.tiff"));

//Add desired languages to the instance of OcrEngine class

ocr.getLanguages().addLanguage(Language.load("english"));

//Set the DetectReadingOrder to true

ocr.getConfig().setDetectReadingOrder(true);

//Assign the Resource property of OcrEngine by loading the resource file through FileStream

ocr.setResource(new FileInputStream(resourcesFolderPath));

//Perform OCR operation

if (ocr.process())

{

    //Display results



{{< /highlight >}}
#### **Added the DetectTextRegions Property**
The DetectTextRegions property has been added to the OcrConfig class. It specifies whether automatic text region detection will be used. If this property is set to true, manually set recognition blocks are ignored.

**Java**

{{< highlight csharp >}}

 //Create an instance of OcrEngine class

OcrEngine ocr = new OcrEngine();

//Set the Image property of OcrEngine by reading an image file

ocr.setImage(ImageStream.fromFile("image.tiff"));

//Add desired languages to the instance of OcrEngine class

ocr.getLanguages().addLanguage(Language.load("english"));

//Set the DetectTextRegions to true

ocr.getConfig().setDetectTextRegions(true);

//Assign the Resource property of OcrEngine by loading the resource file through FileStream

ocr.setResource(new FileInputStream(resourcesFolderPath));

//Perform OCR operation

if (ocr.process())

{

    //Display results

    System.out.println(ocr.getText());

}

{{< /highlight >}}

The above example demonstrates how to turn off automatic detection. Moreover, recognition blocks are not defined, so OcrEngine creates one recognition block for the entire image.
#### **Added the DoSpellingCorrection Property**
The DoSpellingCorrection property has been added to the OcrConfig class. Exposing the getter/setter for the DoSpellingCorrection property enables developers to choose if automatic spelling correction has to be applied. 

**C#**

{{< highlight csharp >}}

 //Create an instance of OcrEngine class

OcrEngine ocr = new OcrEngine();

//Set the Image property of OcrEngine by reading an image file

ocr.setImage(ImageStream.fromFile("image.tiff"));

//Add desired languages to the instance of OcrEngine class

ocr.getLanguages().addLanguage(Language.load("english"));

//Set the DoSpellingCorrection to true

ocr.getConfig().setDoSpellingCorrection(true);

//Assign the Resource property of OcrEngine by loading the resource file through FileStream

ocr.setResource(new FileInputStream(resourcesFolderPath));

//Perform OCR operation

if (ocr.process())

{

    //Display results

    System.out.println(ocr.getText());

}

{{< /highlight >}}

{{% alert color="primary" %}} 

Use this option to improve OCR results but be aware that increases the total processing time.

{{% /alert %}} 
#### **Added the RemoveNonText Property**
The RemoveNonText property has been added to the OcrConfig class. Set this parameter to true if an image contains non-text components, for example pictures, that should be ignored during the recognition process.

**Java**

{{< highlight csharp >}}

 //Create an instance of OcrEngine class

OcrEngine ocr = new OcrEngine();

//Set the Image property of OcrEngine by reading an image file

ocr.setImage(ImageStream.fromFile("image.tiff"));

//Add desired languages to the instance of OcrEngine class

ocr.getLanguages().addLanguage(Language.load("english"));

//Set the RemoveNonText to true

ocr.getConfig().setRemoveNonText(true);

//Assign the Resource property of OcrEngine by loading the resource file through FileStream

ocr.setResource(new FileInputStream(resourcesFolderPath));

//Perform OCR operation

if (ocr.process())

{

    //Display results

    System.out.println(ocr.getText());

}

{{< /highlight >}}
### **Removed Properties**
#### **Dropped the AdjustUpsideDownRotationMode.Automatic & OcrConfig.NeedRotationCorrection Properties**
The AdjustUpsideDownRotationMode.Automatic and OcrConfig.NeedRotationCorrection properties have been dropped. Now only the UserDefined option is available and can be set through the OcrConfig.AdjustRotation property. If it is not defined, the default value is None.

**Java**

{{< highlight csharp >}}

 //Create an instance of OcrEngine class

OcrEngine ocr = new OcrEngine();

//Set the Image property of OcrEngine by reading an image file

ocr.setImage(ImageStream.fromFile("image.tiff"));

//Add desired languages to the instance of OcrEngine class

ocr.getLanguages().addLanguage(Language.load("english"));

//Set the rotation mode & angle

ocr.getConfig().setAdjustRotation(AdjustRotationMode.UserDefined);

ocr.getConfig().setAdjustRotationAngle(10);

//Assign the Resource property of OcrEngine by loading the resource file through FileStream

ocr.setResource(new FileInputStream(resourcesFolderPath));

//Perform OCR operation

if (ocr.process())

{

    //Display results

    System.out.println(ocr.getText());

}

{{< /highlight >}}
#### **Removed the OcrEngine.Confidence & OcrEngine.ProbabilitySymbols Properties**
Starting from version 2.0.0, Aspose.OCR APIs do not contain the OcrEngine.Confidence and OcrEngine.ProbabilitySymbols properties because we feel they were useless due to incorrect results. Currently, there is no way to know the confidence, whereas the probability symbols are not possible to determine since the whole algorithm is totally rewritten and now we do not return the next probability symbols instead a single string result is returned.
#### **Removed IRecognitionBlock.Text Property**
Use the RecognitionData.getText() method to retrieve the same. Moreover, the class IRecognizedText also contains IRecognizedTextPartInfo[] PartsInfo with test on each block.
#### **Removed OcrConfig.OcrAlgorithmMode Property**
The said property has been removed because starting from version 2.0.0, the Aspose.OCR API has only one universal algorithm mode.
