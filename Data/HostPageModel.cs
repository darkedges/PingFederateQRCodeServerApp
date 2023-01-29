using Microsoft.AspNetCore.Mvc.RazorPages;
using PingFederateQRCodeServerApp.Controllers;
using System.Linq;
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

        public void OnPost()
        {
            // store the post form in the PostFormService
            PostFormService.QRCodeJump = new QRCodeInit();
            PostFormService.QRCodeJump.item1 = Request.Form["item1"];
			PostFormService.QRCodeJump.item2 = Request.Form["item1"];
			PostFormService.QRCodeJump.item3 = Request.Form["item1"];
			PostFormService.QRCodeJump.item4 = Request.Form["item1"];
            Console.WriteLine("HostPageModel: "+PostFormService.QRCodeJump.ToString());
		}

    }
}
