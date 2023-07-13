using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingProfileCriterion
    {
        public static readonly ChargingProfileCriterion Empty = new ChargingProfileCriterion();

        public ChargingProfilePurposeType.Enum? chargingProfilePurpose;
        public int? stackLevel;
        public int[]? chargingProfileId;

        /// <summary>
        /// Array length must not exceed 4.
        /// </summary>
        public ChargingLimitSourceType.Enum[]? chargingLimitSource;
    }
}