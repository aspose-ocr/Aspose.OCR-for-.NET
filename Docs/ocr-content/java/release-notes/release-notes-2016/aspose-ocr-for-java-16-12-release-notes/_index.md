---
title: Aspose.OCR for Java 16.12 Release Notes
type: docs
weight: 10
url: /java/aspose-ocr-for-java-16-12-release-notes/
---

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|OCRNET-2956|[Support Dynabic.Metered license for OMR](https://landau.dynabic.com/jira/browse/OCRNET-2956)|New Feature|
|OCRNET-2953|[Images distorted in preprocessing](https://landau.dynabic.com/jira/browse/OCRNET-2953)|Enhancement|
|OCRNET-2907|[Fix filtering usage](https://landau.dynabic.com/jira/browse/OCRNET-2907)|Enhancement|
|OCRNET-2979|[Rename ExtractData method](https://landau.dynabic.com/jira/browse/OCRNET-2979)|Enhancement|
### **Usage Examples**
### **Using Metering license in OMR**
{{< highlight java >}}

 OmrEngine omr = new OmrEngine(new OmrTemplate());

metered = new Metered();

metered.setMeteredKey("publicKeyValue", "privateKeyValue");



double amountBefore = Metered.getConsumptionQuantity();

String path = "sampleimage.png");

OmrImage omrImage = OmrImage.load(path);



//Since upload data is running on another thread, so we need wait some time

Thread.sleep(10000);

double amountAfter = Metered.getConsumptionQuantity();

{{< /highlight >}}
