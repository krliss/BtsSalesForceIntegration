namespace NotificationService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"notifications", @"notificationsResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NotificationService.NotificationService_enterprise_soap_sforce_com", typeof(global::NotificationService.NotificationService_enterprise_soap_sforce_com))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NotificationService.NotificationService_sobject_enterprise_soap_sforce_com", typeof(global::NotificationService.NotificationService_sobject_enterprise_soap_sforce_com))]
    public sealed class NotificationService_soap_sforce_com_2005_09_outbound : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://soap.sforce.com/2005/09/outbound"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""NotificationService.NotificationService_enterprise_soap_sforce_com"" namespace=""urn:enterprise.soap.sforce.com"" />
  <import schemaLocation=""NotificationService.NotificationService_sobject_enterprise_soap_sforce_com"" namespace=""urn:sobject.enterprise.soap.sforce.com"" />
  <annotation>
    <appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:enterprise.soap.sforce.com"" />
        <reference targetNamespace=""urn:sobject.enterprise.soap.sforce.com"" />
      </references>
    </appinfo>
  </annotation>
  <element name=""notifications"">
    <complexType>
      <sequence>
        <element xmlns:q1=""urn:enterprise.soap.sforce.com"" name=""OrganizationId"" type=""q1:ID"" />
        <element xmlns:q2=""urn:enterprise.soap.sforce.com"" name=""ActionId"" type=""q2:ID"" />
        <element name=""SessionId"" nillable=""true"" type=""string"" />
        <element name=""EnterpriseUrl"" type=""string"" />
        <element name=""PartnerUrl"" type=""string"" />
        <element xmlns:q3=""http://soap.sforce.com/2005/09/outbound"" maxOccurs=""100"" name=""Notification"" type=""q3:OpportunityNotification"" />
      </sequence>
    </complexType>
  </element>
  <complexType name=""OpportunityNotification"">
    <sequence>
      <element xmlns:q4=""urn:enterprise.soap.sforce.com"" name=""Id"" type=""q4:ID"" />
      <element xmlns:q5=""urn:sobject.enterprise.soap.sforce.com"" name=""sObject"" type=""q5:Opportunity"" />
    </sequence>
  </complexType>
  <element name=""notificationsResponse"">
    <complexType>
      <sequence>
        <element name=""Ack"" type=""boolean"" />
      </sequence>
    </complexType>
  </element>
</schema>";
        
        public NotificationService_soap_sforce_com_2005_09_outbound() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "notifications";
                _RootElements[1] = "notificationsResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://soap.sforce.com/2005/09/outbound",@"notifications")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"notifications"})]
        public sealed class notifications : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public notifications() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "notifications";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://soap.sforce.com/2005/09/outbound",@"notificationsResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"notificationsResponse"})]
        public sealed class notificationsResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public notificationsResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "notificationsResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
