namespace BtsSalesforceIntegration {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BtsSalesforceIntegration.QueryResult",@"QueryResult")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"QueryResult"})]
    public sealed class QueryResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BtsSalesforceIntegration.QueryResult"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BtsSalesforceIntegration.QueryResult"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""QueryResult"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""done"" type=""xs:string"" />
        <xs:sequence>
          <xs:element name=""Records"">
            <xs:complexType>
              <xs:sequence>
                <xs:element name=""type"" type=""xs:string"" />
                <xs:element name=""url"" type=""xs:string"" />
                <xs:element name=""Id"" type=""xs:string"" />
                <xs:element name=""Amount"" type=""xs:string"" />
                <xs:element name=""Name"" type=""xs:string"" />
                <xs:sequence>
                  <xs:element name=""OpportunityLineItems"">
                    <xs:complexType>
                      <xs:sequence>
                        <xs:element name=""done"" type=""xs:string"" />
                        <xs:sequence minOccurs=""1"" maxOccurs=""unbounded"">
                          <xs:element name=""Records"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""type"" type=""xs:string"" />
                                <xs:element name=""url"" type=""xs:string"" />
                                <xs:element name=""Quantity"" type=""xs:string"" />
                                <xs:element name=""ListPrice"" type=""xs:string"" />
                                <xs:element name=""PricebookEntry"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""type"" type=""xs:string"" />
                                      <xs:element name=""url"" type=""xs:string"" />
                                      <xs:element name=""UnitPrice"" type=""xs:string"" />
                                      <xs:element name=""Name"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                        <xs:element name=""totalSize"" type=""xs:string"" />
                      </xs:sequence>
                    </xs:complexType>
                  </xs:element>
                </xs:sequence>
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
        <xs:element name=""totalSize"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public QueryResult() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "QueryResult";
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
