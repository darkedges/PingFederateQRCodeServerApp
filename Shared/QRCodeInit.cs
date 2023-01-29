using PingFederateQRCodeServerApp.Data;

namespace PingFederateQRCodeServerApp.Controllers
{
    public class QRCodeInit
    {

		public string item1 { get; set; } = "";
        public string item2 { get; set; } = "";
		public string item3 { get; set; } = "";
		public string item4 { get; set; } = "";

		public override string ToString()
		{
			return String.Format("item1: '{0}'. item2: '{1}'. item3: '{2}'. item4: '{3}'.", item1, item2, item3, item4);
		}
	}
}
