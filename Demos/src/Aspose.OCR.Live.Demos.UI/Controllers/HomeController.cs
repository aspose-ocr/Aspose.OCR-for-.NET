using Aspose.OCR.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.OCR.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Apps, On Premise &amp; Cloud Solutions to Perform OCR on Raster Images";
			ViewBag.MetaDescription = "Build Optical Character Recognition (OCR) solutions via On Premise APIs or Cloud-based SDKs. Or use our simple cross-platform apps for text extraction.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
