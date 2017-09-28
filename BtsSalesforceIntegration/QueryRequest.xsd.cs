namespace BtsSalesforceIntegration {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BtsSalesforceIntegration.QueryRequest",@"QueryRequest")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BtsSalesforceIntegration.PropertySchema.Query), XPath = @"/*[local-name()='QueryRequest' and namespace-uri()='http://BtsSalesforceIntegration.QueryRequest']/*[local-name()='Query' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"QueryRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BtsSalesforceIntegration.PropertySchema.PropertySchema", typeof(global::BtsSalesforceIntegration.PropertySchema.PropertySchema))]
    public sealed class QueryRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BtsSalesforceIntegration.QueryRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BtsSalesforceIntegration.PropertySchema"" targetNamespace=""http://BtsSalesforceIntegration.QueryRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BtsSalesforceIntegration.PropertySchema"" location=""BtsSalesforceIntegration.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""QueryRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Query"" xpath=""/*[local-name()='QueryRequest' and namespace-uri()='http://BtsSalesforceIntegration.QueryRequest']/*[local-name()='Query' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Query"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public QueryRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "QueryRequest";
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
