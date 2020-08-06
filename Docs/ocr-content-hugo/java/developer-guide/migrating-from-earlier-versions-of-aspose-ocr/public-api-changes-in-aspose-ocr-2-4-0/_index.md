---
title: Public API Changes in Aspose.OCR 2.4.0
type: docs
weight: 40
url: /java/public-api-changes-in-aspose-ocr-2-4-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.3.0 to 2.4.0, that may be of interest to module and application developers. 

{{% /alert %}} 
### **Complete List of Classes, Methods, Enumerations & Properties**
Aspose.OCR for Java API has merged the Aspose.Omr.jar into the Aspose.OCR.jar. Now the users do not have to add two jar files in their project references because all the classes, methods, enumerations & properties required for OCR & OMR operations are now present in Aspose.OCR.jar. Regardless of the said changes, the namespaces remain the same so there will not be any change in the source code in reference to the said merger.

Here is the complete list of APIs that have been moved to Aspose.OCR.jar with the release of v2.4.0.

|**Type** |**Fully Qualified Name** ||
| :- | :- | :- |
|Class |com.aspose.omr.elements.BarcodeElement||
|Class |com.aspose.omr.elements.BasicElement||
|Class |com.aspose.omr.elements.ChoiceBoxElement||
|Class |com.aspose.omr.elements.CustomImageProcessingAttribute||
|Class |com.aspose.omr.elements.GridElement||
|Class |com.aspose.omr.elements.GridSection||
|Class |com.aspose.omr.elements.ISpacedArea||
|Class |com.aspose.omr.elements.OmrCell||
|Class |com.aspose.omr.elements.OmrElement||
|Class |com.aspose.omr.elements.TextOcrElement||
|Class |com.aspose.omr.imageprocessing.AverageThresholdAlgorithm||
|Class |com.aspose.omr.imageprocessing.GrayscaleAlgorithm||
|Class |com.aspose.omr.imageprocessing.IProcessingAlgorithm||
|Class |com.aspose.omr.imageprocessing.OtsuBinarizationAlgorithm||
|Class |com.aspose.omr.imageprocessing.ProcessingPipeline||
|Class |com.aspose.omr.OmrConfig||
|Class |com.aspose.omr.OmrElementsCollection||
|Class |com.aspose.omr.OmrEngine||
|Class |com.aspose.omr.OmrImage||
|Class |com.aspose.omr.OmrPage||
|Class |com.aspose.omr.OmrPagesCollection||
|Class |com.aspose.omr.OmrProcessingResult||
|Class |com.aspose.omr.OmrTemplate||
|Field/Enum |com.aspose.omr.OmrImage.BufferPixelFormat||
|Field/Enum |com.aspose.omr.OmrImage.BytesPerPixel||
|Method |com.aspose.omr.elements.BarcodeElement.#ctor(String,PointF,SizeF)||
|Method |com.aspose.omr.elements.BarcodeElement.extractData(com.aspose.omr.OmrImage,com.aspose.omr.OmrConfig)||
|Method |com.aspose.omr.elements.BasicElement.#ctor(String,PointF,SizeF)||
|Method |com.aspose.omr.elements.BasicElement.extractData(com.aspose.omr.OmrImage,com.aspose.omr.OmrConfig)||
|Method |com.aspose.omr.elements.BasicElement.loadProperties(Collections.Specialized.StringDictionary)||
|Method |com.aspose.omr.elements.BasicElement.saveProperties||
|Method |com.aspose.omr.elements.ChoiceBoxElement.#ctor(String,PointF,SizeF)||
|Method |com.aspose.omr.elements.ChoiceBoxElement.extractData(com.aspose.omr.OmrImage,com.aspose.omr.OmrConfig)||
|Method |com.aspose.omr.elements.ChoiceBoxElement.loadProperties(Collections.Specialized.StringDictionary)||
|Method |com.aspose.omr.elements.ChoiceBoxElement.saveProperties||
|Method |com.aspose.omr.elements.CustomImageProcessingAttribute.#ctor||
|Method |com.aspose.omr.elements.GridElement.#ctor(String,PointF,SizeF)||
|Method |com.aspose.omr.elements.GridElement.extractData(com.aspose.omr.OmrImage,com.aspose.omr.OmrConfig)||
|Method |com.aspose.omr.elements.GridElement.setSectionsCount(int)||
|Method |com.aspose.omr.elements.GridSection.#ctor||
|Method |com.aspose.omr.elements.OmrCell.#ctor||
|Method |com.aspose.omr.elements.OmrCell.#ctor(String)||
|Method |com.aspose.omr.elements.OmrElement.#ctor(String,PointF,SizeF)||
|Method |com.aspose.omr.elements.OmrElement.loadProperties(Collections.Specialized.StringDictionary)||
|Method |com.aspose.omr.elements.OmrElement.saveProperties||
|Method |com.aspose.omr.elements.TextOcrElement.#ctor(String,PointF,SizeF)||
|Method |com.aspose.omr.elements.TextOcrElement.extractData(com.aspose.omr.OmrImage,com.aspose.omr.OmrConfig)||
|Method |com.aspose.omr.imageprocessing.AverageThresholdAlgorithm.#ctor||
|Method |com.aspose.omr.imageprocessing.AverageThresholdAlgorithm.process(com.aspose.omr.OmrImage,Drawing.Rectangle)||
|Method |com.aspose.omr.imageprocessing.GrayscaleAlgorithm.#ctor||
|Method |com.aspose.omr.imageprocessing.GrayscaleAlgorithm.process(com.aspose.omr.OmrImage,Drawing.Rectangle)||
|Method |com.aspose.omr.imageprocessing.IProcessingAlgorithm.process(com.aspose.omr.OmrImage,Drawing.Rectangle)||
|Method |com.aspose.omr.imageprocessing.OtsuBinarizationAlgorithm.#ctor||
|Method |com.aspose.omr.imageprocessing.OtsuBinarizationAlgorithm.process(com.aspose.omr.OmrImage,Drawing.Rectangle)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.#ctor||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.#ctor(Collections.ICollection)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.add(com.aspose.omr.imageprocessing.IProcessingAlgorithm)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.contains(com.aspose.omr.imageprocessing.IProcessingAlgorithm)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.copyTo(com.aspose.omr.imageprocessing.IProcessingAlgorithm[],int)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.indexOf(com.aspose.omr.imageprocessing.IProcessingAlgorithm)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.insert|(int,com.aspose.omr.imageprocessing.IProcessingAlgorithm)|
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.onValidate(java.lang.Object)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.process(com.aspose.omr.OmrImage,Rectangle)||
|Method |com.aspose.omr.imageprocessing.ProcessingPipeline.remove(com.aspose.omr.imageprocessing.IProcessingAlgorithm)||
|Method |com.aspose.omr.OmrConfig.#ctor||
|Method |com.aspose.omr.OmrElementsCollection.#ctor||
|Method |com.aspose.omr.OmrElementsCollection.#ctor(Collections.ICollection)||
|Method |com.aspose.omr.OmrElementsCollection.add(com.aspose.omr.elements.BasicElement)||
|Method |com.aspose.omr.OmrElementsCollection.contains(com.aspose.omr.elements.BasicElement)||
|Method |com.aspose.omr.OmrElementsCollection.copyTo(com.aspose.omr.elements.BasicElement[],int)||
|Method |com.aspose.omr.OmrElementsCollection.indexOf(com.aspose.omr.elements.BasicElement)||
|Method |com.aspose.omr.OmrElementsCollection.insert(int,com.aspose.omr.elements.BasicElement)||
|Method |com.aspose.omr.OmrElementsCollection.onValidate(java.lang.Object)||
|Method |com.aspose.omr.OmrElementsCollection.remove(com.aspose.omr.elements.BasicElement)||
|Method |com.aspose.omr.OmrEngine.#ctor(com.aspose.omr.OmrTemplate)||
|Method |com.aspose.omr.OmrEngine.#ctor(com.aspose.omr.OmrTemplate,com.aspose.omr.imageprocessing.ProcessingPipeline)||
|Method |com.aspose.omr.OmrEngine.changeProcessingPipeline(com.aspose.omr.imageprocessing.ProcessingPipeline)||
|Method |com.aspose.omr.OmrEngine.extractData(com.aspose.omr.OmrImage[])||
|Method |com.aspose.omr.OmrImage.#ctor(int,int,double,Byte[])||
|Method |com.aspose.omr.OmrImage.asBitmap||
|Method |com.aspose.omr.OmrImage.copy||
|Method |com.aspose.omr.OmrImage.load(Stream)||
|Method |com.aspose.omr.OmrImage.load(String)||
|Method |com.aspose.omr.OmrPage.#ctor||
|Method |com.aspose.omr.OmrPage.extactData(com.aspose.omr.OmrImage,com.aspose.omr.OmrConfig)||
|Method |com.aspose.omr.OmrPagesCollection.#ctor||
|Method |com.aspose.omr.OmrPagesCollection.#ctor(Collections.ICollection)||
|Method |com.aspose.omr.OmrPagesCollection.add(com.aspose.omr.OmrPage)||
|Method |com.aspose.omr.OmrPagesCollection.contains(com.aspose.omr.OmrPage)||
|Method |com.aspose.omr.OmrPagesCollection.copyTo(com.aspose.omr.OmrPage[],int)||
|Method |com.aspose.omr.OmrPagesCollection.indexOf(com.aspose.omr.OmrPage)||
|Method |com.aspose.omr.OmrPagesCollection.insert(int,com.aspose.omr.OmrPage)||
|Method |com.aspose.omr.OmrPagesCollection.onValidate(java.lang.Object)||
|Method |com.aspose.omr.OmrPagesCollection.remove(com.aspose.omr.OmrPage)||
|Method |com.aspose.omr.OmrProcessingResult.#ctor(Collections.Hashtable[])||
|Method |com.aspose.omr.OmrTemplate.#ctor||
|Method |com.aspose.omr.OmrTemplate.load(Stream)||
|Method |com.aspose.omr.OmrTemplate.load(String)||
|Method |com.aspose.omr.OmrTemplate.save(Stream)||
|Method |com.aspose.omr.OmrTemplate.save(String)||
|Property |com.aspose.omr.elements.BasicElement.Name||
|Property |com.aspose.omr.elements.BasicElement.Position||
|Property |com.aspose.omr.elements.BasicElement.Size||
|Property |com.aspose.omr.elements.ChoiceBoxElement.MultipleSelectionAllowed||
|Property |com.aspose.omr.elements.GridElement.Sections||
|Property |com.aspose.omr.elements.GridSection.SpaceAfter||
|Property |com.aspose.omr.elements.GridSection.SpaceBefore||
|Property |com.aspose.omr.elements.ISpacedArea.SpaceAfter||
|Property |com.aspose.omr.elements.ISpacedArea.SpaceBefore||
|Property |com.aspose.omr.elements.OmrCell.SpaceAfter||
|Property |com.aspose.omr.elements.OmrCell.SpaceBefore||
|Property |com.aspose.omr.elements.OmrCell.Value||
|Property |com.aspose.omr.elements.OmrElement.Cells||
|Property |com.aspose.omr.elements.OmrElement.Configuration||
|Property |com.aspose.omr.elements.OmrElement.IsHorizontal||
|Property |com.aspose.omr.elements.TextOcrElement.Resource||
|Property |com.aspose.omr.imageprocessing.ProcessingPipeline.Default||
|Property |com.aspose.omr.imageprocessing.ProcessingPipeline.Item(int)||
|Property |com.aspose.omr.OmrConfig.FillThreshold||
|Property |com.aspose.omr.OmrConfig.TrimWhitePixels||
|Property |com.aspose.omr.OmrElementsCollection.Item(int)||
|Property |com.aspose.omr.OmrEngine.Configuration||
|Property |com.aspose.omr.OmrEngine.ProcessingPipeline||
|Property |com.aspose.omr.OmrEngine.Template||
|Property |com.aspose.omr.OmrImage.Buffer||
|Property |com.aspose.omr.OmrImage.Height||
|Property |com.aspose.omr.OmrImage.Resolution||
|Property |com.aspose.omr.OmrImage.Width||
|Property |com.aspose.omr.OmrPage.Configuration||
|Property |com.aspose.omr.OmrPage.Elements||
|Property |com.aspose.omr.OmrPage.Height||
|Property |com.aspose.omr.OmrPage.SheetImage||
|Property |com.aspose.omr.OmrPage.Width||
|Property |com.aspose.omr.OmrPagesCollection.Item(int)||
|Property |com.aspose.omr.OmrProcessingResult.PageData||
|Property |com.aspose.omr.OmrTemplate.Pages||

