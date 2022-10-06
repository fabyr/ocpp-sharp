using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct Transaction
    {
        public static readonly Transaction Empty = new Transaction();

        public CiString transactionId;
        public ChargingStateType.Enum? chargingState;
        public int? timeSpentCharging;
        public ReasonType.Enum? stoppedReason;
        public long? remoteStartId;
    }
}