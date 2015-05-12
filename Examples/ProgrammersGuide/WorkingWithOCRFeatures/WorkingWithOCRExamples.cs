using Helpers;
using NUnit.Framework;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

[assembly: AssemblyTitle("Aspose.OCR Examples")]
[assembly: AssemblyDescription("A collection of examples which demonstrate how to use the Aspose.OCR for .NET API.")]
[assembly: AssemblyConfiguration("CSharp")]

namespace Examples.ProgrammersGuide.WorkingWithOCR
{
    [TestClass, TestFixture]
    public class WorkingWithOCRExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void PerformOCROnImage()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithOCR/PerformOCROnImage");

            PerformOCROnImageExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void ExtractingTextPartOfImage()
        {
            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithOCR/ExtractingTextPartOfImage");

            ExtractingTextPartOfImageExample.Program.Main();
        }

    }

    [TestClass, SetUpFixture]
    public class AsposeExamples
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context)
        {
            Main();
        }

        [SetUp]
        public static void AssemblySetup()
        {
            Main();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            TestHelper.Cleanup();
        }

        public static void Main()
        {
            // Provides an introduction of how to use this example project.
            TestHelper.ShowIntroForm();
        }
    }
}
