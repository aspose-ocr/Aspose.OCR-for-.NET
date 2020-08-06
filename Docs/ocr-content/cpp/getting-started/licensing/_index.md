---
title: Licensing
type: docs
weight: 50
url: /cpp/licensing/
---

## **Evaluation Version Limitations**
The evaluation version of Aspose.OCR for C++ limits the number of characters extracted from an image to 300.
## **Apply License**
The easiest way to apply a license is to put the license file in the same folder as the Aspose.OCR.dll file and specify just the file name without a path.

{{% alert color="primary" %}} 

When you call the *set_license* method, the license name that you pass should be that of the license file. For example, if you change the license file name to "Aspose.OCR.lic" pass that filename to the *set_license* method.

{{% /alert %}} 

{{< gist "aspose-com-gists" "0a96b16b37da1f556e7081063782ec02" "Aspose.OCR-for-C-main-SetLicense.cpp" >}}
## **Check License State**
Aspose.OCR provides the *get_state* method that returns **true** if the license is set and **false** if the license is not set. The following example shows how to check the state of the license.

{{< gist "aspose-com-gists" "0a96b16b37da1f556e7081063782ec02" "Aspose.OCR-for-C-main-CheckLicenseState.cpp" >}}
