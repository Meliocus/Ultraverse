using System.Net;

namespace Ultraverse.models
{
    public class SessionModel
    {
        public UserModel? User { get; private set; }

        public string SesionsId { get; private init ; }

        public bool Logged => User != null;

        public IPAddress? AddressIp { get; set; }

        public DateTime LastActive { get; set; }

        public SessionModel(string sessionId)
        {
            SesionsId = sessionId;
        }
    }

   
}
