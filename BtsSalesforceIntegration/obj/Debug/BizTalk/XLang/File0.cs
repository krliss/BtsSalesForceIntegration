
#pragma warning disable 162

namespace NotificationService
{

    [System.SerializableAttribute]
    sealed public class __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notifications__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications _schema = new NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications();

        public __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notifications__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications)
        },
        new string[]{
            "request"
        },
        new System.Type[]{
            typeof(__NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notifications__)
        },
        0,
        @"http://soap.sforce.com/2005/09/outbound#notifications"
    )]
    [System.SerializableAttribute]
    sealed internal class notificationsRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notifications__ request;

        private void __CreatePartWrappers()
        {
            request = new __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notifications__(this, "request", 0);
            this.AddPart("request", 0, request);
        }

        public notificationsRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notificationsResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse _schema = new NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse();

        public __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notificationsResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse)
        },
        new string[]{
            "response"
        },
        new System.Type[]{
            typeof(__NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notificationsResponse__)
        },
        0,
        @"http://soap.sforce.com/2005/09/outbound#notificationsResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class notificationsResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notificationsResponse__ response;

        private void __CreatePartWrappers()
        {
            response = new __NotificationService_NotificationService_soap_sforce_com_2005_09_outbound_notificationsResponse__(this, "response", 0);
            this.AddPart("response", 0, response);
        }

        public notificationsResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "notifications",
        new System.Type[]{
            typeof(NotificationService.notificationsRequest), 
            typeof(NotificationService.notificationsResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class NotificationPort : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public NotificationPort(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public NotificationPort(NotificationPort p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            NotificationPort p = new NotificationPort(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo notifications = new Microsoft.XLANGs.Core.OperationInfo
        (
            "notifications",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(NotificationPort),
            typeof(notificationsRequest),
            typeof(notificationsResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "notifications" ] = notifications;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 111 "C:\Users\krilis\documents\visual studio 2015\Projects\BtsSalesforceIntegration\BtsSalesforceIntegration\NotificationService.odx"
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class NotificationServiceClient : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(NotificationServiceClient));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static NotificationServiceClient()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __NotificationServiceClient_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public NotificationServiceClient(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "NotificationServiceClient", tracker)
        {
            ConstructorHelper();
        }

        public NotificationServiceClient(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "NotificationServiceClient")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>6dae3bd8-423d-4a79-b9b7-3d3e40c15272</ShapeID>      
<children>                </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'NotificationServiceClient'</ActionName><IsAtomic>0</IsAtomic><Line>111</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='e62530e8-ae35-4bbb-9a46-7f03030bea3b' LowerBound='1.1' HigherBound='29.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='NotificationService' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='13fa07a2-5b07-45ca-a67c-341ac9565641' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;NotificationPort&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='NotificationPort' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='61117f98-0026-493f-8f8a-44b6f54f5d74' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;notifications&quot;/&gt;&#xD;&#xA;Process a number of notifications.&#xD;&#xA;' />
                <om:Property Name='Name' Value='notifications' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='611ac8a3-d2c0-448f-8a80-2af7b8e1a4ba' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.33'>
                    <om:Property Name='Ref' Value='NotificationService.notificationsRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://soap.sforce.com/2005/09/outbound:notificationsRequest&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='ce65f38e-831d-46e1-bd26-a314f4f0a9c1' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.35' HigherBound='16.56'>
                    <om:Property Name='Ref' Value='NotificationService.notificationsResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://soap.sforce.com/2005/09/outbound:notificationsResponse&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='b7bcb2f0-dd21-41d7-9d17-fac6c9ec68ac' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;notificationsRequest&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='notificationsRequest' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='48b5a883-96f8-4838-8427-a8abf457862d' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notifications' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;request&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='@request' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='bf2ca873-a351-488c-aa79-e568b0e8cd94' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;notificationsResponse&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='notificationsResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='a0f4882f-4c60-4117-bf3e-b387b6d86c62' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='NotificationService.NotificationService_soap_sforce_com_2005_09_outbound.notificationsResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;response&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='@response' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='1e71a763-901b-47e6-a034-3605d3333cfe' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='28.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:service name=&quot;NotificationService&quot;/&gt;&#xD;&#xA;Notification Service Implementation&#xD;&#xA;' />
            <om:Property Name='Name' Value='NotificationServiceClient' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='6dae3bd8-423d-4a79-b9b7-3d3e40c15272' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='180dbb70-802d-4ca5-be92-26cf8593a052' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Variable_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __NotificationServiceClient_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __NotificationServiceClient_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "NotificationServiceClient")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                NotificationServiceClient __svc__ = (NotificationServiceClient)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __NotificationServiceClient_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __NotificationServiceClient_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "NotificationServiceClient")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                NotificationServiceClient __svc__ = (NotificationServiceClient)_service;
                __NotificationServiceClient_1 __ctx1__ = (__NotificationServiceClient_1)(__svc__._stateMgrs[1]);

                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Variable_1")]
            internal System.Boolean __Variable_1;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] { };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return null; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,0,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __NotificationServiceClient_1 __ctx1__ = (__NotificationServiceClient_1)_stateMgrs[1];
            __NotificationServiceClient_root_0 __ctx0__ = (__NotificationServiceClient_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __NotificationServiceClient_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __NotificationServiceClient_1 __ctx1__ = (__NotificationServiceClient_1)_stateMgrs[1];
            __NotificationServiceClient_root_0 __ctx0__ = (__NotificationServiceClient_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Variable_1 = default(System.Boolean);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__Variable_1 = true;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 6;
            case 6:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
