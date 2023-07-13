using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "MeterValues", OcppMessageAttribute.Direction.PointToCentral)]
    public class MeterValuesRequest : RequestPayload
    {
        public long evseId;

        /// <summary>
        /// Array must contain atleast one entry.
        /// </summary>
        public MeterValue[] meterValue = new MeterValue[0];

    }
}