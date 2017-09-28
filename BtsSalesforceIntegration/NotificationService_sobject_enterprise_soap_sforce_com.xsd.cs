namespace NotificationService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NotificationService.NotificationService_enterprise_soap_sforce_com", typeof(global::NotificationService.NotificationService_enterprise_soap_sforce_com))]
    public sealed class NotificationService_sobject_enterprise_soap_sforce_com : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""urn:sobject.enterprise.soap.sforce.com"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""NotificationService.NotificationService_enterprise_soap_sforce_com"" namespace=""urn:enterprise.soap.sforce.com"" />
  <annotation>
    <appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:enterprise.soap.sforce.com"" />
      </references>
    </appinfo>
  </annotation>
  <complexType name=""sObject"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""unbounded"" name=""fieldsToNull"" nillable=""true"" type=""string"" />
      <element xmlns:q1=""urn:enterprise.soap.sforce.com"" name=""Id"" nillable=""true"" type=""q1:ID"" />
    </sequence>
  </complexType>
  <complexType name=""AggregateResult"">
    <complexContent mixed=""false"">
      <extension xmlns:q2=""urn:sobject.enterprise.soap.sforce.com"" base=""q2:sObject"">
        <sequence>
          <any minOccurs=""0"" maxOccurs=""unbounded"" namespace=""##targetNamespace"" processContents=""lax"" />
        </sequence>
      </extension>
    </complexContent>
  </complexType>
  <complexType name=""Opportunity"">
    <complexContent mixed=""false"">
      <extension xmlns:q3=""urn:sobject.enterprise.soap.sforce.com"" base=""q3:sObject"">
        <sequence>
          <element minOccurs=""0"" name=""Amount"" nillable=""true"" type=""double"" />
          <element minOccurs=""0"" name=""Products_Of_Interest__c"" nillable=""true"" type=""string"" />
        </sequence>
      </extension>
    </complexContent>
  </complexType>
</schema>";
        
        public NotificationService_sobject_enterprise_soap_sforce_com() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
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
