namespace PingFederateQRCodeServerApp.Data.hubs
{
    public interface IQRCode
    {
        Task connected(String connectionId);
        Task authenticated(String userId);
    }
}
