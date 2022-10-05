using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ClearChargingProfile
    {
        public static readonly ClearChargingProfile Empty = new ClearChargingProfile();

        public long? evseId;
        public ChargingProfilePurposeType.Enum? chargingProfilePurpose;
        public int? stackLevel;
    }
}