using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Xml;
using System.Net;
using System.IO;
using System.ServiceModel.Configuration;
using System.Configuration;
using System.Web.Script.Serialization;

namespace Microsoft.BizTalk.Adapter.Behaviors
{
    public class SalesforceOAuthToken
    {
        public string id { get; set; }
        public string issued_at { get; set; }
        public string refresh_token { get; set; }
        public string instance_url { get; set; }
        public string signature { get; set; }
        public string access_token { get; set; }
    }
}
