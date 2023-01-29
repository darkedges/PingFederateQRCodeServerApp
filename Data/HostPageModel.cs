using Microsoft.AspNetCore.Mvc.RazorPages;
using PingFederateQRCodeServerApp.Controllers;
using System.Linq;
using System.Net.Mail;
using System.Security.Authentication;
using System.Xml.Linq;

namespace PingFederateQRCodeServerApp.Data
{
	public class HostPageModel : PageModel
	{
		// postFormService is injected by the DI
		public HostPageModel(PostFormService postFormService)
		{
			PostFormService = postFormService;
		}

		private PostFormService PostFormService { get; }
		public static List<string> PostComponentPages = new List<string>() { "/", "/qrcode" };


		public void OnPost()
		{
			if (PostComponentPages.Any(c => Request.Path.ToString().Contains(c)))
			{
				// store the post form in the PostFormService
				PostFormService.QRCodeJump = new QRCodeInitRequest();
				PostFormService.QRCodeJump.init1 = Request.Form["item1"];
				PostFormService.QRCodeJump.init2 = Request.Form["item2"];
				PostFormService.QRCodeJump.init3 = Request.Form["item3"];
				PostFormService.QRCodeJump.init4 = Request.Form["item4"];
			}
		}

		public void OnGet()
		{
			if (PostComponentPages.Any(c => Request.Path.ToString().Equals(c)))
			{
				throw new AuthenticationException("No Init Data Supplied");
			}
		}
	}
}
