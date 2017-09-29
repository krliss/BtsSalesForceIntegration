using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.BizTalk.Adapter.Behaviors
{
    public class SalesforceRESTBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(SalesforceRESTSecurityBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new SalesforceRESTSecurityBehavior(Username, Password, ConsumerKey, ConsumerSecret, SessionTimeout);
        }

        [ConfigurationProperty("username", IsRequired = true)]
        public string Username
        {
            get { return (string)this["username"]; }
            set { this["username"] = value; }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get { return (string)this["password"]; }
            set { this["password"] = value; }
        }

        [ConfigurationProperty("consumerKey", IsRequired = true)]
        public string ConsumerKey
        {
            get { return (string)this["consumerKey"]; }
            set { this["consumerKey"] = value; }
        }

        [ConfigurationProperty("consumerSecret", IsRequired = true)]
        public string ConsumerSecret
        {
            get { return (string)this["consumerSecret"]; }
            set { this["consumerSecret"] = value; }
        }

        [ConfigurationProperty("sessionTimeout", IsRequired = false, DefaultValue = 300)]
        public int SessionTimeout
        {
            get { return (int)this["sessionTimeout"]; }
            set { this["sessionTimeout"] = value; }
        }
    }
}
