---
title: Public API Changes in Aspose.OCR 2.4.0
type: docs
weight: 50
url: /net/public-api-changes-in-aspose-ocr-2-4-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.OCR API from version 2.3.0 to 2.4.0, that may be of interest to module and application developers. 

{{% /alert %}} 
### **Complete List of Classes, Methods, Enumerations & Properties**
Aspose.OCR for .NET API has merged the Aspose.OMR.dll into the Aspose.OCR.dll. Now the users do not have to add two assemblies in their project references because all the classes, methods, enumnerations & properties required for OCR & OMR operations are now present in Aspose.OCR.dll. Regardless of the said changes, the namespaces remain the same so there will not be any change in the source code in reference to the said merger.

Here is the complete list of APIs that have been moved to Aspose.OCR.dll with the release of v2.4.0.

|**Type** |**Fully Qualified Name** ||
| :- | :- | :- |
|Class |Aspose.OMR.Elements.BarcodeElement||
|Class |Aspose.OMR.Elements.BasicElement||
|Class |Aspose.OMR.Elements.ChoiceBoxElement||
|Class |Aspose.OMR.Elements.CustomImageProcessingAttribute||
|Class |Aspose.OMR.Elements.GridElement||
|Class |Aspose.OMR.Elements.GridSection||
|Class |Aspose.OMR.Elements.ISpacedArea||
|Class |Aspose.OMR.Elements.OmrCell||
|Class |Aspose.OMR.Elements.OmrElement||
|Class |Aspose.OMR.Elements.TextOcrElement||
|Class |Aspose.OMR.ImageProcessing.AverageThresholdAlgorithm||
|Class |Aspose.OMR.ImageProcessing.GrayscaleAlgorithm||
|Class |Aspose.OMR.ImageProcessing.IProcessingAlgorithm||
|Class |Aspose.OMR.ImageProcessing.OtsuBinarizationAlgorithm||
|Class |Aspose.OMR.ImageProcessing.ProcessingPipeline||
|Class |Aspose.OMR.OmrConfig||
|Class |Aspose.OMR.OmrElementsCollection||
|Class |Aspose.OMR.OmrEngine||
|Class |Aspose.OMR.OmrImage||
|Class |Aspose.OMR.OmrPage||
|Class |Aspose.OMR.OmrPagesCollection||
|Class |Aspose.OMR.OmrProcessingResult||
|Class |Aspose.OMR.OmrTemplate||
|Field/Enum |Aspose.OMR.OmrImage.BufferPixelFormat||
|Field/Enum |Aspose.OMR.OmrImage.BytesPerPixel||
|Method |Aspose.OMR.Elements.BarcodeElement.#ctor(System.String,System.Drawing.PointF,System.Drawing.SizeF)||
|Method |Aspose.OMR.Elements.BarcodeElement.ExtractData(Aspose.OMR.OmrImage,Aspose.OMR.OmrConfig)||
|Method |Aspose.OMR.Elements.BasicElement.#ctor(System.String,System.Drawing.PointF,System.Drawing.SizeF)||
|Method |Aspose.OMR.Elements.BasicElement.ExtractData(Aspose.OMR.OmrImage,Aspose.OMR.OmrConfig)||
|Method |Aspose.OMR.Elements.BasicElement.LoadProperties(System.Collections.Specialized.StringDictionary)||
|Method |Aspose.OMR.Elements.BasicElement.SaveProperties||
|Method |Aspose.OMR.Elements.ChoiceBoxElement.#ctor(System.String,System.Drawing.PointF,System.Drawing.SizeF)||
|Method |Aspose.OMR.Elements.ChoiceBoxElement.ExtractData(Aspose.OMR.OmrImage,Aspose.OMR.OmrConfig)||
|Method |Aspose.OMR.Elements.ChoiceBoxElement.LoadProperties(System.Collections.Specialized.StringDictionary)||
|Method |Aspose.OMR.Elements.ChoiceBoxElement.SaveProperties||
|Method |Aspose.OMR.Elements.CustomImageProcessingAttribute.#ctor||
|Method |Aspose.OMR.Elements.GridElement.#ctor(System.String,System.Drawing.PointF,System.Drawing.SizeF)||
|Method |Aspose.OMR.Elements.GridElement.ExtractData(Aspose.OMR.OmrImage,Aspose.OMR.OmrConfig)||
|Method |Aspose.OMR.Elements.GridElement.SetSectionsCount(System.Int32)||
|Method |Aspose.OMR.Elements.GridSection.#ctor||
|Method |Aspose.OMR.Elements.OmrCell.#ctor||
|Method |Aspose.OMR.Elements.OmrCell.#ctor(System.String)||
|Method |Aspose.OMR.Elements.OmrElement.#ctor(System.String,System.Drawing.PointF,System.Drawing.SizeF)||
|Method |Aspose.OMR.Elements.OmrElement.LoadProperties(System.Collections.Specialized.StringDictionary)||
|Method |Aspose.OMR.Elements.OmrElement.SaveProperties||
|Method |Aspose.OMR.Elements.TextOcrElement.#ctor(System.String,System.Drawing.PointF,System.Drawing.SizeF)||
|Method |Aspose.OMR.Elements.TextOcrElement.ExtractData(Aspose.OMR.OmrImage,Aspose.OMR.OmrConfig)||
|Method |Aspose.OMR.ImageProcessing.AverageThresholdAlgorithm.#ctor||
|Method |Aspose.OMR.ImageProcessing.AverageThresholdAlgorithm.Process(Aspose.OMR.OmrImage,System.Drawing.Rectangle)||
|Method |Aspose.OMR.ImageProcessing.GrayscaleAlgorithm.#ctor||
|Method |Aspose.OMR.ImageProcessing.GrayscaleAlgorithm.Process(Aspose.OMR.OmrImage,System.Drawing.Rectangle)||
|Method |Aspose.OMR.ImageProcessing.IProcessingAlgorithm.Process(Aspose.OMR.OmrImage,System.Drawing.Rectangle)||
|Method |Aspose.OMR.ImageProcessing.OtsuBinarizationAlgorithm.#ctor||
|Method |Aspose.OMR.ImageProcessing.OtsuBinarizationAlgorithm.Process(Aspose.OMR.OmrImage,System.Drawing.Rectangle)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.#ctor||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.#ctor(System.Collections.ICollection)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.Add(Aspose.OMR.ImageProcessing.IProcessingAlgorithm)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.Contains(Aspose.OMR.ImageProcessing.IProcessingAlgorithm)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.CopyTo(Aspose.OMR.ImageProcessing.IProcessingAlgorithm[],System.Int32)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.IndexOf(Aspose.OMR.ImageProcessing.IProcessingAlgorithm)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.Insert|(System.Int32,Aspose.OMR.ImageProcessing.IProcessingAlgorithm)|
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.OnValidate(System.Object)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.Process(Aspose.OMR.OmrImage,System.Drawing.Rectangle)||
|Method |Aspose.OMR.ImageProcessing.ProcessingPipeline.Remove(Aspose.OMR.ImageProcessing.IProcessingAlgorithm)||
|Method |Aspose.OMR.OmrConfig.#ctor||
|Method |Aspose.OMR.OmrElementsCollection.#ctor||
|Method |Aspose.OMR.OmrElementsCollection.#ctor(System.Collections.ICollection)||
|Method |Aspose.OMR.OmrElementsCollection.Add(Aspose.OMR.Elements.BasicElement)||
|Method |Aspose.OMR.OmrElementsCollection.Contains(Aspose.OMR.Elements.BasicElement)||
|Method |Aspose.OMR.OmrElementsCollection.CopyTo(Aspose.OMR.Elements.BasicElement[],System.Int32)||
|Method |Aspose.OMR.OmrElementsCollection.IndexOf(Aspose.OMR.Elements.BasicElement)||
|Method |Aspose.OMR.OmrElementsCollection.Insert(System.Int32,Aspose.OMR.Elements.BasicElement)||
|Method |Aspose.OMR.OmrElementsCollection.OnValidate(System.Object)||
|Method |Aspose.OMR.OmrElementsCollection.Remove(Aspose.OMR.Elements.BasicElement)||
|Method |Aspose.OMR.OmrEngine.#ctor(Aspose.OMR.OmrTemplate)||
|Method |Aspose.OMR.OmrEngine.#ctor(Aspose.OMR.OmrTemplate,Aspose.OMR.ImageProcessing.ProcessingPipeline)||
|Method |Aspose.OMR.OmrEngine.ChangeProcessingPipeline(Aspose.OMR.ImageProcessing.ProcessingPipeline)||
|Method |Aspose.OMR.OmrEngine.ExtractData(Aspose.OMR.OmrImage[])||
|Method |Aspose.OMR.OmrImage.#ctor(System.Int32,System.Int32,System.Double,System.Byte[])||
|Method |Aspose.OMR.OmrImage.AsBitmap||
|Method |Aspose.OMR.OmrImage.Copy||
|Method |Aspose.OMR.OmrImage.Load(System.IO.Stream)||
|Method |Aspose.OMR.OmrImage.Load(System.String)||
|Method |Aspose.OMR.OmrPage.#ctor||
|Method |Aspose.OMR.OmrPage.ExtactData(Aspose.OMR.OmrImage,Aspose.OMR.OmrConfig)||
|Method |Aspose.OMR.OmrPagesCollection.#ctor||
|Method |Aspose.OMR.OmrPagesCollection.#ctor(System.Collections.ICollection)||
|Method |Aspose.OMR.OmrPagesCollection.Add(Aspose.OMR.OmrPage)||
|Method |Aspose.OMR.OmrPagesCollection.Contains(Aspose.OMR.OmrPage)||
|Method |Aspose.OMR.OmrPagesCollection.CopyTo(Aspose.OMR.OmrPage[],System.Int32)||
|Method |Aspose.OMR.OmrPagesCollection.IndexOf(Aspose.OMR.OmrPage)||
|Method |Aspose.OMR.OmrPagesCollection.Insert(System.Int32,Aspose.OMR.OmrPage)||
|Method |Aspose.OMR.OmrPagesCollection.OnValidate(System.Object)||
|Method |Aspose.OMR.OmrPagesCollection.Remove(Aspose.OMR.OmrPage)||
|Method |Aspose.OMR.OmrProcessingResult.#ctor(System.Collections.Hashtable[])||
|Method |Aspose.OMR.OmrTemplate.#ctor||
|Method |Aspose.OMR.OmrTemplate.Load(System.IO.Stream)||
|Method |Aspose.OMR.OmrTemplate.Load(System.String)||
|Method |Aspose.OMR.OmrTemplate.Save(System.IO.Stream)||
|Method |Aspose.OMR.OmrTemplate.Save(System.String)||
|Property |Aspose.OMR.Elements.BasicElement.Name||
|Property |Aspose.OMR.Elements.BasicElement.Position||
|Property |Aspose.OMR.Elements.BasicElement.Size||
|Property |Aspose.OMR.Elements.ChoiceBoxElement.MultipleSelectionAllowed||
|Property |Aspose.OMR.Elements.GridElement.Sections||
|Property |Aspose.OMR.Elements.GridSection.SpaceAfter||
|Property |Aspose.OMR.Elements.GridSection.SpaceBefore||
|Property |Aspose.OMR.Elements.ISpacedArea.SpaceAfter||
|Property |Aspose.OMR.Elements.ISpacedArea.SpaceBefore||
|Property |Aspose.OMR.Elements.OmrCell.SpaceAfter||
|Property |Aspose.OMR.Elements.OmrCell.SpaceBefore||
|Property |Aspose.OMR.Elements.OmrCell.Value||
|Property |Aspose.OMR.Elements.OmrElement.Cells||
|Property |Aspose.OMR.Elements.OmrElement.Configuration||
|Property |Aspose.OMR.Elements.OmrElement.IsHorizontal||
|Property |Aspose.OMR.Elements.TextOcrElement.Resource||
|Property |Aspose.OMR.ImageProcessing.ProcessingPipeline.Default||
|Property |Aspose.OMR.ImageProcessing.ProcessingPipeline.Item(System.Int32)||
|Property |Aspose.OMR.OmrConfig.FillThreshold||
|Property |Aspose.OMR.OmrConfig.TrimWhitePixels||
|Property |Aspose.OMR.OmrElementsCollection.Item(System.Int32)||
|Property |Aspose.OMR.OmrEngine.Configuration||
|Property |Aspose.OMR.OmrEngine.ProcessingPipeline||
|Property |Aspose.OMR.OmrEngine.Template||
|Property |Aspose.OMR.OmrImage.Buffer||
|Property |Aspose.OMR.OmrImage.Height||
|Property |Aspose.OMR.OmrImage.Resolution||
|Property |Aspose.OMR.OmrImage.Width||
|Property |Aspose.OMR.OmrPage.Configuration||
|Property |Aspose.OMR.OmrPage.Elements||
|Property |Aspose.OMR.OmrPage.Height||
|Property |Aspose.OMR.OmrPage.SheetImage||
|Property |Aspose.OMR.OmrPage.Width||
|Property |Aspose.OMR.OmrPagesCollection.Item(System.Int32)||
|Property |Aspose.OMR.OmrProcessingResult.PageData||
|Property |Aspose.OMR.OmrTemplate.Pages||

