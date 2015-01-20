Imports System.Reflection
Imports Helpers
Imports NUnit.Framework
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Assert = NUnit.Framework.Assert
Imports Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute

<Assembly: AssemblyTitle("Aspose.OCR Examples")>
<Assembly: AssemblyDescription("A collection of examples which demonstrate how to use the Aspose.OCR for .NET API.")>
<Assembly: AssemblyConfiguration("VisualBasic")>

Namespace Examples.ProgrammersGuide.WorkingWithOCR
	<TestClass, TestFixture> _
	Public Class WorkingWithOCRExamples
        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub PerformOCROnImage()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithOCR/PerformOCROnImage")
	
	            PerformOCROnImageExample.Program.Main()
        End Sub

        <TestMethod(), Test(), Owner("Console")> _
	        Public Sub ExtractingTextPartOfImage()
	            TestHelper.SetDataDir("ProgrammersGuide/WorkingWithOCR/ExtractingTextPartOfImage")
	
	            ExtractingTextPartOfImageExample.Program.Main()
        End Sub

	End Class

	<TestClass, SetUpFixture> _
	Public Class AsposeExamples
		<AssemblyInitialize> _
		Public Shared Sub AssemblyInitialize(ByVal context As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
			Main()
		End Sub

		<SetUp> _
		Public Shared Sub AssemblySetup()
			Main()
		End Sub

		<AssemblyCleanup> _
		Public Shared Sub AssemblyCleanup()
			TestHelper.Cleanup()
		End Sub

		Public Shared Sub Main()
		    ' Provides an introduction of how to use this example project.
			TestHelper.ShowIntroForm()
		End Sub
	End Class
End Namespace