namespace BtsSalesforceIntegration {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notifications", typeof(global::NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notificationsResponse", typeof(global::NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse))]
    public sealed class MapNotificationResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns1=""urn:sobject.enterprise.soap.sforce.com"" xmlns:ns2=""urn:enterprise.soap.sforce.com"" xmlns:ns0=""http://soap.sforce.com/2005/09/outbound"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:notifications"" />
  </xsl:template>
  <xsl:template match=""/ns0:notifications"">
    <xsl:variable name=""var:v1"" select=""&quot;True&quot;"" />
    <ns0:notificationsResponse>
      <ns0:Ack>
        <xsl:value-of select=""$var:v1"" />
      </ns0:Ack>
    </ns0:notificationsResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notifications";
        
        private const global::NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notificationsResponse";
        
        private const global::NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"NotificationService.NotificationService_soap_sforce_com_2005_09_outbound+notificationsResponse";
                return _TrgSchemas;
            }
        }
    }
}
