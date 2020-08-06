---
title: Aspose.OCR for Java 3.6.0 Release Notes
type: docs
weight: 50
url: /java/aspose-ocr-for-java-3-6-0-release-notes/
---

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|OCRNET-1152|The angle of rotation is calculated inproperly|Enhancement|
|OCRNET-1250|Improve neighbor-based skew corrector quality on small images and small angles|Enhancement|
|OCRNET-1277|Support faster image rotation algorithm|Enhancement|
|OCRNET-1108|Incorrect textblock calculation for deskewed image|Enhancement|
# **Usage examples:**
*Method com.aspose.omr.OmrEngine.rotateImage(com.aspose.omr.OmrImage, double) added instead of method com.aspose.omr.OmrEngine.rotateImage(com.aspose.omr.OmrImage,int)

{{< highlight java >}}

 OmrImage image = OmrImage.load("sample.jpg");

OmrEngine engine = new OmrEngine(new OmrTemplate());

double degree = engine.getSkewDegree(image);

image = engine.rotateImage(image, degree);

BufferedImage actualImage = image.asBitmap();

{{< /highlight >}}
### **OCRNET-1108 Incorrect textblock calculation for deskewed image**
{{< highlight java >}}

 String pictureFileName = "VodafoneBillImage1.jpg";

OcrEngine ocrEngine = new OcrEngine();

ocrEngine.getConfig().clearRecognitionBlocks();

ocrEngine.setImage(ImageStream.fromFile(pictureFileName));

ocrEngine.getConfig().setDetectTextRegions(false);

ocrEngine.getConfig().addRecognitionBlock(RecognitionBlock.createTextBlock(122, 570, 373, 36));

ocrEngine.getConfig().setSavePreprocessedImages(true);

if (ocrEngine.process())

{

    PreprocessedImages preprocessedImages = ocrEngine.getPreprocessedImages();

    BufferedImage bufferedImage = preprocessedImages.getTextBlocksImage();

    try

    {

        ImageIO.write(bufferedImage, "png", new File("block.png"));

    }

    catch (IOException e)

    {

        e.printStackTrace();

    }

}

{{< /highlight >}}
