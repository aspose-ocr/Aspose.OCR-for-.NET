using System;
using System.Web.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using Aspose.OCR.Cloud.Transport;
using Aspose.OCR.Cloud.Transport.Logic.Config;
using Aspose.OCR.Cloud.Transport.Logic.Request;
using Aspose.OCR.Cloud.Transport.Logic.Response;
using System.IO;

namespace Aspose.OCR.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeOCR class to perform OCR operations 
	///</Summary>
	
	public class AsposeOCR : AsposeOCRBase
	{

		public Response RecognizeImage(string fileName, string folderName)
		{
			string ocrText = null;
			try
			{
				

				TransportSync ocrTransportSync = new TransportSync();
				ServerConfig ocrTransportConfig = new AmazonML1PublicServerConfig();





				//convert web Stream to string with encoded image with base64
				string base64Image = null;
				MemoryStream memoryStream = new MemoryStream();

				using (FileStream fileStream = File.Open(Path.Combine(Config.Configuration.WorkingDirectory, folderName, fileName),
	FileMode.Open))
				{
					// Copy filestream to memorystream to destination.
					fileStream.CopyTo(memoryStream);
					base64Image = Convert.ToBase64String(memoryStream.ToArray());
				}


				// Put Image on OCR Server for processing, Get back task (operation descriptor)
				OcrRecognizeRequest recognizeRequest = new OcrRecognizeRequest(ocrTransportConfig, "AsposeApp2020UI", base64Image);
				OcrRecognizeResponse recognizeResponse = ocrTransportSync.MakeRequestSync<OcrRecognizeRequest, OcrRecognizeResponse>(recognizeRequest);



				// Send request to get processing (recognition) result from OCR server. Send descriptor, wait, get text.
				OcrCompletionRequest completionRequest = new OcrCompletionRequest(ocrTransportConfig, "AsposeApp2020UI", recognizeResponse.ScheduledTaskId);
				OcrCompletionResponse completionResponse = ocrTransportSync.MakeRequestSync<OcrCompletionRequest, OcrCompletionResponse>(completionRequest);

				ocrText = completionResponse.CompletedTask.ResultText;

			}
			catch (Exception ex)
			{
				ocrText = ex.Message;

				return new Response
				{
					Text = ocrText,

					StatusCode = 0
				};
			}
			

			
			return new Response { Text = ocrText,

			StatusCode = 200};
		}
		

	}
}
