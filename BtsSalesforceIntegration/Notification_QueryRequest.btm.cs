namespace BtsSalesforceIntegration {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notifications", typeof(global::NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BtsSalesforceIntegration.QueryRequest", typeof(global::BtsSalesforceIntegration.QueryRequest))]
    public sealed class Notification_QueryRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s2 userCSharp"" version=""1.0"" xmlns:ns0=""http://BtsSalesforceIntegration.QueryRequest"" xmlns:s0=""urn:sobject.enterprise.soap.sforce.com"" xmlns:s1=""urn:enterprise.soap.sforce.com"" xmlns:s2=""http://soap.sforce.com/2005/09/outbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:notifications"" />
  </xsl:template>
  <xsl:template match=""/s2:notifications"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SELECT Amount, Id, Name,(SELECT Quantity, ListPrice, PricebookEntry.UnitPrice, PricebookEntry.Name FROM OpportunityLineItems) FROM Opportunity Where Name = '&quot; , string(s2:Notification/s2:sObject/s0:Id/text()) , &quot;'&quot;)"" />
    <ns0:QueryRequest>
      <Query>
        <xsl:value-of select=""$var:v1"" />
      </Query>
    </ns0:QueryRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notifications";
        
        private const global::NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BtsSalesforceIntegration.QueryRequest";
        
        private const global::BtsSalesforceIntegration.QueryRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notifications";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BtsSalesforceIntegration.QueryRequest";
                return _TrgSchemas;
            }
        }
    }
}
