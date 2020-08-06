---
title: Aspose.OCR for .NET 2.9.0 Release Notes
type: docs
weight: 40
url: /net/aspose-ocr-for-net-2-9-0-release-notes/
---

We are pleased to share a new version of Aspose.OCR for .NET with following improvements: 
## **New Features**
OCR-34143 Implement Control + mouse scroll zoom hotkey

OCR-34140 Ability to load the OMR Template (amr) from URL in the same way scanned image can be loaded from a remote location

OCR-34116 Add support of multipage recognition
## **Enhancements**
OCR-34147 Empty results in the template editor

OCR-34146 Unable to set Java license for Java mode in Template Editor.
# **Public API and Backwards Incompatible Changes**
The following is a list of any changes made to the public API such as added, renamed, removed or deprecated members as well as any non-backward compatible change made to Aspose.OCR for .NET. If you have concerns about any change listed, please raise it on the Aspose.OCR support forum. 
Added APIs:

Method Aspose.OMR.OmrImage.LoadFromUrl(System.String)

Method Aspose.OMR.OmrTemplate.LoadFromUrl(System.String)

Removed APIs:
None 
Important Note
Aspose.OCR component uses resource files to perform OCR operations on specific languages. From 2.2.0 version resource file for default language (English) is embedded into Aspose.OCR.dll and there is no need to download it separately. Currently recognition of French, Spanish and Portuguese languages is also supported. You can download specific resource files from this page 
.
