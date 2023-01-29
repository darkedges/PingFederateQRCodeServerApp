using Microsoft.AspNetCore.SignalR;

namespace PingFederateQRCodeServerApp.Data.hubs
{
    public class QRCodeHub : Hub<IQRCode>
    {
        public override Task OnConnectedAsync()
        {

            base.OnConnectedAsync();

            Clients.Caller.connected(Context.ConnectionId);
            return Task.CompletedTask;
        }
    }
}
