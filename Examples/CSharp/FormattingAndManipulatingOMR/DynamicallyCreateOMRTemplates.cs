using System;
using System.Collections;
using System.Drawing;
using System.IO;
using Aspose.OCR;
using Aspose.OMR;
using Aspose.OMR.Elements;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.OCR for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.OCR for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.OCR.Examples.CSharp.FormattingAndManipulatingOMR
{
    public class DynamicallyCreateOMRTemplates
    {
        public static void Run()
        {
            // ExStart:DynamicallyCreateOMRTemplates
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OMR();
            OmrTemplate template = new OmrTemplate();
            OmrPage page = template.Pages[0];
            page.Width = 215.9;
            page.Height = 279.4;
            PointF choiceBoxPosition = new PointF(20, 5); // 20 mm to the right, 5 mm from the top
            SizeF choiceBoxSize = new SizeF(12, 24);
            ChoiceBoxElement choiceBox = new ChoiceBoxElement("AnotherElement", choiceBoxPosition, choiceBoxSize);
            choiceBox.IsHorizontal = false;
            choiceBox.Cells.Add(new OmrCell("A")); // Three marks: (A) (B) (C)
            choiceBox.Cells.Add(new OmrCell("B"));
            choiceBox.Cells.Add(new OmrCell("C"));
            page.Elements.Add(choiceBox);
            template.Save(dataDir + "New_template_out.amr");
            // ExEnd:DynamicallyCreateOMRTemplates
        }
    }
}
