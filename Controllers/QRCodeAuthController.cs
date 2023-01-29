using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PingFederateQRCodeServerApp.Data.hubs;
using PingFederateQRCodeServerApp.Shared;

namespace PingFederateQRCodeServerApp.Controllers
{
    [Route("api/qrcode")]
    [ApiController]
    public class QRCodeAuthController : ControllerBase
    {

        private readonly ILogger<QRCodeAuthController> _logger;
        private readonly IHubContext<QRCodeHub,IQRCode> _hubContext;

        public QRCodeAuthController(ILogger<QRCodeAuthController> logger, IHubContext<QRCodeHub,IQRCode> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        [HttpPost("")]
        public IActionResult Post(QRCodeAuthenticationRequest qrCodeAuthentication)
        {
            QRCodeResponse response = new QRCodeResponse
            {
                Summary = "Created",
                ConnectionID = qrCodeAuthentication.connectionId
            };
            _hubContext.Clients.Client(qrCodeAuthentication.connectionId).authenticated(qrCodeAuthentication.username);
            return Created("api/qrcode", response);
        }
    }
}
