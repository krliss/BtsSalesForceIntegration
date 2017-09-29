namespace BtsSalesforceIntegration {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderDetails", @"ArrayOfOrderDetails"})]
    public sealed class InsertOrdersTable_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Table.dbo</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""OrderDetails"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ID"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TITLE"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""200"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductName"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""200"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Quantity"" nillable=""true"" type=""xs:double"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Amount"" nillable=""true"" type=""xs:double"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrderDetails"" nillable=""true"" type=""ns3:OrderDetails"" />
  <xs:complexType name=""ArrayOfOrderDetails"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrderDetails"" type=""ns3:OrderDetails"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOrderDetails"" nillable=""true"" type=""ns3:ArrayOfOrderDetails"" />
</xs:schema>";
        
        public InsertOrdersTable_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "OrderDetails";
                _RootElements[1] = "ArrayOfOrderDetails";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo",@"OrderDetails")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderDetails"})]
        public sealed class OrderDetails : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderDetails() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderDetails";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo",@"ArrayOfOrderDetails")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOrderDetails"})]
        public sealed class ArrayOfOrderDetails : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOrderDetails() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOrderDetails";
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
