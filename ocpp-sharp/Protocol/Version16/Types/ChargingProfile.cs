using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct ChargingProfile
    {
        public static readonly ChargingProfile Empty = new ChargingProfile();

        public long chargingProfileId;
        public long? transactionId;
        public ulong stackLevel;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ChargingProfilePurposeType"/>
        /// </summary>
        public MessageConstants.ChargingProfilePurposeType.Enum chargingProfilePurposeType;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ChargingProfileKindType"/>
        /// </summary>
        public MessageConstants.ChargingProfileKindType.Enum chargingProfileKind;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.RecurrencyKindType"/>
        /// </summary>
        public MessageConstants.RecurrencyKindType.Enum? recurrencyKind;
        public DateTime? validFrom;
        public DateTime? validTo;
        public ChargingSchedule chargingSchedule;
    }
}