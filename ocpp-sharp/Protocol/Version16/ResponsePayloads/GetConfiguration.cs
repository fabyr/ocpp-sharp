using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetConfiguration", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetConfigurationResponse : ResponsePayload
    {
        public KeyValue[]? configurationKey;
        public CiString[]? unknownKey;

        public KeyValue? this[string key]
        {
            get 
            {
                return configurationKey?.FirstOrDefault(x => CiString.Equals(x.key, key));
            }
        }
    }
}