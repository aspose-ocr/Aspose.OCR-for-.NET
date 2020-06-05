using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace Aspose.OCR.Live.Demos.UI.Models
{
	///<Summary>
	/// Response class to get or set any api call status
	///</Summary>
	public class Response
	{
		///<Summary>
		/// Get or set DownloadFileLink
		///</Summary>
		public string DownloadFileLink { get; set; }
		///<Summary>
		/// Get or set StatusCode
		///</Summary>
		public int StatusCode { get; set; }
		///<Summary>
		/// Get or set FileName
		///</Summary>
		public string FileName { get; set; }
		///<Summary>
		/// Get or set FolderName
		///</Summary>
		public string FolderName { get; set; }
		///<Summary>
		/// Get or set Status
		///</Summary>
		public string Status { get; set; }
		///<Summary>
		/// Get or set Text
		///</Summary>
		public string Text { get; set; }
		///<Summary>
		/// Get or set Files
		///</Summary>
		public string Files;
		///<Summary>
		/// Get or set FileProcessingErrorCode
		///</Summary>
		public FileProcessingErrorCode FileProcessingErrorCode { get; set; }
					   
		

		public override string ToString()
		{
			//return $"{StatusCode} - {Status}";
			return $"{StatusCode}|{Text}";
			
		}

	}
}
