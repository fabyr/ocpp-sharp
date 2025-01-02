using OcppSharp.Protocol;

namespace OcppSharp;

public enum ProtocolVersion
{
    [StringValue("ocpp1.6")]
    OCPP16,

    [StringValue("ocpp2.0.1")]
    OCPP201
}
