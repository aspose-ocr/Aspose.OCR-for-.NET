using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.OCR.Live.Demos.UI.Controllers;
using Aspose.OCR.Live.Demos.UI.Config;

namespace Aspose.OCR.Live.Demos.UI.Models
{
  public class HowToModel : BaseRootPage
	{
    public string PageTitle { get; set; }
    public List<string> List { get; set; }
    
    public ViewModel VMParent;
 
    public string AppName => VMParent.AppName;

    public HowToModel(ViewModel parent)
    {
			VMParent = parent;

			string extension = "document";

	  List = new List<string>();
      var title = Resources.ContainsKey($"{VMParent.Product}Howto{AppName}Title")
        ? Resources[$"{VMParent.Product}Howto{AppName}Title"]
        : Resources[$"Howto{AppName}Title"];
      var titleEnd = title.EndsWith("file.") ? extension : VMParent.PageProductTitle + " " + AppName;
           
        Title = string.Format(title, "", titleEnd);
     

      var hw = "Howto" + VMParent.AppName + "Feature";
      var i = 1;
      while (Resources.ContainsKey(hw + i))
      {
        List.Add(Resources[hw + i]);
        i++;
      }
    }
  }
}
