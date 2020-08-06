---
title: Licensing
type: docs
weight: 50
url: /java/licensing/
---

{{% alert color="primary" %}} 

You can download an evaluation version of **Aspose.OCR** for Java from [its download page](http://maven.aspose.com/repository/simple/ext-release-local/com/aspose/aspose-ocr/). The evaluation version provides absolutely the same capabilities as the licensed version of the product. Furthermore, evaluation version simply becomes licensed when you purchase a license and add a couple of lines of code to apply the license.

Once you are happy with your evaluation of **Aspose.OCR**, you can [purchase a license](https://purchase.aspose.com/default.aspx) at the Aspose website. Make yourself familiar with the different subscription types offered. If you have any questions, do not hesitate to contact the Aspose sales team.

Every Aspose license carries a one-year subscription for free upgrades to any new versions or fixes that come out during this time. Technical support is free and unlimited and provided both to licensed and evaluation users.

{{% /alert %}} 

If you want to test **Aspose.OCR** without evaluation version limitations, request a 30-day temporary license. Please refer to [How to get a Temporary License?](https://purchase.aspose.com/temporary-license) for more information.
### **Evaluation Version Limitations**
The evaluation version of **Aspose.OCR** (that is, the component running without a license applied) limits the number of characters extracted from an image to 50. 
### **Setting a License**
The license is a plain text XML file that contains details such as the product name, number of developers it is licensed to, subscription expiry date and so on. The file is digitally signed, so do not modify the file; even the inadvertent addition of an extra line break into the file will invalidate it.

You need to apply a license before starting the character and/or marker recognition process. You are only required to set a license once per application or process.

The license can be loaded from a stream or file in the following locations:

1. Explicit path.
1. The folder that contains the Aspose.OCR.jar.

Use the [License](http://www.aspose.com/api/java/ocr/com.aspose.ocr/classes/License).setLicense method to license the component. Often the easiest way to set a license is to put the license file in the same folder as Aspose.OCR.jar and specify just the file name without path as shown in the following example:
#### **Example 1**
In this example **Aspose.OCR** will attempt to find the license file in the folder that contain the JARs of your application.

**Java**

{{< highlight csharp >}}

 com.aspose.ocr.License license = new com.aspose.ocr.License();

license.setLicense("Aspose.OCR.Java.lic");

{{< /highlight >}}
#### **Example 2**
Initializes a license from a stream.

**Java**

{{< highlight csharp >}}

 com.aspose.ocr.License license = new com.aspose.ocr.License();

license.setLicense(new java.io.FileInputStream("Aspose.OCR.Java.lic"));

{{< /highlight >}}
### **Validate the License**
It is possible to validate if the license has been set properly or not. The [License](https://apireference.aspose.com/java/ocr/com.aspose.ocr/License) class has the isLicensed field that will return true if license has been properly set.

**Java**

{{< highlight csharp >}}

 License license = new License();

license.setLicense("Aspose.OCR.Java.lic");

if (License.isLicensed()) {

    System.out.println("License is Set!");

}

{{< /highlight >}}
