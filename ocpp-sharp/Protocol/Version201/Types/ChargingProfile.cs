using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingProfile
    {
        public static readonly ChargingProfile Empty = new ChargingProfile();

        public long id;
        public int stackLevel;
        public ChargingProfilePurposeType.Enum chargingProfilePurpose;
        public ChargingProfileKindType.Enum chargingProfileKind;
        public RecurrencyKindType.Enum recurrencyKind;
    }
}