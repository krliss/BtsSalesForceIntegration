using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Microsoft.BizTalk.Adapter.Behaviors
{
    public class SalesforceRESTSecurityBehavior : IClientMessageInspector, IEndpointBehavior
    {
        // Some constants  
        private static string SalesforceAuthEndpoint = "https://login.salesforce.com/services/oauth2/token";

        // Configuration Properties  
        private string username_;
        private string password_;
        private string consumerKey_;
        private string consumerSecret_;
        private int sessionTimeout_;

        // Private Properties  
        private SalesforceOAuthToken token_;
        private DateTime tokenExpiryTime_;

        public SalesforceRESTSecurityBehavior(
            string username,
            string password,
            string consumerKey,
            string consumerSecret,
            int sessionTimeout)
        {
            this.username_ = username;
            this.password_ = password;
            this.consumerKey_ = consumerKey;
            this.consumerSecret_ = consumerSecret;
            this.sessionTimeout_ = sessionTimeout;
        }

        private void FetchOAuthToken()
        {
            if ((tokenExpiryTime_ == null) || (tokenExpiryTime_.CompareTo(DateTime.Now) <= 0))
            {
                StringBuilder body = new StringBuilder();
                body.Append("grant_type=password&")
                    .Append("client_id=" + consumerKey_ + "&")
                    .Append("client_secret=" + consumerSecret_ + "&")
                    .Append("username=" + username_ + "&")
                    .Append("password=" + password_);

                string result;

                try
                {
                    result = HttpPost(SalesforceAuthEndpoint, body.ToString());
                }
                catch (WebException)
                {
                    // do something  
                    return;
                }

                // Convert the JSON response into a token object  
                JavaScriptSerializer ser = new JavaScriptSerializer();
                this.token_ = ser.Deserialize<SalesforceOAuthToken>(result);
                this.tokenExpiryTime_ = DateTime.Now.AddSeconds(this.sessionTimeout_);
            }
        }

        public string HttpPost(string URI, string Parameters)
        {
            WebRequest req = WebRequest.Create(URI);
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";

            // Add parameters to post  
            byte[] data = Encoding.ASCII.GetBytes(Parameters);
            req.ContentLength = data.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(data, 0, data.Length);
            os.Close();

            // Do the post and get the response.  
            System.Net.WebResponse resp = null;
            resp = req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
        #region IClientMessageInspector  

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            // do nothing  
        }
        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            // We are going to send a request to Salesforce  
            // Overview:  
            // This behavior will do the following:  
            // (1) Fetch Token from Salesforce, if required  
            // (2) Add the token to the message  
            // (3) Insert an Http Accept header so we get XML data in response, instead of JSON, which is default  
            // Reference: http://www.salesforce.com/us/developer/docs/api_rest/index.htm  
            //  
            // (1) Authentication with Salesforce  
            // (2) The token is added to the HTTP Authorization Header   
            // (3) Add the Accept Header  
            //  

            HttpRequestMessageProperty httpRequest = null;

            if (request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
            {
                httpRequest = request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
            }

            if (httpRequest == null)
            {
                // NOTE: Ideally, we shouldn’t get here for WebHttp  
                httpRequest = new HttpRequestMessageProperty()
                {
                    Method = "GET",
                    SuppressEntityBody = true
                };
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequest);
            }

            WebHeaderCollection headers = httpRequest.Headers;
            FetchOAuthToken();

            headers.Add(HttpRequestHeader.Authorization, "OAuth " + this.token_.access_token);
            headers.Add(HttpRequestHeader.Accept, "application/xml");

            return null;
        }

        #endregion IClientMessageInspector  

        #region IEndpointBehavior  

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            // do nothing  
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(this);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            // do nothing  
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            // do nothing  
        }

        #endregion IEndpointBehavior  
    }
}
