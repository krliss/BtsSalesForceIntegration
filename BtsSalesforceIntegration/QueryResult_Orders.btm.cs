namespace BtsSalesforceIntegration {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BtsSalesforceIntegration.QueryResult", typeof(global::BtsSalesforceIntegration.QueryResult))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BtsSalesforceIntegration.InsertOrdersTableOperation_dbo_OrderDetails+Insert", typeof(global::BtsSalesforceIntegration.InsertOrdersTableOperation_dbo_OrderDetails.Insert))]
    public sealed class QueryResult_Orders : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/OrderDetails"" xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:s0=""http://BtsSalesforceIntegration.QueryResult"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryResult"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryResult"">
    <ns0:Insert>
      <ns0:Rows>
        <xsl:for-each select=""Records/OpportunityLineItems/Records"">
          <ns3:OrderDetails>
            <ns3:TITLE>
              <xsl:value-of select=""../../Name/text()"" />
            </ns3:TITLE>
            <ns3:ProductName>
              <xsl:value-of select=""PricebookEntry/Name/text()"" />
            </ns3:ProductName>
            <ns3:Quantity>
              <xsl:value-of select=""Quantity/text()"" />
            </ns3:Quantity>
            <ns3:Amount>
              <xsl:value-of select=""ListPrice/text()"" />
            </ns3:Amount>
          </ns3:OrderDetails>
        </xsl:for-each>
      </ns0:Rows>
    </ns0:Insert>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BtsSalesforceIntegration.QueryResult";
        
        private const global::BtsSalesforceIntegration.QueryResult _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BtsSalesforceIntegration.InsertOrdersTableOperation_dbo_OrderDetails+Insert";
        
        private const global::BtsSalesforceIntegration.InsertOrdersTableOperation_dbo_OrderDetails.Insert _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BtsSalesforceIntegration.QueryResult";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BtsSalesforceIntegration.InsertOrdersTableOperation_dbo_OrderDetails+Insert";
                return _TrgSchemas;
            }
        }
    }
}
