using Aspose.OCR.Live.Demos.UI.Models.Common;
using Aspose.OCR.Live.Demos.UI.Models;
using Aspose.OCR.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace Aspose.OCR.Live.Demos.UI.Controllers
{
	public class ScanImageController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];
		
		[HttpPost]
		public Response RecognizeImage()
		{
					
			Response response = null;
			var files = Request.Files;
			string zipFileName = "";
			foreach (string fileName in Request.Files)
			{
				HttpPostedFileBase postedFile = Request.Files[fileName];

				if (postedFile != null)
				{
					var isFileUploaded = FileManager.UploadFile(postedFile);

					if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
					{
						AsposeOCR asposeOCR = new AsposeOCR();
						 response = asposeOCR.RecognizeImage(isFileUploaded.FileName, isFileUploaded.FolderId);

						if (response == null)
						{
							throw new Exception(Resources["ResponseTime"]);
						}
						

					}
				}

			}

			return response;			
				
		}

		

		public ActionResult ScanImage()
		{
			var model = new ViewModel(this, "ScanImage")
			{
				SaveAsComponent = false,
				SaveAsOriginal = false,
				MaximumUploadFiles = 1

				
			};

			return View(model);
		}
		

	}
}
